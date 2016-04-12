using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryFun
{
    class Program
    {
        static void Main(string[] args)
        {

            var nicknames = new Dictionary<string, string>();
            nicknames.Add("peba", "P. Balázs");
            nicknames.Add("subi", "S. Balázs");
            nicknames.Add("axel", "B. Alex");

            Console.WriteLine(nicknames.Count);

            foreach (var nickname in nicknames)
            {
                Console.WriteLine(nickname);
            }

            Console.WriteLine("ContainsKey:");
            if (nicknames.ContainsKey("peba"))
                Console.WriteLine("Contains the searched key");
            else
                Console.WriteLine("Does not contain that key");


        }
    }
}
