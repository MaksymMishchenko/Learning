using System;
using CalcFractionApp.Model;

namespace CalcFractionApp
{
    class Program
    {
        static void Main()

        {
            SplitStrings stroka = new SplitStrings();

            Fraction a = stroka.SplitToChar("1/2");
            Fraction b = stroka.SplitToChar("2/5");

            Calculator calc = new Calculator();
            var result = calc.Sum(a, b);

            Display show = new Display();
            show.Show(result);
            
            //Console.WriteLine(result.Numerator+"/"+result.Denominator);

            Console.ReadKey();
        }
    }
}