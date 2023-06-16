namespace HackerRank.Console.ChallengeSetups;

public class MiniMaxiSumSetup : IChallengeSetup
{
    private readonly ITimer _timer;

    public MiniMaxiSumSetup(ITimer timer)
    {
        _timer = timer;
    }

    public void Run()
    {
        System.Console.WriteLine("Plus Minus");
        System.Console.WriteLine("  ==  Problem: Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.");
        System.Console.WriteLine("Enter 5 positive ints, separated by a space");
        List<int> arr = System.Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Execute(arr);

        void Execute(List<int> arr)
        {
            _timer.Start();
            MiniMaxiSum.Execute(arr);
            _timer.StopAndLog();
        }
    }
}