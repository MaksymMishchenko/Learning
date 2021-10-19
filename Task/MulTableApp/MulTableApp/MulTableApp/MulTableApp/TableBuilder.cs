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
            Console.Write($"{(char)9559}");
            Console.WriteLine();

            // content
            Show(content);

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

        public void Show(string[][] content)
        {
            for (int n = 0, m = 9; n < content.Length; n++, m--)
            {
                for (int i = 0; i < content.Length; i++)
                {
                    for (int j = n; j < content[i].Length - m; j++)
                    {
                        Console.Write($"{content[i][j]}  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}