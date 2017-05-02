using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the type of vehicle: ");
            string answer = Console.ReadLine();

            Console.Write("\nVehicle's ID: ");
            string VID01 = Console.ReadLine();
            Console.Write("Miles since last maintenance: ");
            double LastMaint01 = double.Parse(Console.ReadLine());
            Console.Write("Maximun load capacity: ");
            double LoadCap01 = double.Parse(Console.ReadLine());

            if (answer == "Truck")
            {
                Truck truck01 = new Truck();
                truck01.VID = VID01;
                truck01.LastMaint = LastMaint01;
                truck01.LoadCap = LoadCap01;
                Console.Write("Insert number of axels: ");
                truck01.NumAxels = int.Parse(Console.ReadLine());
            }

            else if (answer == "Car")
            {
                Car car01 = new Car ();
                car01.VID = VID01;
                car01.LastMaint = LastMaint01;
                car01.LoadCap = LoadCap01;
                Console.Write("Insert number of passengers: ");
                car01.NumPass = int.Parse(Console.ReadLine());
            }

            else if (answer == "Bicycle")
            {
                Bicycle bike01 = new Bicycle();
                bike01.VID = VID01;
                bike01.LastMaint = LastMaint01;
                bike01.LoadCap = LoadCap01;
                Console.Write("Insert city name: ");
                bike01.Location = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
