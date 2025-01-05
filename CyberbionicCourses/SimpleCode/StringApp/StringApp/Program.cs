using System;
using System.Threading.Channels;

namespace StringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, input integer number: ");
            try
            {
                int userNumber = int.Parse(Console.ReadLine());
                int index = 0;

                IData data = new Data();
                string[] strArr = data.GetStringArray();
                int[] numberArray = data.GetNumbersArray(userNumber, ref index);

                Console.WriteLine(new string ('-', 50));

                Console.Write($"You input: {userNumber} \t");

                Console.Write("Result: ");

                IPrintToConsole print = new PrintToConsole();
                print.Print(strArr, numberArray, index);
            }
            catch (Exception)
            {
                Console.WriteLine("This number isn't integer. Please, try again");
            }
        }
    }
}
