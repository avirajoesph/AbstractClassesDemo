using ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Motorcylces : Vehicles
    {
    public string feature { get; set; } = "has side cart";
    public string feature2 { get; set; } = "has bluetooth audio";

    public Motorcylces() 

    {
    
    
    
    }

    public override void DriveAbstract(Vehicles vehicle)
    {

    }
    public override void drivevirtual(Vehicles vehicle)
    {
        Console.WriteLine($"i own a motorcyle that drives fast");


    }
}

