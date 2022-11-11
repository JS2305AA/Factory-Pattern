using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class VehicleFactory
    {
        public IVehicle CreateVehicle(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "car":
                    return new Car() { Color = "Blue", IsDriveable = true};
                    
                  

                case "motorcycle":
                    return new Motorcycles();
                default:
                    return new Car();
                    
                
            }
        }
    }
}
