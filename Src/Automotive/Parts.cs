namespace TruckBuilder;

public class Parts
{
    public string Engine { get; protected set; }
    public GearBoxAdapter GearBox { get; protected set; }
    public int Wheels { get; protected set; }
    public int Tonnage{get;protected set;}

    public string Suspension{get; protected set;}

    public string DashBoard{get; protected set;}

    public int NumberOfAirBags{get; protected set;}

    public string PaintScheme{get;protected set;}
    public string exhaust{get; protected set;}
    public bool Cameras{get; protected set ;}

}

public class GearBoxAdapter
{
    public string GearBox { get; protected set; }
    public bool Crawler { get; protected set; }
}