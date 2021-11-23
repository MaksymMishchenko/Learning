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

            // todo: replace constant to content.Length
            for (int i = 0; i < 47; i++)
            {

                // todo: replace constant to content.Length
                if (i == 11 || i == 23 || i == 35)
                {
                    // ╤
                    Console.Write($"{(char)9572}");
                }
                else
                {
                    // ═
                    Console.Write($"{(char)9552}");
                }
            }

            // ╗
            Console.Write($"{(char)9559}");
            Console.WriteLine();

            for (int n = 0, m = 8; n < content.Length + 1; n++, m--)
            {
                // ║
                Console.Write($"{(char)9553}");
                for (int i = 0; i < content.Length / 2; i++)
                {
                    for (int j = n; j < content[i].Length - m; j++)
                    {
                        Console.Write($"{content[i][j]}");

                        if (i == 3)
                        {
                            // ║
                            Console.Write($"{(char)9553}");
                        }
                        else
                        {
                            // │
                            Console.Write($"{(char)9474}");
                        }
                    }
                }
                Console.WriteLine();
            }

            // ╠
            Console.Write($"{(char)9568}");

            // todo: replace constant to content.Length
            for (int i = 0; i < 47; i++)
            {
                // todo: replace constants to content.Length
                if (i == 11 || i == 23 || i == 35)
                {
                    // ╡
                    Console.Write($"{(char)9578}");
                }
                else
                {
                    // ═
                    Console.Write($"{(char)9552}");
                }
            }

            // ╣
            Console.Write($"{(char)9571}");
            Console.WriteLine();

            // todo: delete the second loop for in class TableBuilder
            for (int n = 0, m = 8; n < content.Length + 1; n++, m--)
            {
                // ║
                Console.Write($"{(char)9553}");
                for (int i = 4; i < content.Length; i++)
                {
                    for (int j = n; j < content[i].Length - m; j++)
                    {
                        Console.Write($"{content[i][j]}");

                        if (i == 7)
                        {
                            // ║
                            Console.Write($"{(char)9553}");
                        }
                        else
                        {
                            // │
                            Console.Write($"{(char)9474}");
                        }
                    }
                }
                Console.WriteLine();
            }

            // ╚
            Console.Write($"{(char)9562}");

            // todo: replace constants to content.Length
            for (int i = 0; i < 47; i++)
            {
                // todo: replace constants to content.Length
                if (i == 11 || i == 23 || i == 35)
                {
                    // ╧
                    Console.Write($"{(char)9575}");
                }
                else
                {
                    // ═
                    Console.Write($"{(char)9552}");
                }
            }

            // ╝
            Console.Write($"{(char)9565}");
        }
    }
}