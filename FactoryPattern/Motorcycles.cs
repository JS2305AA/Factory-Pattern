using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycles : IVehicle
    {
        public string Color { get; set; } = "White";
        public bool HasHandBreak { get; set; }
        public void Drive()
        {
            Console.WriteLine("Driving a motorcycle");
        }
       
    }
}
