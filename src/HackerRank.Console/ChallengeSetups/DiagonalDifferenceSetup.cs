namespace HackerRank.Console.ChallengeSetups;

public class DiagonalDifferenceSetup : IChallengeSetup
{
    public void Run()
    {
        System.Console.WriteLine("Diagonal Difference");
        System.Console.WriteLine("  ==  Problem: Given a square matrix, calculate the absolute difference between the sums of its diagonals.");
        System.Console.WriteLine("How big is the matrix?");
        int n = Convert.ToInt32(System.Console.ReadLine()!.Trim());
        List<List<int>> arr = new List<List<int>>();

        System.Console.WriteLine($"Enter {n} integers separated by space, {n} times");
        for (int i = 0; i < n; i++)
        {
            System.Console.Write($"Row {i + 1}: ");
            arr.Add(System.Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        Execute(arr);

        static void Execute(List<List<int>> arr)
        {
            var sw = new Stopwatch();
            sw.Start();
            int result = DiagonalDifference.Execute(arr);
            sw.Stop();
            var elapsed = sw.Elapsed.ToString(@"m\:ss\.fff");
            System.Console.WriteLine($"Result: {result}, time: {elapsed}");
        }
    }
}