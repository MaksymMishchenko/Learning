using System;

namespace ArrayApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int arrayLenght = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число начала заполнения массива: ");
            int current = int.Parse(Console.ReadLine());

            IConsole cons = new ConsoleWrapper();
            MyArray myArray = new MyArray(cons);

            var arr = myArray.CreateUserArray(arrayLenght);
            myArray.FillsUserData(arr, current);
            myArray.Show(arr);
        }
    }
}
