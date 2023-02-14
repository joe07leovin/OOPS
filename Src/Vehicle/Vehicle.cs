namespace TruckBuilder;

public abstract class Vehicle
{

    public string Name { get; set; }
    //constructor
    public Vehicle(string name)
    {
        Name = name;
    }
}
