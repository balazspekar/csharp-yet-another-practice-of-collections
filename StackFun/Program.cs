using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackFun
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");

            Console.WriteLine("MyStack");
            Console.WriteLine("MyStack count: {0} ", myStack.Count);

            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Peek());
            Console.WriteLine("MyStack count: {0} ", myStack.Count);


        }
    }
}
