using System;

namespace INHERITANCE_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
             var stack = new Stack();
             stack.Push(22.54);
             //stack.Push(null);
             stack.Push("Gabi");
             stack.Push(DateTime.Now);

             //stack.Clear();

             Console.WriteLine(stack.Pop());
             Console.WriteLine(stack.Pop());
             Console.WriteLine(stack.Pop());

        }
    }
}
