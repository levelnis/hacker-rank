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

            long result = FlippingBits.Execute(n);

            System.Console.WriteLine($"Result {qItr}: {result}");
        }
    }
}