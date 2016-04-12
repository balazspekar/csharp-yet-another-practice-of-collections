using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequentialCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var myQueue = new Queue<string>();
            myQueue.Enqueue("First");
            myQueue.Enqueue("Second");
            myQueue.Enqueue("Third");
            myQueue.Enqueue("Fourth");

            while (myQueue.Count > 0)
            {
                object obj = myQueue.Dequeue();
                Console.WriteLine("From Queue: {0}", obj);
            }

            var stack = new Stack();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");

            while (stack.Count > 0)
            {
                object obj = stack.Pop();
                Console.WriteLine("From Stack: {0}", obj);
            }
        }
    }
}
