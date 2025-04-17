using System;

namespace FactoryPattern;

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("🚗  Driving my car");
    }
}
