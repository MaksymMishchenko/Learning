using System;

namespace FactoryMethApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var rect = new Rectangle();

            for (int i = 0, j = 10; i < 10; i++, j--)
            {
                Rectangle nextRectangle = rect.Factory(i, j);
                nextRectangle.Show();
            }
        }
    }
}
