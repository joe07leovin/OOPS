namespace TruckBuilder;

public static class Prompt
{

    private static Language _language;

    public static Language Language
    {

        get
        {
            if (_language == null)
                Console.WriteLine("no language selected");
            return _language;
        }

    }

    public static void setPromptLanguage(Language language){
        _language=language;
    }
}