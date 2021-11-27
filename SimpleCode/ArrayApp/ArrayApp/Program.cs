using System;

namespace ArrayApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            
            int arrayLenght = int.Parse(Console.ReadLine());
            
            MyArray myArray = new MyArray();
            Console.Write(new string('-', 50));
           
            var arr = myArray.CreateUserArray(arrayLenght);

            myArray.FillsUserData(arr);
            Console.WriteLine(new string ('-', 50));
            Console.WriteLine("Значения введенные пользователем: ");
            myArray.Show(arr);
        }
    }
}
