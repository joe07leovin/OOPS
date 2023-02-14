namespace TruckBuilder;

public partial class Chasis
{

    public Truck Truck { get; }

    public readonly Random _rnd = new Random(123);


    public Chasis(Truck truck)
    {
        Truck = truck;
    }
}