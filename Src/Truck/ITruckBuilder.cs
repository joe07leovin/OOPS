namespace TruckBuilder;

public interface ITruckBuilder
{

    ITruckBuilder BuildChasis();
    ITruckBuilder BuildBody();
    ITruckBuilder BuildCabin();
    Truck getTruck();
}