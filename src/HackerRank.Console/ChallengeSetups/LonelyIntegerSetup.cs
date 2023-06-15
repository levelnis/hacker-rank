namespace HackerRank.Console.ChallengeSetups;

public class LonelyIntegerSetup : IChallengeSetup
{
    public void Run()
    {
        System.Console.WriteLine("Lonely Integer");
        System.Console.WriteLine("  ==  Problem: Given an array of integers, where all elements but one occur twice, find the unique element.");
        System.Console.WriteLine("Enter a bunch of int pairs, include 1 unique int, separated by a space");
        List<int> arr = System.Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Execute(arr);

        static void Execute(List<int> arr)
        {
            var sw = new Stopwatch();
            sw.Start();
            var result = LonelyInteger.Execute(arr);
            sw.Stop();
            var elapsed = sw.Elapsed.ToString(@"m\:ss\.fff");
            System.Console.WriteLine($"Result: {result}, time: {elapsed}");
        }
    }
}