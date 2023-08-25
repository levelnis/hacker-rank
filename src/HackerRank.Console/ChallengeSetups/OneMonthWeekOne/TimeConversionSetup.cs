namespace HackerRank.Console.ChallengeSetups.OneMonthWeekOne;

public class TimeConversionSetup : IChallengeSetup
{
    private readonly ITimer _timer;

    public TimeConversionSetup(ITimer timer)
    {
        _timer = timer;
    }

    public void Run()
    {
        System.Console.WriteLine("Time Conversion");
        System.Console.WriteLine("  ==  Problem: Given a time in -hour AM/PM format, convert it to military (24-hour) time.");
        System.Console.WriteLine("Enter a 12 hour time string including the AM/PM, e.g. 06:30:25AM");

        string s = System.Console.ReadLine()!;

        Execute(s);

        void Execute(string s)
        {
            _timer.Start();
            var result = TimeConversion.Execute(s);
            _timer.StopAndLog();
            System.Console.WriteLine($"Results: {result}");
        }
    }
}