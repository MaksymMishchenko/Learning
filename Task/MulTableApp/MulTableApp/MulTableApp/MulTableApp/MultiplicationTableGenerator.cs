using System;
using System.Runtime.InteropServices.ComTypes;

namespace MulTableApp
{
    internal class MultiplicationTableGenerator
    {
        public string[][] Create(int from, int till)
        {
            string[][] array = new string[8][];

            array[0] = new string[10];
            array[1] = new string[10];
            array[2] = new string[10];
            array[3] = new string[10];
            array[4] = new string[10];
            array[5] = new string[10];
            array[6] = new string[10];
            array[7] = new string[10];

            for (int i = 0, d = from ; i < till-1; i++, d++)
            {
                for (int j = 0, a=d, b=1, n=0; j < array[i].Length; j++, b++)
                {
                    var c = a * b;
                    array[i][j] = n.ToString($"{a}*{b}={c}");
                    
                }
            }
            return new string[8][];
        }
    }
}