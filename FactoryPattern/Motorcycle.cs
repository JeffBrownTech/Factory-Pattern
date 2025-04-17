using System;

namespace FactoryPattern;

public class Motorcycle : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("🏍️  Driving my motorcycle");
    }
}
