using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Chit(Create());
        }

        static int[] Create()
        {
            int[] a = new int[10];
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(-50, 50);
            }

            return a;
        }

        static int[] Chit(int[] a)
        {
            int index = 0;
            int k = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0 && a[i] != 0)
                {
                    k++;
                }
            }

            int[] b = new int[k];

            for (int i = 0; i < b.Length; i++)
            {
                if (a[i] % 2 == 0 && a[i] != 0)
                {
                    b[i] = a[i];
                }
            }

            Console.WriteLine("B");
            foreach (int i in b)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("A");
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }

            return b;
        }
    }
}
