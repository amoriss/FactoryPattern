using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numberOfWheels)
        {
            if (numberOfWheels > 2)
                return new Car();
            else if (numberOfWheels == 2)
                return new Motorcycle();
            else 
                return null; 
        }
    }
}
