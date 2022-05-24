using System;
using System.IO;
using System.Windows.Forms;

namespace FileSeekerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetDrives();
        }

        void GetDrives()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (var drive in drives)
            {
                checkedListBox.Items.Add(string.Format(drive.Name));
            }
        }

        private string _file;

        bool SearchFile(string path, string fileName)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            if (!dir.Exists)
            {
                return false;
            }

            FileInfo[] files = null;
            try
            {
                files = dir.GetFiles(fileName);
            }
            catch (Exception e)
            {
                return false;
            }

            if (files.Length == 0)
            {
                DirectoryInfo[] directories = dir.GetDirectories();

                if (directories.Length == 0)
                {
                    return false;
                }

                foreach (var item in directories)
                {
                    if (item.Attributes.Equals(FileAttributes.System | FileAttributes.Hidden | FileAttributes.Directory))
                    {
                        continue;
                    }

                    if (SearchFile(item.FullName, fileName))
                    {
                        return true;
                    }
                }

                return false;
            }
            else
            {
                _file = files[0].FullName;
                return true;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    if (SearchFile(checkedListBox.Items[i].ToString(), textBox2.Text))
                    {
                        textBox1.Text = "File" + _file + " found"!;
                        textBox1.Text = Environment.NewLine;
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
