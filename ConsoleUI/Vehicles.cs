using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    abstract class Vehicles
    {
        public string Year { get; set; } = "2025";
        public string Make { get; set; } = "mustang";
        public string Model { get; set; } = "Gt";
        public abstract void DriveAbstract(Vehicles vehicle);
       
        public virtual void drivevirtual(Vehicles vehicle) 
        {

            Console.WriteLine($"i have a {vehicle.Make} it is a {vehicle.Year} {vehicle.Model}");
        
        }
    }
}
