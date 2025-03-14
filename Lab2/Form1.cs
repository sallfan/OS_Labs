using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class Form1 : Form
    {
        Log log = new Log();
        BytesConverter bconverter = new BytesConverter();
        Dictionary<string, long> lastSpaceValueMB = new Dictionary<string, long>();

        public Form1()
        {
            InitializeComponent();
            listViewDrivers.Columns.Add("Название", 50);
            listViewDrivers.Columns.Add("Тип", 100);
            listViewDrivers.Columns.Add("Свободно", 150);
            listViewDrivers.Columns.Add("Занято", 150);
            listViewDrivers.Columns.Add("Всего", 150);

            contextMenuStrip1.Items.Add("Килобайты");
            contextMenuStrip1.Items.Add("Мегабайты");
            contextMenuStrip1.Items.Add("Гигабайты");

        }

        private void UpdateDriversInfo(object sender, EventArgs e)
        {

            var currentDrives = DriveInfo.GetDrives().ToDictionary(d => d.Name);

            ListViewItem driveInTable; 

            foreach (string checkedDrive in lastSpaceValueMB.Keys)
            {
                if (!currentDrives.ContainsKey(checkedDrive))
                {   
                    driveInTable = listViewDrivers.Items.Cast<ListViewItem>().FirstOrDefault(item => item.SubItems[0].Text == checkedDrive);
                    driveInTable.Remove();
                    lastSpaceValueMB.Remove(checkedDrive);
                    listBoxLog.Items.Add(log.MessageExctractDrive(checkedDrive));
                    break;
                }
            }

            foreach (var drive in currentDrives.Values)
            {
                driveInTable = listViewDrivers.Items.Cast<ListViewItem>().FirstOrDefault(item => item.SubItems[0].Text == drive.Name);

                if (driveInTable == null)
                {
                    string[] row = { drive.Name, drive.DriveType.ToString(), bconverter.FormatSize(drive.AvailableFreeSpace), bconverter.FormatSize(drive.TotalSize - drive.AvailableFreeSpace), bconverter.FormatSize(drive.TotalSize) };
                    listViewDrivers.Items.Add(new ListViewItem(row));
                    lastSpaceValueMB.Add(drive.Name, drive.AvailableFreeSpace / ((int)BytesUnit.MB));
                    listBoxLog.Items.Add(log.MessageInsertDrive(drive.Name));
                    listBoxLog.Items.Add(log.MessageDriveData(drive.Name, drive.DriveType, drive.AvailableFreeSpace, drive.TotalSize - drive.AvailableFreeSpace, drive.TotalSize));
                }
                else
                {

                    if (drive.AvailableFreeSpace / ((int)BytesUnit.MB) != lastSpaceValueMB[drive.Name])
                    {
                        driveInTable.SubItems[2].Text = bconverter.FormatSize(drive.AvailableFreeSpace);
                        driveInTable.SubItems[3].Text = bconverter.FormatSize(drive.TotalSize - drive.AvailableFreeSpace);
                        driveInTable.SubItems[4].Text = bconverter.FormatSize(drive.TotalSize);
                        lastSpaceValueMB[drive.Name] = drive.AvailableFreeSpace / ((int)BytesUnit.MB);
                        listBoxLog.Items.Add(log.MessageDriveData(drive.Name, drive.DriveType, drive.AvailableFreeSpace, drive.TotalSize - drive.AvailableFreeSpace, drive.TotalSize));

                    }

                }


            }
        }

        private void listViewDrivers_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 2 || e.Column == 3 || e.Column == 4)
            { 
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void buttonClearLog_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите очистить журнал без возможности восстановления?", "Лабораторная работа №2", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                listBoxLog.Items.Clear();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(folderBrowserDialog1.SelectedPath + String.Format("/log {0}.txt", DateTime.Now.Ticks));
                    foreach (var item in listBoxLog.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Ошибка: " + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateDriversInfo(object sender, ToolStripItemClickedEventArgs e)
        {

            switch (e.ClickedItem.Text)
            {
                case "Килобайты": bconverter.defaultUnit = BytesUnit.KB; break;
                case "Мегабайты": bconverter.defaultUnit = BytesUnit.MB; break;
                case "Гигабайты": bconverter.defaultUnit = BytesUnit.GB; break;
            }

            var currentDrives = DriveInfo.GetDrives().ToDictionary(d => d.Name);

            foreach (var drive in currentDrives.Values)
            {
                var existingItem = listViewDrivers.Items.Cast<ListViewItem>().FirstOrDefault(item => item.SubItems[0].Text == drive.Name);

                string freeSpace = bconverter.FormatSize(drive.AvailableFreeSpace);
                string busySpace = bconverter.FormatSize(drive.TotalSize - drive.AvailableFreeSpace);
                string totalSpace = bconverter.FormatSize(drive.TotalSize);

                if (existingItem != null)
                {
                    
                    existingItem.SubItems[2].Text = freeSpace;
                    existingItem.SubItems[3].Text = busySpace;
                    existingItem.SubItems[4].Text = totalSpace;
                }

            }


        }
    }

    public enum BytesUnit
    {
        None = 0,
        B = 1,
        KB = 1024,
        MB = 1048576,
        GB = 1073741824

    }
    public class BytesConverter
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
    public class Log : BytesConverter
    {
        public string MessageInsertDrive(string driveName)
        {
            return String.Format("{0} DETECTED {1}", DateTime.Now, driveName);
        }

        public string MessageExctractDrive(string driveName)
        {
            return String.Format("{0} REMOVED {1}", DateTime.Now, driveName);
        }

        public string MessageDriveData(string driveName, DriveType driveType, long freeSpace, long busySpace, long totalSpace)
        {
            return String.Format("{0} {1} {2} {3} {4} {5}", DateTime.Now, driveName, driveType.ToString().ToUpper(), FormatSize(freeSpace, BytesUnit.MB), FormatSize(busySpace, BytesUnit.MB), FormatSize(totalSpace, BytesUnit.MB));
        }

    };
    }
