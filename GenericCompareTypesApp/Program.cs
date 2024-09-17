namespace GenericCompareTypesApp
{
    internal class Program
    {
        public static bool IsIn<T>(T what, T[] obs) where T : IEquatable<T>
        {
            foreach (var item in obs)
            {
                if (obs.Equals(what))
                    return true;
            }
            return false;
        }

        public static bool InRange<T>(T what, T[] obs) where T : IComparable<T>
        {
            if (what.CompareTo(obs[0]) < 0 || what.CompareTo(obs[obs.Length - 1]) > 0) return false;
            return true;
        }

        public static void Main()
        {
            int[] nums = { 1, 2, 3, 4, 5 };

            if (IsIn(2, nums))
                Console.WriteLine("Value 2 was found");

            if (IsIn(99, nums))
                Console.WriteLine("No value found");

            MyClass[] mcs = { new MyClass(1), new MyClass(2), new MyClass(3), new MyClass(4) };

            if (IsIn(new MyClass(2), mcs))
                Console.WriteLine("MyClass(2) was found");

            if (IsIn(new MyClass(99), mcs))
                Console.WriteLine("MyClass(99) was not found");

            if (InRange(2, nums))
                Console.WriteLine("The value 2 is within the bounds of the array nums");

            if (InRange(1, nums))
                Console.WriteLine("The value 1 is within the bounds of the array nums");

            if (InRange(5, nums))
                Console.WriteLine("The value 5 is within the bounds of the array nums");

            if (InRange(0, nums))
                Console.WriteLine("The value 0 is not found within the boundaries of the array nums.");

            if (InRange(6, nums))
                Console.WriteLine("The value 6 is not found within the boundaries of the array nums.");

            if (InRange(new MyClass(2), mcs))
                Console.WriteLine("The value MyClass(5) is within the bounds of the array nums");

            if (InRange(new MyClass(1), mcs))
                Console.WriteLine("The value MyClass(1) is within the bounds of the array nums");

            if (!InRange(new MyClass(0), mcs))
                Console.WriteLine("The value 0 is not found within the boundaries of the array nums.");

            if (!InRange(new MyClass(5), mcs))
                Console.WriteLine("The value 5 is not found within the boundaries of the array nums.");
        }
    }
}