using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car: IVehicle
    {
        public Car()
        {

        }
        public void Build()
        {
            Console.WriteLine("Building a new car.");
            Drive.InDrive();
        }
    }
}
