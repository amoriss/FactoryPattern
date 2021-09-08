using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int tires;
            Console.WriteLine("Enter number of wheels of Vehicle you want to create: ");
            tires = Convert.ToInt32(Console.ReadLine());
            while (tires <=1)
            {
                Console.WriteLine("Invalid number. Try again.");
                tires = Convert.ToInt32(Console.ReadLine());
            }

            var vehicle1 = VehicleFactory.GetVehicle(tires);
            vehicle1.Build();
        }
    }
}
