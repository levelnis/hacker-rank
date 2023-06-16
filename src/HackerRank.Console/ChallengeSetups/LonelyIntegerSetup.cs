namespace HackerRank.Console.ChallengeSetups;

public class LonelyIntegerSetup : IChallengeSetup
{
    private readonly ITimer _timer;

    public LonelyIntegerSetup(ITimer timer)
    {
        _timer = timer;
    }

    public void Run()
    {
        System.Console.WriteLine("Lonely Integer");
        System.Console.WriteLine("  ==  Problem: Given an array of integers, where all elements but one occur twice, find the unique element.");
        System.Console.WriteLine("Enter a bunch of int pairs, include 1 unique int, separated by a space");
        List<int> arr = System.Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Execute(arr);

        void Execute(List<int> arr)
        {
            _timer.Start();
            var result = LonelyInteger.Execute(arr);
            _timer.StopAndLog();
            System.Console.WriteLine($"Results: {result}");
        }
    }
}