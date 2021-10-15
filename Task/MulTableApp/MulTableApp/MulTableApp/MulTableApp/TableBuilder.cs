using System;
using MulTableApp.Model;

namespace MulTableApp
{
    internal class TableBuilder
    {
        private readonly TableParams _tabParams;
        private readonly string[][] _content;

        public TableBuilder(TableParams tabParams, string[][] content)
        {
            _tabParams = tabParams;
            _content = content;
        }
        public void Build(TableParams param, string[][] content)
        {
            // ╔
            Console.Write($"{(char)9556}");

            for (int i = 0; i < param.Width; i++)
            {
                // ═
                Console.Write($"{(char)9552}");
            }
            // ╗
            Console.WriteLine($"{(char)9559}");

            // content
            for (int i = 0; i < param.High; i++)
            {
                // ║
                Console.Write($"{(char)9553}");
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 1; k++)
                    {
                        Console.Write($"{content[j][k]}  ");
                    }

                }
                // ║
                Console.WriteLine($"{(char)9553}");

            }

            // ╚
            Console.Write($"{(char)9562}");

            for (int i = 0; i < param.Width; i++)
            {
                // ═
                Console.Write($"{(char)9552}");
            }

            // ╝
            Console.Write($"{(char)9565}");
            Console.WriteLine();
        }
    }
}