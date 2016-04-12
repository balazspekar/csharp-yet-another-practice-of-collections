using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var animals = new List<string>();
            animals.Add("Giraffe");
            animals.Add("Dog");
            animals.Add("Cat");
            animals.Add("Tiger");

            foreach (string animal in animals)
            {
                Console.Write(animal + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Printing the TYPE");
            Console.WriteLine(animals.GetType());

            Console.WriteLine("Removing an element, for ex Dog");
            animals.Remove("Dog");


            Console.WriteLine("Iterating with FOR without Dog");

            for (int i = 0; i < animals.Count; i++)
                Console.WriteLine(animals[i]);



        }
    }
}
