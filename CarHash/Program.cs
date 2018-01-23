using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHash
{
    class Program
    {
        static void Main(string[] args)
        {
            var showroom = new HashSet<string>();
            var usedLot = new HashSet<string>();

            showroom.Add("Maserati");
            showroom.Add("Bentley");
            showroom.Add("Aston Martin");
            showroom.Add("Rolls Royce");

            Console.WriteLine($"There are {showroom.Count()} cars in the showroom.");

            showroom.Add("Bentley");

            usedLot.Add("PT Cruiser");
            usedLot.Add("Astro Van");

            showroom.UnionWith(usedLot);
            showroom.Remove("PT Cruiser");

            foreach (var car in showroom)
            {
                Console.WriteLine("The showroom includes:");
                Console.WriteLine(car);
            }

            

            Console.ReadLine();
        }
    }
}
