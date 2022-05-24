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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
