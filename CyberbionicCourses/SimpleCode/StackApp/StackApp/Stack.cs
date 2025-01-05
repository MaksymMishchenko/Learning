using System;

namespace StackApp
{
    class Stack
    {
        private char[] _stack;
        private int _index;

        public Stack(int index)
        {
            _stack = new char[index];
        }

        public void Add(char value)
        {
            if (_stack[_index] == _index)
            {
                Console.WriteLine("The stack is full !");
            }

            _stack[_index] = value;
            _index++;
        }

        public char GetStack()
        {
            if (_index == 0)
            {
                Console.WriteLine("The stack is empty !");
                return (char)0;
            }
            _index--;
            return _stack[_index];
        }

        public bool IsFull()
        {
            return _index == _stack.Length;
        }

        public bool IsEmpty()
        {
            return _index == 0;
        }

        public int Capacity()
        {
            return _index;
        }

        public int StackSize()
        {
            return _stack.Length;
        }
    }
}
