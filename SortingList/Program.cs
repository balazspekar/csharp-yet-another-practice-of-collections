using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingList
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                { new Car() { Name = "car1", Color = "blue", Speed = 20}},
                { new Car() { Name = "car2", Color = "red", Speed = 50}},
                { new Car() { Name = "car3", Color = "green", Speed = 10}},
                { new Car() { Name = "car4", Color = "blue", Speed = 50}},
                { new Car() { Name = "car5", Color = "blue", Speed = 30}},
                { new Car() { Name = "car6", Color = "red", Speed = 60}},
                { new Car() { Name = "car7", Color = "green", Speed = 50}}
            };

            cars.Sort();

            foreach (Car thisCar in cars)
            {
                Console.Write(thisCar.Color.PadRight(5) + " ");
                Console.Write(thisCar.Speed.ToString() + " ");
                Console.Write(thisCar.Name);
                Console.WriteLine();
            }

        }
    }
}
