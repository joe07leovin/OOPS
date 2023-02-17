using TruckBuilder;

var truckparts = new List<BuilderParts>{
new BuilderParts{Engine="Eu650T",GearBox="Ty009",Chasis="Base",Wheels=10,Capacity=100,Suspension="C"}
};

var builder = new TruckPartsBuilder(truckparts);
var director = new TruckPartsBuilderDirector(builder);
director.BuildTruck();
var truck = builder.getTruck();
Console.WriteLine(truck.Body);
Console.WriteLine(truck.Cabin);
Console.WriteLine(truck.Frame);
Prompt.setPromptLanguage(new English());
Console.WriteLine(Prompt.Language.ChooseYourName);
var name = Console.ReadLine();
if (name == string.Empty)
    Console.WriteLine(Prompt.Language.DefaultName);
else
    Console.WriteLine(Prompt.Language.Welcome, name);