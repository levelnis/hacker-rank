using System.Diagnostics;
using HackerRank.Core.Challenges;

namespace HackerRank.Console.ChallengeSetups;

public static class FlippingBitsSetup
{
    public static void Setup(int choice)
    {
        System.Console.WriteLine($"{choice}. Flipping Bits");
        System.Console.WriteLine("How many values?");
        int q = Convert.ToInt32(System.Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            System.Console.Write($"Enter value {qItr}: ");
            long n = Convert.ToInt64(System.Console.ReadLine().Trim());

            Execute(qItr, n);
        }

        static void Execute(int i, long n)
        {
            var sw = new Stopwatch();
            sw.Start();
            long result = FlippingBits.Execute(n);
            sw.Stop();
            var elapsed = sw.Elapsed.ToString(@"m\:ss\.fff");
            System.Console.WriteLine($"Result {i}: {result}, time: {elapsed}");
        }
    }
}