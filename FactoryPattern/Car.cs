using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public string Color { get; set; } = "White";
        public bool IsDriveable { get; set; }
        public void Drive()
        {
            Console.WriteLine($"Sorry, can't text I'm driving my {Color} car");
        }
    }
}
