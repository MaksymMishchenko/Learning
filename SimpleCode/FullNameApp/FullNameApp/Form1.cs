using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FullNameApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Person> GetPersons()
        {
            return new List<Person>()

            {
                new Person(){FirstName = "Максим", MiddleName = "Владимирович", SecondName = "Сергейчук"},
                new Person(){FirstName = "Steve", SecondName = "Martin"},
                new Person(){FirstName = "Jeffrey", SecondName = "Richter"},
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var persons = GetPersons();

            foreach (var person in persons)
            {
                listBox1.Items.Add(person.GetFulName());
            }
        }
    }
}
