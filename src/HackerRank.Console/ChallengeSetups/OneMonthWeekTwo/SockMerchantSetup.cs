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
    }
}