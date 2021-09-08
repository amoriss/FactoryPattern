using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 

namespace FactoryPattern
{
    public class Drive
    {

        public static void InDrive()
        {
            Thread.Sleep(1000);
            Console.WriteLine("This vehicle is in drive!");
            Thread.Sleep(1000);
        }


    }
}
