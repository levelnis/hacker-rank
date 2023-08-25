namespace HackerRank.Console.ChallengeSetups.OneMonthWeekOne;

public class TwoArraysSetup : IChallengeSetup
{
    private readonly ITimer _timer;

    public TwoArraysSetup(ITimer timer)
    {
        _timer = timer;
    }

    public void Run()
    {
        System.Console.WriteLine("Two Arrays");
        System.Console.WriteLine("  ==  Problem: There are two n-element arrays of integers, A and B. Permute them into some A' and B' such that the relation A'[i] + B'[i] >= k holds for all i where 0 <= i < n.");
        System.Console.WriteLine("  ==  There will be q queries consisting of A, B, and k. For each query, return YES if some permutation A', B' satisfying the relation exists. Otherwise, return NO.");

        System.Console.WriteLine("How many queries?");
        var q = Convert.ToInt32(System.Console.ReadLine()!.Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            System.Console.WriteLine("Enter array size and total separated by a space");
            string[] firstMultipleInput = System.Console.ReadLine()!.TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            System.Console.WriteLine($"Enter first array of {n} ints separated by a space");
            List<int> a = System.Console.ReadLine()!.TrimEnd().Split(' ').Select(ATemp => Convert.ToInt32(ATemp)).ToList();

            System.Console.WriteLine($"Enter second array of {n} ints separated by a space");
            List<int> b = System.Console.ReadLine()!.TrimEnd().Split(' ').Select(BTemp => Convert.ToInt32(BTemp)).ToList();

            Execute(k, n, a, b);
        }

        void Execute(int k, int n, List<int> a, List<int> b)
        {
            _timer.Start();
            var result = TwoArrays.Execute(k, n, a, b);
            _timer.StopAndLog();
            System.Console.WriteLine($"Result: {result}");
        }
    }
}