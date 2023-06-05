namespace HackerRank.Core.Challenges;

public static class TimeConversion
{
    public static string Execute(string s)
    {
        Console.WriteLine($" Running execution for the value '{s}' at {DateTime.Now.ToLongTimeString()}...");
        var ampm = s.Substring(s.Length - 2, 2);
        var hour = int.Parse(s.Substring(0, 2));
        var timeSection = s.Substring(2, s.Length - 4);
        if (ampm == "AM" && hour == 12)
            hour = 0;
            
        if (ampm == "PM" && hour < 12)
            hour += 12;
        
        Console.WriteLine($"{ampm} {hour} {timeSection}");
        return $"{hour.ToString("D2")}{timeSection}";
    }
}