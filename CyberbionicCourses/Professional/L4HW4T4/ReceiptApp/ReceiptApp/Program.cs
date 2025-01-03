using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ReceiptApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var my = CultureInfo.CurrentCulture;
            var us = new CultureInfo("en-Us");

            var file = File.ReadAllText("product.txt", Encoding.UTF8);

            Console.WriteLine(file);
            Console.WriteLine(new string('-', 20));

            var pattern = @"[0-9]+[\.\,][0-9]+";

            var myCulture = Regex.Replace(file, pattern,
                (m) => double.Parse(m.Value.Replace(".", ",")).ToString("C", my));
            var usCulture = Regex.Replace(file, pattern,
                (m) => double.Parse(m.Value.Replace(".", ",")).ToString("C", us));
            Console.WriteLine(myCulture);
            Console.WriteLine(new string('-', 20));

            Console.WriteLine(usCulture);
        }
    }
}
