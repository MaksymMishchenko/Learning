using System;

namespace ArrayDelegatesApp
{
    public delegate int Delegate1(Delegate2[] arr);

    public delegate int Delegate2();
    class Program
    {
        private static Random rnd = new Random();
        public static int Method1()
        {
            return rnd.Next(1, 15);
        }

        public static int Method2()
        {
            return rnd.Next(5,30);
        }
        public static int Method3()
        {
            return rnd.Next(10, 20);
        }

        static void Main(string[] args)
        {
            Delegate2 method1 = Method1;
            Delegate2 method2 = Method2;
            Delegate2 method3 = Method3;

            int meth1 = method1.Invoke();
            int meth2 = method2.Invoke();
            int meth3 = method3.Invoke();

            var result = (meth1 + meth2 + meth3) / 3;
            Console.WriteLine(result);
        }
    }
}
