﻿namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of vehicle do you want to make? Car or motorcycle??");

            string userInput = Console.ReadLine();  

            VehicleFactory factory = new VehicleFactory();
            IVehicle myVehicle = factory.CreateVehicle(userInput);
            myVehicle.Drive();
            
          
            Console.WriteLine("Let's make another vehicle");

            

            userInput = Console.ReadLine();    
        }
    }
}
