namespace GenericDelegateApp
{
    delegate T SomeOp<T>(T t);

    internal class GenDelegateDemo
    {
        static int Sum(int number)
        {
            int result = 0;
            for (int i = number; i > 0; i--)
            {
                result += i;
            }

            return result;
        }

        static string Reflection(string str)
        {
            string result = "";

            foreach (var ch in str)
            {
                result = ch + result;
            }

            return result;
        }

        static void Main()
        {
            SomeOp<int> delInt = Sum;
            Console.WriteLine(delInt(5));

            Console.WriteLine();

            SomeOp<string> delStr = Reflection;
            Console.WriteLine(delStr("Hello"));
        }
    }
}