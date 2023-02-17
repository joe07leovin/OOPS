namespace TruckBuilder;

public class TruckPartsBuilderDirector
{

    private readonly ITruckBuilder _truckBuilder;

    public TruckPartsBuilderDirector(ITruckBuilder truckBuilder)
    {
        _truckBuilder = truckBuilder;
    }

    public void BuildTruck()
    {
        _truckBuilder.BuildBody().BuildCabin().BuildChasis();
    }
}