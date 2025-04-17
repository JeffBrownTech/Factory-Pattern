
using FactoryPattern;

Console.WriteLine("How many tires will this vehicle have? (1, 2, 4)");
var wheelInput = Console.ReadLine();

if (int.TryParse(wheelInput, out var wheelNumber))
{
    var myVehicle = VehicleFactory.GetVehicle(wheelNumber);
    myVehicle.Drive();
}
else
{
    Console.WriteLine("Not a valid number!");
}
