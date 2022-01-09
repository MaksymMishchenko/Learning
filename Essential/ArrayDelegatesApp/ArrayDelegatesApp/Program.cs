using System;

namespace ArrayDelegatesApp
{
    public delegate int Delegate1();

    public delegate double Delegate2(Delegate1[] arr);
    class Program
    {
        public static int GetRandom()
        {
            return new Random().Next(1, 125);
        }

        static void Main(string[] args)
        {
            var arr = new Delegate1[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = () => new Delegate1(GetRandom).Invoke();
            }

            Delegate2 del = delegate(Delegate1[] arr)
            {
                double result =0;
                for (int i = 0; i < arr.Length; i++)
                {
                    result += arr[i].Invoke();
                }

                return result / arr.Length;
            };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].Invoke() + " ");
            }
            Console.WriteLine("\nСреднее арифметическое элементов {0:##.###}", del(arr));
        }
    }
}
