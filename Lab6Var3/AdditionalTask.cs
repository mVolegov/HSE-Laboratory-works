using System.Text.RegularExpressions;

public static class AdditionalTask
{
    private static string domain = @"[a-zA-Z0-9]{2,512}";
    private static string topLevelDomain = @"[a-zA-Z0-9]{1,3}\b";
    private static string remainingPart = @"([a-zA-Z0-9()@:%_\+.~#?&\/=]*)";
    private static string urlPattern = domain + @"\." + topLevelDomain + remainingPart;

    public static bool IsMatchUrl(string input)
    {
        Regex regex = new Regex(urlPattern);
        MatchCollection matches = regex.Matches(input);
    
        if (matches.Count > 0) return true;
        else return false;
    }
}