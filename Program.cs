using TruckBuilder;

Prompt.setPromptLanguage(new English());
Console.WriteLine(Prompt.Language.ChooseYourName);
var name = Console.ReadLine();
if(name==string.Empty)
Console.WriteLine(Prompt.Language.DefaultName);
else
Console.WriteLine(Prompt.Language.Welcome,name);