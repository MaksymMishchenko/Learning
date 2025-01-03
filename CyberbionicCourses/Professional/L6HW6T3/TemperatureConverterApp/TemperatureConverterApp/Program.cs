using System;
using System.IO;
using System.Reflection;

namespace TemperatureConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("ConverterLibrary");
                Type type = assembly.GetType("ConverterLibrary.TemperatureConverter");

                dynamic instance = Activator.CreateInstance(type);
                Console.WriteLine($"From Celcium to Fahrenheit: {instance.ConvertToFahrenheit(10)}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message); 
            }

            Console.ReadKey();
        }
    }
}
