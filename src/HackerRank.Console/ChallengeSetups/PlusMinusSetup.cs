namespace HackerRank.Console.ChallengeSetups;

public static class PlusMinusSetup
{
    public static void Setup(int choice)
    {
        System.Console.WriteLine($"{choice}. Plus Minus");
        System.Console.WriteLine("  ==  Problem: Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with 6 places after the decimal.");
        System.Console.WriteLine("Enter a mixture of positive, negative and zero ints, separated by a space");
        List<int> arr = System.Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

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