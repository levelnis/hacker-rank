namespace HackerRank.Console.ChallengeSetups;

public class BirthdaySetup : IChallengeSetup
{
    private readonly ITimer _timer;

    public BirthdaySetup(ITimer timer)
    {
        _timer = timer;
    }

    public void Run()
    {
        System.Console.WriteLine("Birthday");
        System.Console.WriteLine("  ==  Problem: Two children, Lily and Ron, want to share a chocolate bar. Each of the squares has an integer on it. Lily decides to share a contiguous segment of the bar selected such that:");
        System.Console.WriteLine("  ==  * The length of the segment matches Ron's birth month");
        System.Console.WriteLine("  ==  * The sum of the integers on the squares is equal to his birth day");
        System.Console.WriteLine("  ==  Determine how many ways she can divide the chocolate.");

        System.Console.WriteLine("How many squares are in the chocolate bar?");
        var n = Convert.ToInt32(System.Console.ReadLine()!.Trim());

        System.Console.WriteLine($"Enter {n} positive ints, separated by a space");
        List<int> s = System.Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        System.Console.WriteLine("Enter Ron's birth day (the total) and month (the length), separated by a space");
        string[] firstMultipleInput = System.Console.ReadLine()!.TrimEnd().Split(' ');

        int d = Convert.ToInt32(firstMultipleInput[0]);
        int m = Convert.ToInt32(firstMultipleInput[1]);

        Execute(s, n, d, m);

        void Execute(List<int> s, int n, int d, int m)
        {
            _timer.Start();
            var result = Birthday.Execute(s, n, d, m);
            _timer.StopAndLog();
            System.Console.WriteLine($"Result: {result}");
        }
    }
}