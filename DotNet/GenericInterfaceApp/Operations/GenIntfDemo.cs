using GenericInterfaceApp.Entities;

namespace GenericInterfaceApp.Operations
{
    internal class GenIntfDemo
    {
        static int IntPlusTwo(int v) => v + 2;
        static double DoublePlusTwo(double v) => v + 2.0;

        static ThreeD ThreeD(ThreeD v)
        {
            if (v == null)
                return new ThreeD(0, 0, 0);
            else
                return new ThreeD(v.x + 2, v.y + 2, v.z + 2);
        }

        static void Main()
        {
            ByTwos<int> intBT = new ByTwos<int>(IntPlusTwo);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intBT.GetNext() + " ");
            }

            Console.WriteLine();

            ByTwos<double> doubleBT = new ByTwos<double>(DoublePlusTwo);

            doubleBT.SetStart(11.4);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(doubleBT.GetNext() + " ");
            }

            Console.WriteLine();

            ByTwos<ThreeD> threeD = new ByTwos<ThreeD>(ThreeD);

            ThreeD coord;

            for (int i = 0; i < 5; i++)
            {
                coord = threeD.GetNext();

                Console.Write(coord.x + " ");
                Console.Write(coord.y + " ");
                Console.Write(coord.z + " ");
            }

            Console.WriteLine();
        }
    }
}
