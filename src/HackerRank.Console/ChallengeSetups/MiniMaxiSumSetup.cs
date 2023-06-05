using System.Diagnostics;
using HackerRank.Core.Challenges;

namespace HackerRank.Console.ChallengeSetups;

public static class MiniMaxiSumSetup
{
    public static void Setup(int choice)
    {
        System.Console.WriteLine($"{choice}. Plus Minus");
        System.Console.WriteLine("  ==  Problem: Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.");
        System.Console.WriteLine("Enter 5 positive ints, separated by a space");
        List<int> arr = System.Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Execute(arr);

        static void Execute(List<int> arr)
        {
            var sw = new Stopwatch();
            sw.Start();
            MiniMaxiSum.Execute(arr);
            sw.Stop();
            var elapsed = sw.Elapsed.ToString(@"m\:ss\.fff");
            System.Console.WriteLine($"Time: {elapsed}");
        }
    }
}