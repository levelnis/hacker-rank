using System.Diagnostics;
using HackerRank.Core.Challenges;

namespace HackerRank.Console.ChallengeSetups;

public static class PlusMinusSetup
{
    public static void Setup(int choice)
    {
        System.Console.WriteLine($"{choice}. Plus Minus");
        System.Console.WriteLine("Enter a mixture of positive, negative and zero ints, separated by a space");
        List<int> arr = System.Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Execute(arr);

        static void Execute(List<int> arr)
        {
            var sw = new Stopwatch();
            sw.Start();
            PlusMinus.Execute(arr);
            sw.Stop();
            var elapsed = sw.Elapsed.ToString(@"m\:ss\.fff");
            System.Console.WriteLine($"Time: {elapsed}");
        }
    }
}