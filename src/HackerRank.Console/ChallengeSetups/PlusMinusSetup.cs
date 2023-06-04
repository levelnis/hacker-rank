using HackerRank.Core.Challenges;

namespace HackerRank.Console.ChallengeSetups;

public static class PlusMinusSetup
{
    public static void Setup(int choice)
    {
        System.Console.WriteLine($"{choice}. Plus Minus");
        System.Console.WriteLine("How many values?");
        int n = Convert.ToInt32(System.Console.ReadLine().Trim());

        List<int> arr = System.Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        PlusMinus.Execute(arr);
    }
}