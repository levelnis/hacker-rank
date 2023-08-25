namespace HackerRank.Console.ChallengeSetups.OneMonthWeekOne;

public class PangramsSetup : IChallengeSetup
{
    private readonly ITimer _timer;

    public PangramsSetup(ITimer timer)
    {
        _timer = timer;
    }

    public void Run()
    {
        System.Console.WriteLine("Pangrams");
        System.Console.WriteLine("  ==  Problem: A pangram is a string that contains every letter of the alphabet. Given a sentence determine whether it is a pangram in the English alphabet. Ignore case. Return either pangram or not pangram as appropriate.");
        System.Console.WriteLine("Enter source string:");

        var s = System.Console.ReadLine();

        Execute(s);

        void Execute(string? s)
        {
            if (s is null)
            {
                System.Console.WriteLine(" * null value entered * ");
                return;
            }

            _timer.Start();
            var result = Pangrams.Execute(s);
            _timer.StopAndLog();
            System.Console.WriteLine($"Result: {result}");
        }
    }
}