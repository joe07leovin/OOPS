namespace TruckBuilder;

public interface ITruckBuilder
{
    public string Chasis { get; protected set; }
    public string GearBox { get; protected set; }

    public string Engine { get; protected set; }

    public string Suspension { get; protected set; }

    public int NumberOfWheels { get; protected set; }

    public int Capacity { get; protected set; }

    public void setChasis(string Chasis);
    public void setGearBox(string GearBox);
    public void setEngine(string Engine);
    public void setSuspension(string Suspension);
    public void setNumberOfWheels(int ChasiWheels);
    public void setCapacity(int capacity);

}