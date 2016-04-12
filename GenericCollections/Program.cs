using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> countryLookup = new Dictionary<int, string>();

            countryLookup[44] = "United Kingdom";
            countryLookup[33] = "France";
            countryLookup[31] = "Netherlands";
            countryLookup[55] = "Brazil";

            Console.WriteLine("The 33 code is for {0}", countryLookup[33]);

            foreach (KeyValuePair<int, string> pair in countryLookup)
            {
                int code = pair.Key;
                string country = pair.Value;
                Console.WriteLine("Country is {0} and the code is {1}", country, code);
            }
        }
    }
}
