namespace HackerRank.Core.Challenges.OneMonthWeekOne;

public static class TimeConversion
{
    public static string Execute(string s)
    {
        Console.WriteLine($" Running execution for the value '{s}' at {DateTime.Now.ToLongTimeString()}...");
        var ampm = s.Substring(s.Length - 2, 2);
        var hour = int.Parse(s[..2]);
        var timeSection = s[2..^2];
        if (ampm == "AM" && hour == 12)
            hour = 0;
            
        if (ampm == "PM" && hour < 12)
            hour += 12;
        
        Console.WriteLine($"{ampm} {hour} {timeSection}");
        return $"{hour:D2}{timeSection}";
    }
}