using System;

using System.Windows.Forms;

namespace MachineMathematicsType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("сюда можна вписать текст", "Type: unsigned char");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("сюда можна вписать текст","Type: char");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("сюда можна вписать текст", "Type: unsigned short");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("сюда можна вписать текст", "Type: short");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("сюда можна вписать текст", "Type: unsigned int");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("сюда можна вписать текст", "Type: int");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("сюда можна вписать текст", "Type: unsigned long int");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("сюда можна вписать текст", "Type: long int");
        }
    }
}
