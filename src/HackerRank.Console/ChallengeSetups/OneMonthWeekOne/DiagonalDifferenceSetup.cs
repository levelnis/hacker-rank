namespace HackerRank.Console.ChallengeSetups.OneMonthWeekOne;

public class DiagonalDifferenceSetup : IChallengeSetup
{
    private readonly ITimer _timer;

    public DiagonalDifferenceSetup(ITimer timer)
    {
        _timer = timer;
    }

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

        void Execute(List<List<int>> arr)
        {
            _timer.Start();
            var result = DiagonalDifference.Execute(arr);
            _timer.StopAndLog();
            System.Console.WriteLine($"Results: {result}");
        }
    }
}