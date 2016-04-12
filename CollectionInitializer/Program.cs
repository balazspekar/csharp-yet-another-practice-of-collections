using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInitializer
{
    class Program
    {
        static void Main(string[] args)
        {

            // adding stuff to the collection right away
            var salmons = new List<string> { "choohoo", "chineese", "csimpi", "csumpi" };

            foreach (var salmon in salmons)
            {
                Console.WriteLine(salmon);
            }

        }
    }
}
