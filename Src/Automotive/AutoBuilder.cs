namespace TruckBuilder;

public class AutoBuilder : IAutoBuilder
{

private AutoFrame _Frame;
private Parts _Parts;
    public AutoBuilder(){

        _Frame = new AutoFrame();
        _Parts= new Parts();

    }
    public IAutoBuilder BuidlCabin()
    {
        throw new NotImplementedException();
    }

    public IAutoBuilder BuildBody()
    {
        throw new NotImplementedException();
    }

    public IAutoBuilder BuildChasis()
    {
        throw new NotImplementedException();
    }
}