using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OwnTypesInCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var myGalaxyCollection = new List<Galaxy>
            {
            new Galaxy() { Name="Tadpole", LightYears=400},
            new Galaxy() { Name="Pinwheel", LightYears=25},
            new Galaxy() { Name="Milky Way", LightYears=0},
            new Galaxy() { Name="Andromeda", LightYears=3}
            };

            foreach (var galaxy in myGalaxyCollection)
            {
                Console.WriteLine("Name: " + galaxy.Name + ", Dist: " + galaxy.LightYears);
            }
        }
    }
}
