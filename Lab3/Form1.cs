using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Shell32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.FileIO;
using System.Security.Permissions;

namespace Lab3
{   
    public partial class Form1 : Form
    {
        InfoDisplay display;
        BytesUnitsConverter converter = new BytesUnitsConverter();
        Shell shell = new Shell();
        Clipboard clipboard;
        public Form1()
        {
            InitializeComponent();
            display = new InfoDisplay(this);
            clipboard.pathCopy = "";
            clipboard.type = ObjectType.None;
            LoadDrives();
            LoadRecycleBin();
        }

        private void LoadDrives()
        {
            treeViewFIles.Nodes.Clear();
            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode(drive.Name) { Tag = drive.Name };
                node.Nodes.Add("///");
                treeViewFIles.Nodes.Add(node);
            }
        }

        private void LoadDirectories(TreeNode parentNode)
        {
            try
            {
                string path = parentNode.Tag.ToString();
                foreach (var dir in Directory.EnumerateDirectories(path))
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(dir);

                    if ((dirInfo.Attributes & FileAttributes.Hidden) == 0 &&
                        (dirInfo.Attributes & FileAttributes.System) == 0)
                    {
                        TreeNode node = new TreeNode(Path.GetFileName(dir)) { Tag = dir };
                        node.Nodes.Add("///");
                        parentNode.Nodes.Add(node);
                    }
                }
                foreach (var file in Directory.EnumerateFiles(path))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    if ((fileInfo.Attributes & FileAttributes.Hidden) == 0)
                    {
                        TreeNode node = new TreeNode(fileInfo.Name) { Tag = file };
                        parentNode.Nodes.Add(node);
                    }
                }
            }
            catch (Exception) { }
        }

        private void treeViewFIles_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Nodes.Count == 1 && (node.Nodes[0].Text == "///"))
            {
                node.Nodes.Clear();
                LoadDirectories(node);
            }

        }
        private void treeViewFIles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            string path = node.FullPath;
            display.Info(path);

        }

        private void treeViewFIles_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selected = treeViewFIles.SelectedNode;

            if (e.Button == MouseButtons.Right)
            {
                TreeNode node = treeViewFIles.GetNodeAt(e.X, e.Y);
                if (node != null)
                {
                    string path = node.FullPath;
                    ObjectType type = display.GetObjectType(path);
                    switch (type)
                    {
                        case ObjectType.File:
                            selected = node;
                            contextMenuStripSelectedFile.Show(treeViewFIles, e.Location); 
                            break;
                        case ObjectType.Dir:
                            selected = node;
                            toolStripMenuPasteToDir.Enabled = clipboard.pathCopy != "";
                            contextMenuStripSelectedDir.Show(treeViewFIles, e.Location);
                            break;
                        case ObjectType.Drive:
                            selected = node;
                            toolStripMenuItemPasteToRoot.Enabled = clipboard.pathCopy != "";
                            contextMenuStripRoot.Show(treeViewFIles, e.Location);
                            break;
                    }

                }
            }
        }
        private void labelSize_MouseClick(object sender, MouseEventArgs e)
        {   
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripSizeFormat.Show(Cursor.Position);
            }
            
        }
        // СМЕНА ЕДИНИЦ ИЗМЕРЕНМЯ
        private void toolStripMenuItemB_Click(object sender, EventArgs e)
        {
            converter.defaultUnit = BytesUnit.B;
            display.Update();
        }

        private void toolStripMenuItemKB_Click(object sender, EventArgs e)
        {
            converter.defaultUnit = BytesUnit.KB;
            display.Update();
        }

        private void toolStripMenuMB_Click(object sender, EventArgs e)
        {
            converter.defaultUnit = BytesUnit.MB;
            display.Update();
        }

        private void toolStripMenuGB_Click(object sender, EventArgs e)
        {
            converter.defaultUnit = BytesUnit.GB;
            display.Update();
        }

        // ОБРАБОТКА СОБЫТИЙ КОНТЕКСТНОГО МЕНЮ

        // ТИП: ФАЙЛ
        private void toolStripMenuCreateFile_Click(object sender, EventArgs e)
        {
            TreeNode selected = treeViewFIles.SelectedNode;

            if (selected != null)
            {
                TreeNode newNode = new TreeNode("") { Tag = ObjectType.CreatingFile };
                if (selected.Nodes.Count == 1 && selected.Nodes[0].Text == "///")
                {
                    selected.Nodes.Clear();
                    selected.Nodes.Insert(0, newNode);
                    LoadDirectories(selected);
                } else
                {
                    selected.Nodes.Insert(0, newNode);
                }
                treeViewFIles.SelectedNode.Expand();
                treeViewFIles.LabelEdit = true;
                newNode.BeginEdit();
            }
        }
        private void toolStripMenuItemDeleteFile_Click(object sender, EventArgs e)
        {
            TreeNode selected = treeViewFIles.SelectedNode;

            if (selected != null)
            {
                string filePath = selected.FullPath;
                if (File.Exists(filePath))
                {
                    FileSystem.DeleteFile(filePath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                }
                selected.Remove();
                LoadRecycleBin();
            }
        }

        private void toolStripMenuRenameFile_Click(object sender, EventArgs e)
        {
            TreeNode selected = treeViewFIles.SelectedNode;

            if (selected != null)
            {
                selected.Tag = ObjectType.EditingFile;
                treeViewFIles.LabelEdit = true;
                selected.BeginEdit();
            }
        }

        private void toolStripMenuItemСopyFile_Click(object sender, EventArgs e)
        {
            clipboard.pathCopy = treeViewFIles.SelectedNode.FullPath;
            clipboard.type = ObjectType.File;
        }

        private void toolStripMenuItemCutFile_Click(object sender, EventArgs e)
        {
            
            clipboard.pathCopy = treeViewFIles.SelectedNode.FullPath;
            treeViewFIles.SelectedNode.Remove();
            clipboard.type = ObjectType.MovingFile;
        }

        // ТИП: ДИРЕКТОРИЯ

        private void toolStripMenuCreateDir_Click(object sender, EventArgs e)
        {
            TreeNode selected = treeViewFIles.SelectedNode;

            if (selected != null)
            {
                TreeNode newNode = new TreeNode("") { Tag = ObjectType.CreatingDir };
                if (selected.Nodes.Count == 1 && selected.Nodes[0].Text == "///")
                {
                    selected.Nodes.Clear();
                    selected.Nodes.Insert(0, newNode);
                    LoadDirectories(selected);
                } else
                {
                    selected.Nodes.Insert(0, newNode);
                }
                selected.Expand();
                treeViewFIles.LabelEdit = true;
                newNode.BeginEdit();
            }
            
        }

        private void toolStripMenuDeleteDir_Click(object sender, EventArgs e)
        {
            TreeNode selected = treeViewFIles.SelectedNode;

            if (selected != null)
            {
                string dirPath = selected.FullPath;
                if (Directory.Exists(dirPath))
                {
                    FileSystem.DeleteDirectory(dirPath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                }
                selected.Remove();
                LoadRecycleBin();
            }
        }

        private void toolStripMenuRenameDir_Click(object sender, EventArgs e)
        {
            TreeNode selected = treeViewFIles.SelectedNode;

            if (selected != null)
            {
                selected.Tag = ObjectType.EditingDir;
                treeViewFIles.LabelEdit = true;
                selected.BeginEdit();
            }
        }

        private void toolStripMenuCopyDir_Click(object sender, EventArgs e)
        {
            clipboard.pathCopy = treeViewFIles.SelectedNode.FullPath;
            clipboard.type = ObjectType.Dir;
        }

        private void toolStripMenuPaste_Click(object sender, EventArgs e)
        {
            TreeNode selected = treeViewFIles.SelectedNode;

            if (selected != null)
            {
                string oldPath = clipboard.pathCopy;
                string fileName;
                string newFilePath;
                string dirName;
                string newDirPath;

                switch (clipboard.type)
                {
                    // ВСТАВКА ФАЙЛА
                    case ObjectType.File:

                        fileName = Path.GetFileName(clipboard.pathCopy);
                        newFilePath = Path.Combine(selected.FullPath, fileName);
                        if (!File.Exists(newFilePath))
                        {
                            TreeNode newNode = new TreeNode(Path.GetFileName(newFilePath)) { Tag = newFilePath };
                            if (selected.Nodes.Count == 1 && selected.Nodes[0].Text == "///")
                            {
                                selected.Nodes.Clear();
                                selected.Nodes.Insert(0, newNode);
                                LoadDirectories(selected);
                            }
                            else
                            {
                                selected.Nodes.Insert(0, newNode);
                            }
                            File.Copy(oldPath, newFilePath);

                        }
                        else
                        {
                            MessageBox.Show($"Файл с именем {fileName} уже есть в папке {selected.FullPath}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;

                    // ВСТАВКА ВЫРЕЗАННОГО ФАЙЛА
                    case ObjectType.MovingFile:
                        fileName = Path.GetFileName(clipboard.pathCopy);
                        newFilePath = Path.Combine(selected.FullPath, fileName);
                        if (!File.Exists(newFilePath))
                        {
                            TreeNode newNode = new TreeNode(Path.GetFileName(newFilePath)) { Tag = newFilePath };
                            if (selected.Nodes.Count == 1 && selected.Nodes[0].Text == "///")
                            {
                                selected.Nodes.Clear();
                                selected.Nodes.Insert(0, newNode);
                                LoadDirectories(selected);
                            }
                            else
                            {
                                selected.Nodes.Insert(0, newNode);
                            }
                            File.Move(oldPath, newFilePath);

                        }
                        else
                        {   
                            MessageBox.Show($"Файл с именем {fileName} уже есть в папке {selected.FullPath}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;

                    case ObjectType.Dir:
                        dirName = Path.GetFileName(clipboard.pathCopy);
                        newDirPath = Path.Combine(selected.FullPath, dirName);
                        if (!Directory.Exists(newDirPath))
                        {
                            TreeNode newNode = new TreeNode(Path.GetFileName(newDirPath)) { Tag = newDirPath };
                            newNode.Nodes.Add("///");
                            if (selected.Nodes.Count == 1 && selected.Nodes[0].Text == "///")
                            {
                                selected.Nodes.Clear();
                                selected.Nodes.Insert(0, newNode);
                                LoadDirectories(selected);
                            }
                            else
                            {
                                selected.Nodes.Insert(0, newNode);
                            }
                            DirectoryCopy(oldPath, newDirPath, true);
                        }
                        else
                        {
                            MessageBox.Show($"Папка с именем {dirName} уже есть в папке {selected.FullPath}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;

                    case ObjectType.MovingDir:
                        dirName = Path.GetFileName(clipboard.pathCopy);
                        newDirPath = Path.Combine(selected.FullPath, dirName);
                        if (!Directory.Exists(newDirPath))
                        {
                            TreeNode newNode = new TreeNode(Path.GetFileName(newDirPath)) { Tag = newDirPath };
                            newNode.Nodes.Add("///");
                            if (selected.Nodes.Count == 1 && selected.Nodes[0].Text == "///")
                            {
                                selected.Nodes.Clear();
                                selected.Nodes.Insert(0, newNode);
                                LoadDirectories(selected);
                            }
                            else
                            {
                                selected.Nodes.Insert(0, newNode);
                            }
                            Directory.Move(oldPath, newDirPath);
                        }
                        else
                        {
                            MessageBox.Show($"Папка с именем {dirName} уже есть в папке {selected.FullPath}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                }
            }
        }

        private void DirectoryCopy(string sourceDir, string destDir, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDir);
            DirectoryInfo[] dirs = dir.GetDirectories();

            Directory.CreateDirectory(destDir);

            foreach (FileInfo file in dir.GetFiles())
            {
                string tempPath = Path.Combine(destDir, file.Name);
                file.CopyTo(tempPath, false);
            }

            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDir, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }

        // ПОВЕДЕНИЕ ПОСЛЕ РЕДАКТИРОВАНИЯ

        private void treeViewFIles_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {

            ObjectType type = (ObjectType)e.Node.Tag;

            if (e.Label == null) 
            {
                if (type == ObjectType.CreatingDir || type == ObjectType.CreatingFile)
                {
                    e.Node.Remove();
                }
                return;
            }

            string oldPath = e.Node.FullPath;
            string selectedPath = e.Node.Parent.FullPath;
            string newPath = Path.Combine(selectedPath, e.Label);
            

            if (string.IsNullOrWhiteSpace(e.Label) || e.Label.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show(type == ObjectType.File ? "Некорректное имя файла." : "Некорректное имя папки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.CancelEdit = true;
                if (type == ObjectType.CreatingDir || type == ObjectType.CreatingFile)
                {
                    e.Node.Remove();
                }
                return;
            }

            if (File.Exists(newPath) || Directory.Exists(newPath))
            {
                MessageBox.Show(type == ObjectType.File ? "Файл уже существует" : "Папка уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.CancelEdit = true;
                e.Node.Remove();
                return;
            }

            try
            {
                switch (type)
                {
                    case ObjectType.CreatingFile:
                        File.Create(newPath).Close();
                        e.Node.Tag = newPath;
                        break;

                    case ObjectType.EditingFile:
                        File.Move(oldPath, newPath);
                        e.Node.Tag = newPath;
                        break;

                    case ObjectType.CreatingDir:
                        Directory.CreateDirectory(newPath);
                        e.Node.Tag = newPath;
                        break;

                    case ObjectType.EditingDir:
                        Directory.Move(oldPath, newPath);
                        e.Node.Tag = newPath;
                        break;
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (type == ObjectType.CreatingDir || type == ObjectType.CreatingFile)
                {
                    e.CancelEdit = true;
                    e.Node.Remove();
                }
            }

            treeViewFIles.LabelEdit = false;
        }

        public partial class InfoDisplay
        {
            public Form1 form;
            public BytesUnitsConverter converter;
            public string currentPath;
            public InfoDisplay(Form1 onForm)
            {
                form = onForm;
                converter = onForm.converter;
            }

            public ObjectType GetObjectType(string path)
            {
                if (File.Exists(path))
                {
                    return ObjectType.File;
                }
                else
                {
                    if (Path.GetPathRoot(path) != path)
                    {
                        return ObjectType.Dir;
                    }
                    else
                    {
                        return ObjectType.Drive;
                    }
                }
            }
            public void Info(string path)
            {
                ObjectType type = GetObjectType(path);
                currentPath = path;
                switch (type)
                {
                    case ObjectType.File:
                        FileInfo fileInfo = new FileInfo(path);
                        DisplayFor(type);
                        form.labelName.Text = $"Название: {fileInfo.Name}";
                        form.labelPath.Text = $"Путь: {fileInfo.FullName}";
                        form.labelDateCreation.Text = $"Дата создания: {fileInfo.CreationTime}";
                        form.labelDateUpdate.Text = $"Дата изменения: {fileInfo.LastWriteTime}";
                        form.labelSize.Text = $"Размер: {converter.FormatSize(fileInfo.Length)}";
                        break;

                    case ObjectType.Dir:
                        DirectoryInfo dirInfo = new DirectoryInfo(path);
                        DisplayFor(type);
                        form.labelName.Text = $"Название: {dirInfo.Name}";
                        form.labelPath.Text = $"Путь: {dirInfo.FullName}";
                        form.labelDateCreation.Text = $"Дата создания: {dirInfo.CreationTime}";
                        form.labelDateUpdate.Text = $"Дата изменения: {dirInfo.LastWriteTime}";
                        break;

                    case ObjectType.Drive:
                        DriveInfo drive = new DriveInfo(path);
                        DisplayFor(type);
                        form.labelName.Text = $"Название: {drive.Name}";
                        form.labelDriveType.Text = $"Тип диска: {drive.DriveType}";
                        form.labelDriveFreeSpace.Text = $"Свободно: {converter.FormatSize(drive.AvailableFreeSpace)}";
                        form.labelDriveBusySpace.Text = $"Занято: {converter.FormatSize(drive.TotalSize - drive.AvailableFreeSpace)}";
                        form.labelSize.Text = $"Всего: {converter.FormatSize(drive.TotalSize)}";
                        break;
                }
            }

            public void Update()
            {
                Info(currentPath);
            }
            public void ShowLabel(System.Windows.Forms.Label label)
            {
                label.Enabled = true;
                label.Visible = true;
            }

            public void HideLabel(System.Windows.Forms.Label label)
            {
                label.Enabled = false;
                label.Visible = false;
            }
            public void DisplayFor(ObjectType type)
            {
                switch (type)
                {
                    case ObjectType.File:
                        form.groupBoxInfo.Text = "Информация о файле";
                        ShowLabel(form.labelName);
                        ShowLabel(form.labelPath);
                        ShowLabel(form.labelDateCreation);
                        ShowLabel(form.labelDateUpdate);
                        ShowLabel(form.labelSize);
                        HideLabel(form.labelDriveType);
                        HideLabel(form.labelDriveFreeSpace);
                        HideLabel(form.labelDriveBusySpace); break;

                    case ObjectType.Dir:
                        form.groupBoxInfo.Text = "Информация о папке";
                        ShowLabel(form.labelName);
                        ShowLabel(form.labelPath);
                        ShowLabel(form.labelDateCreation);
                        ShowLabel(form.labelDateUpdate);
                        HideLabel(form.labelSize);
                        HideLabel(form.labelDriveType);
                        HideLabel(form.labelDriveFreeSpace);
                        HideLabel(form.labelDriveBusySpace); break;

                    case ObjectType.Drive:
                        form.groupBoxInfo.Text = "Информация о диске";
                        ShowLabel(form.labelName);
                        HideLabel(form.labelPath);
                        HideLabel(form.labelDateCreation);
                        HideLabel(form.labelDateUpdate);
                        ShowLabel(form.labelSize);
                        ShowLabel(form.labelDriveType);
                        ShowLabel(form.labelDriveFreeSpace);
                        ShowLabel(form.labelDriveBusySpace); break;
                }
            }
        }


        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            treeViewFIles.Nodes.Clear();
            LoadDrives();
        }

        private void listViewRBin_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ListViewItem clickedItem = listViewRBin.GetItemAt(e.X, e.Y);

                if (clickedItem != null)
                {
                    listViewRBin.SelectedItems.Clear();
                    clickedItem.Selected = true;

                    contextMenuStripRBin.Show(listViewRBin, e.Location);
                }
            }
        }

        private void toolStripMenuItemRBinDelete_Click(object sender, EventArgs e)
        {
            if (listViewRBin.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewRBin.SelectedItems[0];
                string itemName = selectedItem.Text;
                Folder recycleBin = shell.NameSpace(10);
                foreach (FolderItem2 item in recycleBin.Items())
                {
                    if (item.Name == itemName)
                    {
                        item.InvokeVerb("Delete");
                        LoadRecycleBin();

                        MessageBox.Show($"Элемент \"{itemName}\" был удален из корзины", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }


        }

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        public static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, uint dwFlags);


        private void buttonClearBin_Click(object sender, EventArgs e)
        {
            int result = SHEmptyRecycleBin(IntPtr.Zero, null, 0);
            LoadRecycleBin();
        }


        private void toolStripMenuItemRBinRestore_Click(object sender, EventArgs e)
        {
            if (listViewRBin.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewRBin.SelectedItems[0];
                string itemName = selectedItem.Text;
                Folder recycleBin = shell.NameSpace(10);
                foreach (FolderItem2 item in recycleBin.Items())
                {
                    if (item.Name == itemName)
                    {
                        item.InvokeVerbEx();
                        LoadRecycleBin();

                        MessageBox.Show($"Элемент \"{itemName}\" был восстановлен.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
        }

        public void LoadRecycleBin() { 
            listViewRBin.Items.Clear();
            Shell shell = new Shell();
            Folder recycleBin = shell.NameSpace(10);

            foreach (FolderItem2 item in recycleBin.Items())
            {
                ListViewItem listItem = new ListViewItem(item.Name);
                listItem.SubItems.Add(recycleBin.GetDetailsOf(item, 1));
                listItem.SubItems.Add(recycleBin.GetDetailsOf(item, 3));
                listItem.SubItems.Add(recycleBin.GetDetailsOf(item, 2)); 
                listViewRBin.Items.Add(listItem);
            }
        }




        // ОБРАБОТКА СОБЫТИЙ НАЖАТИЯ СПЕЦИАЛЬНЫХ КЛАВИШ
        private void treeViewFIles_KeyDown(object sender, KeyEventArgs e)
        {
            TreeNode selected = treeViewFIles.SelectedNode;
            if (selected != null)
            {
                ObjectType type = display.GetObjectType(selected.FullPath);
                if (e.KeyCode == Keys.Delete)
                {   
                    switch (type)
                    {
                        case ObjectType.File: toolStripMenuItemDeleteFile_Click(selected, e); break;
                        case ObjectType.Dir: toolStripMenuDeleteDir_Click(selected, e); break;
                    }
                    

                    e.SuppressKeyPress = true;
                }
            }
        }

        private void toolStripMenuCutDir_Click(object sender, EventArgs e)
        {
            clipboard.pathCopy = treeViewFIles.SelectedNode.FullPath;
            treeViewFIles.SelectedNode.Remove();
            clipboard.type = ObjectType.MovingDir;
        }
    }
}
    
public struct Clipboard
{
    public string pathCopy;
    public ObjectType type;
}
    
public enum BytesUnit
{
    None = 0,
    B = 1,
    KB = 1024,
    MB = 1048576,
    GB = 1073741824

}
public class BytesUnitsConverter
{

    public BytesUnit defaultUnit = BytesUnit.GB;
    public string FormatSize(long bytes, BytesUnit unit)
    {
        return (bytes / ((long)unit)).ToString() + " " + unit.ToString();
    }

    public string FormatSize(long bytes)
    {
        return (bytes / ((long)defaultUnit)).ToString() + " " + defaultUnit.ToString();
    }
};

public enum ObjectType
{
    None = 0,
    File = 1,
    CreatingFile = 2,
    EditingFile = 3,
    MovingFile = 4,
    Dir = 5,
    CreatingDir = 6,
    EditingDir = 7,
    MovingDir = 8,
    Drive = 9

}