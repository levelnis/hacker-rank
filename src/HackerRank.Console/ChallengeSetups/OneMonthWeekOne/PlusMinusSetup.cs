namespace HackerRank.Console.ChallengeSetups.OneMonthWeekOne;

public class PlusMinusSetup : IChallengeSetup
{
    private readonly ITimer _timer;

    public PlusMinusSetup(ITimer timer)
    {
        _timer = timer;
    }

    public void Run()
    {
        System.Console.WriteLine("Plus Minus");
        System.Console.WriteLine("  ==  Problem: Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with 6 places after the decimal.");
        System.Console.WriteLine("Enter a mixture of positive, negative and zero ints, separated by a space");
        List<int> arr = System.Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Execute(arr);

        void Execute(List<int> arr)
        {
            _timer.Start();
            PlusMinus.Execute(arr);
            _timer.StopAndLog();
        }
    }
}