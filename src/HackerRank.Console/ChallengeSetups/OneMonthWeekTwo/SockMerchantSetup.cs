namespace HackerRank.Console.ChallengeSetups.OneMonthWeekTwo;

public class SockMerchantSetup : IChallengeSetup
{
    private readonly ITimer _timer;

    public SockMerchantSetup(ITimer timer)
    {
        _timer = timer;
    }

    public void Run()
    {
        System.Console.WriteLine("Sock Merchant");
        System.Console.WriteLine("  ==  Problem: There is a large pile of socks that must be paired by color. Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.");
        System.Console.WriteLine("Enter a mixture of positive ints, separated by a space");

        List<int> arr = System.Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Execute(arr);

        void Execute(List<int> arr)
        {
            _timer.Start();
            var result = SockMerchant.Execute(arr);
            _timer.StopAndLog();
            System.Console.WriteLine($"Results: there are {result} pair{(result == 1 ? "" : "s")}");
        }
    }
}