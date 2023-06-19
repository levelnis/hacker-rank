namespace HackerRank.Console.ChallengeSetups;

public class FlippingBitsSetup : IChallengeSetup
{
    private readonly ITimer _timer;

    public FlippingBitsSetup(ITimer timer)
    {
        _timer = timer;
    }

    public void Run()
    {
        System.Console.WriteLine("Flipping Bits");
        System.Console.WriteLine("  ==  Problem: You will be given a list of 32 bit unsigned integers. Flip all the bits ( and ) and return the result as an unsigned integer.");
        System.Console.WriteLine("How many values?");
        int q = Convert.ToInt32(System.Console.ReadLine()!.Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            System.Console.Write($"Enter value {qItr}: ");
            long n = Convert.ToInt64(System.Console.ReadLine()!.Trim());

            Execute(qItr, n);
        }

        void Execute(int i, long n)
        {
            _timer.Start();
            var result = FlippingBits.Execute(n);
            _timer.StopAndLog();
            System.Console.WriteLine($"Result {i}: {result}");
        }
    }
}