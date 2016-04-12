using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookupCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ListDictionary list = new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));

            list["Estados Unidos"] = "United States of America";
            list["Canadá"] = "Canada";
            list["España"] = "Spain";

            // Show the results 
            Console.WriteLine(list["españa"]);
            Console.WriteLine(list["CANADÁ"]);
            
        }
    }
}
