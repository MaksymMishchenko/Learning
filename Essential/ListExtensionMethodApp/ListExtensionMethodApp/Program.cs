using System;

namespace ListExtensionMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList<string>();
            myList.Add("Veronika");
            myList.Add("Vadim");
            myList.Add("Petr");
            myList.Add("Maks");
            myList.Add("Artur");
            myList.Add("Mihail");
            myList.Add("Anton");

            myList.Show();
        }
    }
}
