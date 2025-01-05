using System;

namespace FactoryMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = MyClass<Animal>.FactoryMethod();
            Console.WriteLine(animal.GetType().Name);

            Program p = MyClass<Program>.FactoryMethod();
            Console.WriteLine(p.GetType().Name);
        }
    }
}
