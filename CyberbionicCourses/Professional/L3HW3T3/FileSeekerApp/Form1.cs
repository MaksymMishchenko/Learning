using System;
using System.IO;
using System.IO.Compression;
using System.Text;
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
            catch (Exception)
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
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(_file, Encoding.UTF8))
            {
                textBox1.Text = reader.ReadToEnd();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream source = File.OpenRead(_file);
                FileStream destination = File.Create(saveFileDialog1.FileName);

                GZipStream compressor = new GZipStream(destination, CompressionMode.Compress);

                int theByte = source.ReadByte();
                while (theByte != -1)
                {
                    compressor.WriteByte((byte)theByte);
                    theByte = source.ReadByte();
                }

                compressor.Close();
            }
        }
    }
}
