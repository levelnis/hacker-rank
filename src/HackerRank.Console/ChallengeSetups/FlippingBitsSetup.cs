using System.Diagnostics;
using HackerRank.Core.Challenges;

namespace HackerRank.Console.ChallengeSetups;

public static class FlippingBitsSetup
{
    public static void Setup(int choice)
    {
        System.Console.WriteLine($"{choice}. Flipping Bits");
        System.Console.WriteLine("  ==  Problem: You will be given a list of 32 bit unsigned integers. Flip all the bits ( and ) and return the result as an unsigned integer.");
        System.Console.WriteLine("How many values?");
        int q = Convert.ToInt32(System.Console.ReadLine()!.Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            System.Console.Write($"Enter value {qItr}: ");
            long n = Convert.ToInt64(System.Console.ReadLine()!.Trim());

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