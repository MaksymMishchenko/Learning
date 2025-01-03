using System;

namespace MyListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // int List
            var myList = new MyList<int>();
            myList.Add(1);
            myList.Add(3);
            myList.Add(4);

            //Inserts elements to List by index
            myList.Insert(1, 2);
            myList.Insert(4, 5);
            myList.Show();
            myList.Show();

            Console.WriteLine(new string('-', 20));

            // string list
            var myListStr = new MyList<string>();
            myListStr.Add("Hello");
            myListStr.Add("Amazing");
            myListStr.Add("World");
            myListStr.Show();

            Console.WriteLine(new string('-', 20));

            //get list lenght
            var listLenght = myListStr.NewList;
            Console.WriteLine($"List Lenght: {listLenght}");

            Console.WriteLine(new string('-', 20));

            // get the item by index 
            var ind = myListStr[1];
            Console.WriteLine($"Item by index: {ind}");
        }
    }
}
