namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeViewFIles = new System.Windows.Forms.TreeView();
            this.groupBoxTree = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDriveType = new System.Windows.Forms.Label();
            this.labelDriveBusySpace = new System.Windows.Forms.Label();
            this.labelDriveFreeSpace = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDateUpdate = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelDateCreation = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.contextMenuStripSelectedFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemRenameFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemСopyFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCutFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripSelectedDir = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuRenameDir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuCopyDir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuCutDir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDeleteDir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuPasteToDir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuCreateDir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuCreateFile = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripRoot = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemPasteToRoot = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuCreateDirInRoot = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuCreateFileInRoot = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripSizeFormat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemKB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuMB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuGB = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxRecycle = new System.Windows.Forms.GroupBox();
            this.buttonClearBin = new System.Windows.Forms.Button();
            this.listViewRBin = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateDelete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.contextMenuStripRBin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemRBinDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRBinRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxTree.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStripSelectedFile.SuspendLayout();
            this.contextMenuStripSelectedDir.SuspendLayout();
            this.contextMenuStripRoot.SuspendLayout();
            this.contextMenuStripSizeFormat.SuspendLayout();
            this.groupBoxRecycle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.contextMenuStripRBin.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewFIles
            // 
            this.treeViewFIles.Location = new System.Drawing.Point(6, 21);
            this.treeViewFIles.Name = "treeViewFIles";
            this.treeViewFIles.Size = new System.Drawing.Size(490, 542);
            this.treeViewFIles.TabIndex = 0;
            this.treeViewFIles.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeViewFIles_AfterLabelEdit);
            this.treeViewFIles.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewFIles_BeforeExpand);
            this.treeViewFIles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFIles_AfterSelect);
            this.treeViewFIles.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewFIles_NodeMouseClick);
            this.treeViewFIles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeViewFIles_KeyDown);
            // 
            // groupBoxTree
            // 
            this.groupBoxTree.Controls.Add(this.buttonRefresh);
            this.groupBoxTree.Controls.Add(this.treeViewFIles);
            this.groupBoxTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTree.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTree.Name = "groupBoxTree";
            this.groupBoxTree.Size = new System.Drawing.Size(502, 604);
            this.groupBoxTree.TabIndex = 1;
            this.groupBoxTree.TabStop = false;
            this.groupBoxTree.Text = "Файловая система";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(6, 567);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(118, 29);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.panel1);
            this.groupBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInfo.Location = new System.Drawing.Point(520, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(710, 214);
            this.groupBoxInfo.TabIndex = 3;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Информация о";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.labelDriveType);
            this.panel1.Controls.Add(this.labelDriveBusySpace);
            this.panel1.Controls.Add(this.labelDriveFreeSpace);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelDateUpdate);
            this.panel1.Controls.Add(this.labelPath);
            this.panel1.Controls.Add(this.labelDateCreation);
            this.panel1.Controls.Add(this.labelSize);
            this.panel1.Location = new System.Drawing.Point(9, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 187);
            this.panel1.TabIndex = 1;
            // 
            // labelDriveType
            // 
            this.labelDriveType.AutoSize = true;
            this.labelDriveType.Location = new System.Drawing.Point(4, 46);
            this.labelDriveType.Name = "labelDriveType";
            this.labelDriveType.Size = new System.Drawing.Size(37, 18);
            this.labelDriveType.TabIndex = 3;
            this.labelDriveType.Text = "Тип:";
            // 
            // labelDriveBusySpace
            // 
            this.labelDriveBusySpace.AutoSize = true;
            this.labelDriveBusySpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDriveBusySpace.Location = new System.Drawing.Point(4, 118);
            this.labelDriveBusySpace.Name = "labelDriveBusySpace";
            this.labelDriveBusySpace.Size = new System.Drawing.Size(62, 18);
            this.labelDriveBusySpace.TabIndex = 2;
            this.labelDriveBusySpace.Text = "Занято:";
            // 
            // labelDriveFreeSpace
            // 
            this.labelDriveFreeSpace.AutoSize = true;
            this.labelDriveFreeSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDriveFreeSpace.Location = new System.Drawing.Point(4, 82);
            this.labelDriveFreeSpace.Name = "labelDriveFreeSpace";
            this.labelDriveFreeSpace.Size = new System.Drawing.Size(84, 18);
            this.labelDriveFreeSpace.TabIndex = 1;
            this.labelDriveFreeSpace.Text = "Свободно:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(4, 10);
            this.labelName.Margin = new System.Windows.Forms.Padding(10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 18);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название: ";
            // 
            // labelDateUpdate
            // 
            this.labelDateUpdate.AutoSize = true;
            this.labelDateUpdate.Location = new System.Drawing.Point(4, 82);
            this.labelDateUpdate.Margin = new System.Windows.Forms.Padding(10);
            this.labelDateUpdate.Name = "labelDateUpdate";
            this.labelDateUpdate.Size = new System.Drawing.Size(126, 18);
            this.labelDateUpdate.TabIndex = 0;
            this.labelDateUpdate.Text = "Дата изменения:";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(4, 46);
            this.labelPath.Margin = new System.Windows.Forms.Padding(10);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(45, 18);
            this.labelPath.TabIndex = 0;
            this.labelPath.Text = "Путь:";
            // 
            // labelDateCreation
            // 
            this.labelDateCreation.AutoSize = true;
            this.labelDateCreation.Location = new System.Drawing.Point(4, 118);
            this.labelDateCreation.Margin = new System.Windows.Forms.Padding(10);
            this.labelDateCreation.Name = "labelDateCreation";
            this.labelDateCreation.Size = new System.Drawing.Size(117, 18);
            this.labelDateCreation.TabIndex = 0;
            this.labelDateCreation.Text = "Дата создания:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSize.Location = new System.Drawing.Point(4, 154);
            this.labelSize.Margin = new System.Windows.Forms.Padding(10);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(65, 18);
            this.labelSize.TabIndex = 0;
            this.labelSize.Text = "Размер:";
            this.labelSize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelSize_MouseClick);
            // 
            // contextMenuStripSelectedFile
            // 
            this.contextMenuStripSelectedFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripSelectedFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRenameFile,
            this.toolStripMenuItemСopyFile,
            this.toolStripMenuItemCutFile,
            this.toolStripMenuItemDeleteFile});
            this.contextMenuStripSelectedFile.Name = "contextMenuStripSelectedFile";
            this.contextMenuStripSelectedFile.Size = new System.Drawing.Size(191, 100);
            // 
            // toolStripMenuItemRenameFile
            // 
            this.toolStripMenuItemRenameFile.Name = "toolStripMenuItemRenameFile";
            this.toolStripMenuItemRenameFile.Size = new System.Drawing.Size(190, 24);
            this.toolStripMenuItemRenameFile.Text = "Переименовать";
            this.toolStripMenuItemRenameFile.Click += new System.EventHandler(this.toolStripMenuRenameFile_Click);
            // 
            // toolStripMenuItemСopyFile
            // 
            this.toolStripMenuItemСopyFile.Name = "toolStripMenuItemСopyFile";
            this.toolStripMenuItemСopyFile.Size = new System.Drawing.Size(190, 24);
            this.toolStripMenuItemСopyFile.Text = "Копировать";
            this.toolStripMenuItemСopyFile.Click += new System.EventHandler(this.toolStripMenuItemСopyFile_Click);
            // 
            // toolStripMenuItemCutFile
            // 
            this.toolStripMenuItemCutFile.Name = "toolStripMenuItemCutFile";
            this.toolStripMenuItemCutFile.Size = new System.Drawing.Size(190, 24);
            this.toolStripMenuItemCutFile.Text = "Вырезать";
            this.toolStripMenuItemCutFile.Click += new System.EventHandler(this.toolStripMenuItemCutFile_Click);
            // 
            // toolStripMenuItemDeleteFile
            // 
            this.toolStripMenuItemDeleteFile.Name = "toolStripMenuItemDeleteFile";
            this.toolStripMenuItemDeleteFile.Size = new System.Drawing.Size(190, 24);
            this.toolStripMenuItemDeleteFile.Text = "Удалить";
            this.toolStripMenuItemDeleteFile.Click += new System.EventHandler(this.toolStripMenuItemDeleteFile_Click);
            // 
            // contextMenuStripSelectedDir
            // 
            this.contextMenuStripSelectedDir.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripSelectedDir.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuRenameDir,
            this.toolStripMenuCopyDir,
            this.toolStripMenuCutDir,
            this.toolStripMenuDeleteDir,
            this.toolStripSeparator1,
            this.toolStripMenuPasteToDir,
            this.toolStripMenuCreateDir,
            this.toolStripMenuCreateFile});
            this.contextMenuStripSelectedDir.Name = "contextMenuStripSelectedDir";
            this.contextMenuStripSelectedDir.Size = new System.Drawing.Size(211, 206);
            // 
            // toolStripMenuRenameDir
            // 
            this.toolStripMenuRenameDir.Name = "toolStripMenuRenameDir";
            this.toolStripMenuRenameDir.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuRenameDir.Text = "Переименовать";
            this.toolStripMenuRenameDir.Click += new System.EventHandler(this.toolStripMenuRenameDir_Click);
            // 
            // toolStripMenuCopyDir
            // 
            this.toolStripMenuCopyDir.Name = "toolStripMenuCopyDir";
            this.toolStripMenuCopyDir.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuCopyDir.Text = "Копировать";
            this.toolStripMenuCopyDir.Click += new System.EventHandler(this.toolStripMenuCopyDir_Click);
            // 
            // toolStripMenuCutDir
            // 
            this.toolStripMenuCutDir.Name = "toolStripMenuCutDir";
            this.toolStripMenuCutDir.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuCutDir.Text = "Вырезать";
            this.toolStripMenuCutDir.Click += new System.EventHandler(this.toolStripMenuCutDir_Click);
            // 
            // toolStripMenuDeleteDir
            // 
            this.toolStripMenuDeleteDir.Name = "toolStripMenuDeleteDir";
            this.toolStripMenuDeleteDir.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuDeleteDir.Text = "Удалить";
            this.toolStripMenuDeleteDir.Click += new System.EventHandler(this.toolStripMenuDeleteDir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // toolStripMenuPasteToDir
            // 
            this.toolStripMenuPasteToDir.Name = "toolStripMenuPasteToDir";
            this.toolStripMenuPasteToDir.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuPasteToDir.Text = "Вставить";
            this.toolStripMenuPasteToDir.Click += new System.EventHandler(this.toolStripMenuPaste_Click);
            // 
            // toolStripMenuCreateDir
            // 
            this.toolStripMenuCreateDir.Name = "toolStripMenuCreateDir";
            this.toolStripMenuCreateDir.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuCreateDir.Text = "Создать папку";
            this.toolStripMenuCreateDir.Click += new System.EventHandler(this.toolStripMenuCreateDir_Click);
            // 
            // toolStripMenuCreateFile
            // 
            this.toolStripMenuCreateFile.Name = "toolStripMenuCreateFile";
            this.toolStripMenuCreateFile.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuCreateFile.Text = "Создать файл";
            this.toolStripMenuCreateFile.Click += new System.EventHandler(this.toolStripMenuCreateFile_Click);
            // 
            // contextMenuStripRoot
            // 
            this.contextMenuStripRoot.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripRoot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPasteToRoot,
            this.toolStripMenuCreateDirInRoot,
            this.toolStripMenuCreateFileInRoot});
            this.contextMenuStripRoot.Name = "contextMenuStripRoot";
            this.contextMenuStripRoot.Size = new System.Drawing.Size(178, 76);
            // 
            // toolStripMenuItemPasteToRoot
            // 
            this.toolStripMenuItemPasteToRoot.Name = "toolStripMenuItemPasteToRoot";
            this.toolStripMenuItemPasteToRoot.Size = new System.Drawing.Size(177, 24);
            this.toolStripMenuItemPasteToRoot.Text = "Вставить";
            this.toolStripMenuItemPasteToRoot.Click += new System.EventHandler(this.toolStripMenuPaste_Click);
            // 
            // toolStripMenuCreateDirInRoot
            // 
            this.toolStripMenuCreateDirInRoot.Name = "toolStripMenuCreateDirInRoot";
            this.toolStripMenuCreateDirInRoot.Size = new System.Drawing.Size(177, 24);
            this.toolStripMenuCreateDirInRoot.Text = "Создать папку";
            this.toolStripMenuCreateDirInRoot.Click += new System.EventHandler(this.toolStripMenuCreateDir_Click);
            // 
            // toolStripMenuCreateFileInRoot
            // 
            this.toolStripMenuCreateFileInRoot.Name = "toolStripMenuCreateFileInRoot";
            this.toolStripMenuCreateFileInRoot.Size = new System.Drawing.Size(177, 24);
            this.toolStripMenuCreateFileInRoot.Text = "Создать файл";
            this.toolStripMenuCreateFileInRoot.Click += new System.EventHandler(this.toolStripMenuCreateFile_Click);
            // 
            // contextMenuStripSizeFormat
            // 
            this.contextMenuStripSizeFormat.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripSizeFormat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemB,
            this.toolStripMenuItemKB,
            this.toolStripMenuMB,
            this.toolStripMenuGB});
            this.contextMenuStripSizeFormat.Name = "contextMenuStripSizeFormat";
            this.contextMenuStripSizeFormat.Size = new System.Drawing.Size(157, 100);
            // 
            // toolStripMenuItemB
            // 
            this.toolStripMenuItemB.Name = "toolStripMenuItemB";
            this.toolStripMenuItemB.Size = new System.Drawing.Size(156, 24);
            this.toolStripMenuItemB.Text = "Байты";
            this.toolStripMenuItemB.Click += new System.EventHandler(this.toolStripMenuItemB_Click);
            // 
            // toolStripMenuItemKB
            // 
            this.toolStripMenuItemKB.Name = "toolStripMenuItemKB";
            this.toolStripMenuItemKB.Size = new System.Drawing.Size(156, 24);
            this.toolStripMenuItemKB.Text = "Килобайты";
            this.toolStripMenuItemKB.Click += new System.EventHandler(this.toolStripMenuItemKB_Click);
            // 
            // toolStripMenuMB
            // 
            this.toolStripMenuMB.Name = "toolStripMenuMB";
            this.toolStripMenuMB.Size = new System.Drawing.Size(156, 24);
            this.toolStripMenuMB.Text = "Мегабайты";
            this.toolStripMenuMB.Click += new System.EventHandler(this.toolStripMenuMB_Click);
            // 
            // toolStripMenuGB
            // 
            this.toolStripMenuGB.Name = "toolStripMenuGB";
            this.toolStripMenuGB.Size = new System.Drawing.Size(156, 24);
            this.toolStripMenuGB.Text = "Гигабайты";
            this.toolStripMenuGB.Click += new System.EventHandler(this.toolStripMenuGB_Click);
            // 
            // groupBoxRecycle
            // 
            this.groupBoxRecycle.Controls.Add(this.buttonClearBin);
            this.groupBoxRecycle.Controls.Add(this.listViewRBin);
            this.groupBoxRecycle.Location = new System.Drawing.Point(520, 232);
            this.groupBoxRecycle.Name = "groupBoxRecycle";
            this.groupBoxRecycle.Size = new System.Drawing.Size(710, 384);
            this.groupBoxRecycle.TabIndex = 4;
            this.groupBoxRecycle.TabStop = false;
            this.groupBoxRecycle.Text = "Корзина";
            // 
            // buttonClearBin
            // 
            this.buttonClearBin.Location = new System.Drawing.Point(6, 348);
            this.buttonClearBin.Name = "buttonClearBin";
            this.buttonClearBin.Size = new System.Drawing.Size(118, 29);
            this.buttonClearBin.TabIndex = 2;
            this.buttonClearBin.Text = "Очистить";
            this.buttonClearBin.UseVisualStyleBackColor = true;
            this.buttonClearBin.Click += new System.EventHandler(this.buttonClearBin_Click);
            // 
            // listViewRBin
            // 
            this.listViewRBin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderPath,
            this.columnHeaderSize,
            this.columnHeaderDateDelete});
            this.listViewRBin.HideSelection = false;
            this.listViewRBin.Location = new System.Drawing.Point(6, 21);
            this.listViewRBin.Name = "listViewRBin";
            this.listViewRBin.Size = new System.Drawing.Size(698, 322);
            this.listViewRBin.TabIndex = 0;
            this.listViewRBin.UseCompatibleStateImageBehavior = false;
            this.listViewRBin.View = System.Windows.Forms.View.Details;
            this.listViewRBin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewRBin_MouseUp);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Название";
            this.columnHeaderName.Width = 122;
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "Исходное расположение";
            this.columnHeaderPath.Width = 285;
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Размер";
            this.columnHeaderSize.Width = 136;
            // 
            // columnHeaderDateDelete
            // 
            this.columnHeaderDateDelete.Text = "Дата удаления";
            this.columnHeaderDateDelete.Width = 221;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // contextMenuStripRBin
            // 
            this.contextMenuStripRBin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripRBin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRBinDelete,
            this.toolStripMenuItemRBinRestore});
            this.contextMenuStripRBin.Name = "contextMenuStripRBin";
            this.contextMenuStripRBin.Size = new System.Drawing.Size(174, 52);
            // 
            // toolStripMenuItemRBinDelete
            // 
            this.toolStripMenuItemRBinDelete.Name = "toolStripMenuItemRBinDelete";
            this.toolStripMenuItemRBinDelete.Size = new System.Drawing.Size(173, 24);
            this.toolStripMenuItemRBinDelete.Text = "Удалить";
            this.toolStripMenuItemRBinDelete.Click += new System.EventHandler(this.toolStripMenuItemRBinDelete_Click);
            // 
            // toolStripMenuItemRBinRestore
            // 
            this.toolStripMenuItemRBinRestore.Name = "toolStripMenuItemRBinRestore";
            this.toolStripMenuItemRBinRestore.Size = new System.Drawing.Size(173, 24);
            this.toolStripMenuItemRBinRestore.Text = "Восстановить";
            this.toolStripMenuItemRBinRestore.Click += new System.EventHandler(this.toolStripMenuItemRBinRestore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 620);
            this.Controls.Add(this.groupBoxRecycle);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxTree);
            this.Name = "Form1";
            this.Text = "Лаборатоная работа №3";
            this.groupBoxTree.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStripSelectedFile.ResumeLayout(false);
            this.contextMenuStripSelectedDir.ResumeLayout(false);
            this.contextMenuStripRoot.ResumeLayout(false);
            this.contextMenuStripSizeFormat.ResumeLayout(false);
            this.groupBoxRecycle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.contextMenuStripRBin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewFIles;
        private System.Windows.Forms.GroupBox groupBoxTree;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelDateCreation;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDateUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSelectedFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRenameFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemСopyFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCutFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteFile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSelectedDir;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRenameDir;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuCopyDir;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuPasteToDir;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuCutDir;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDeleteDir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRoot;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPasteToRoot;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuCreateDirInRoot;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuCreateFileInRoot;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuCreateDir;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuCreateFile;
        private System.Windows.Forms.Label labelDriveFreeSpace;
        private System.Windows.Forms.Label labelDriveBusySpace;
        private System.Windows.Forms.Label labelDriveType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSizeFormat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemB;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemKB;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuMB;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuGB;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.GroupBox groupBoxRecycle;
        private System.Windows.Forms.Button buttonClearBin;
        private System.Windows.Forms.ListView listViewRBin;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.ColumnHeader columnHeaderDateDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRBin;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRBinDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRBinRestore;
    }
}

