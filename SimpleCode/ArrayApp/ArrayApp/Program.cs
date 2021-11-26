using System;

namespace ArrayApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int array_lenght = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число начала заполнения массива: ");
            int current = int.Parse(Console.ReadLine());

            MyArray myArray = new MyArray();

            var arr = myArray.CreateUserArray(array_lenght);
            myArray.FillsUserData(arr, current);
            myArray.Print(arr);
        }
    }
}
