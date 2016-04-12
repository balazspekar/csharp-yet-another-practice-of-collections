using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueFun
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue myQueue = new Queue();
            myQueue.Enqueue("Hello");
            myQueue.Enqueue("World");
            myQueue.Enqueue("!");

            Console.WriteLine(myQueue.Count);
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Count);
        }
    }
}
