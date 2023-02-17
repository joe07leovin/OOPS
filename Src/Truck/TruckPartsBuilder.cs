namespace TruckBuilder;

public class TruckPartsBuilder : ITruckBuilder
{

    private IEnumerable<BuilderParts> _truckCompoents;
    private Truck _truck;

    public TruckPartsBuilder(IEnumerable<BuilderParts> truckComponents)
    {
        _truckCompoents = truckComponents;
        _truck = new Truck();

    }
    public ITruckBuilder BuildBody()
    {
        _truck.Body = string.Join(Environment.NewLine, _truckCompoents.Select(t => $"Truck Body cosntructed with gearbox {t.GearBox} and {t.Wheels} number of wheels"));
        return this;
    }

    public ITruckBuilder BuildCabin()
    {
        _truck.Cabin = string.Join(Environment.NewLine, _truckCompoents.Select(t => $"Truck Cabin cosntructed with chasis {t.Chasis} and engine {t.Engine} "));
        return this;
    }

    public ITruckBuilder BuildChasis()
    {
        _truck.Frame = string.Join(Environment.NewLine, _truckCompoents.Select(t => $"Truck Frame cosntructed with Suspension {t.Suspension} and a capacity {t.Capacity} "));
        return this;
    }

    public Truck getTruck()
    {
        var truck = _truck;
        return truck;
    }
}