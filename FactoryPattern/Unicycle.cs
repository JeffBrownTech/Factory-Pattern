using System;

namespace FactoryPattern;

public class Unicycle : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("🛞  Riding my unicycle");
    }
}
