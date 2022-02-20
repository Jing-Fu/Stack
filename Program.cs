using System;

namespace DataStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(15);
            stack.Push(630);

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Capacity());
            Console.ReadLine();
        }
    }
}