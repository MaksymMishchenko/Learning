using System;
using System.Threading.Tasks;

namespace SortArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int[]> task = Task.Run(() => SortArray(true, 9, 1, 8, 2, 7, 3, 6, 4, 5));

            task.ContinueWith((t) =>
            {
                Console.WriteLine("Sorted elements of array: ");
                foreach (var item in t.Result)
                {
                    Console.Write(item);
                }
            }, TaskContinuationOptions.LongRunning);

            task.Wait();

            Console.ReadKey();
        }
        /// <summary>
        /// SortArray
        /// </summary>
        /// <param name="isAscending"></param>
        /// <param name="array"></param>
        /// <returns>Returns sorted array by ascending/descending</returns>
        private static int[] SortArray(bool isAscending, params int[] array)
        {
            int temp = 0;

            switch (isAscending)
            {
                case true:
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            for (int j = i + 1; j < array.Length; j++)
                            {
                                if (array[i] > array[j])
                                {
                                    temp = array[i];
                                    array[i] = array[j];
                                    array[j] = temp;
                                }
                            }
                        }
                        break;
                    }

                case false:
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            for (int j = i + 1; j < array.Length; j++)
                            {
                                if (array[i] < array[j])
                                {
                                    temp = array[i];
                                    array[i] = array[j];
                                    array[j] = temp;
                                }
                            }
                        }
                        break;
                    }
            }

            return array;
        }
    }
}
