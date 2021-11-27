using System;

namespace ArrayApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            
            int arrayLenght = int.Parse(Console.ReadLine());

            IConsole cons = new ConsoleWrapper();
            MyArray myArray = new MyArray(cons);
            Console.Write(new string('-', 50));

            var arr = myArray.CreateUserArray(arrayLenght);

            myArray.FillsUserData(arr);
            myArray.Show(arr);
        }
    }
}
