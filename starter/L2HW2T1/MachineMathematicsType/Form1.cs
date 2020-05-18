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
            MessageBox.Show("0...255", "Тип: целое без знака");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-128…+127", "Тип: целое со знаком");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0...65535", "Тип: целое без знака");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-32768…+32767", "Тип: целое со знаком");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0u...4294967295U", "Тип: целое без знака");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-2147483648...+2147483647", "Тип: целое со знаком");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0ul...18446744073709551615UL","Тип: целое без знака");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-9223372036854775808l...+9223372036854775807l", "Тип: целое со знаком");
        }
    }
}
