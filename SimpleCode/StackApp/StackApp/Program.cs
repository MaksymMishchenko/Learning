using System;

namespace StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack1 = new Stack(10);
            Stack stack2 = new Stack(10);
            Stack stack3 = new Stack(10);

            char ch = '\0';
            int value = 5;

            Console.WriteLine("Add data to stack");
            //add characters to stack
            AddChar(stack1);

            Console.WriteLine("Print data from stack: ");
            //print characters from stack
            PrintChar(stack1);

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Add data to stack again");
            //add characters to stack again
            AddChar(stack1);

            Console.WriteLine("Add Data From Stack1 To Stack2: ");
            //Add Data From Stack1 To Stack2
            AddDataFromStack1ToStack2(stack1, stack2, ch);
            PrintChar(stack2);

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Add five elements to Stack3: ");
            //Add five elements to Stack3
            AddFiveElementsToStack(stack3, value);
            
            Console.Write("Stack size: ");
            int size = stack3.StackSize();
            Console.WriteLine(size);

            Console.Write("Stack capacity: ");
            int capacity = stack3.Capacity();
            Console.WriteLine(capacity);
        }

        public static void AddChar(Stack stack1)
        {
            for (int i = 0; !stack1.IsFull(); i++)
            {
                stack1.Add((char)('A' + i));
            }
        }

        public static void PrintChar(Stack stack1)
        {
            while (!stack1.IsEmpty())
            {
                Console.Write($"{stack1.GetStack()} ");
            }

            Console.WriteLine();
        }

        public static void AddDataFromStack1ToStack2(Stack stack1, Stack stack2, char ch)
        {
            while (!stack1.IsEmpty())
            {
                ch = stack1.GetStack();
                stack2.Add(ch);
            }
        }

        public static void AddFiveElementsToStack(Stack stack3, int value)
        {
            for (int i = 0; i < value; i++)
            {
                stack3.Add((char)('A' + i));
            }
        }
    }
}
