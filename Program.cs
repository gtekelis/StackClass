using System;
using System.Collections;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Stack");

            var stack = new Stack();

            var input = new object[] { 1, 2, null };

            foreach (var item in input)
            {
                if (item != null)
                {
                    stack.Push(item);
                    System.Console.WriteLine($"added {item.ToString()} to the stack");
                }

            }

            //stack.Clear();            

            System.Console.WriteLine(stack.Pop().ToString());
            System.Console.WriteLine(stack.Pop().ToString());
            System.Console.WriteLine(stack.Pop().ToString());
            System.Console.WriteLine(stack.Pop().ToString());
            System.Console.WriteLine(stack.Pop().ToString());            
        }
    }
}