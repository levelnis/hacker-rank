namespace HackerRank.Console.ChallengeSetups.OneMonthWeekOne;

public class MockTest1Setup : IChallengeSetup
{
    private readonly ITimer _timer;

    public MockTest1Setup(ITimer timer)
    {
        _timer = timer;
    }

    public void Run()
    {
        System.Console.WriteLine("Mock Test 1");
        System.Console.WriteLine("  ==  Problem: Flipping the matrix. Given a matrix of size 2x, work out the largest sub-matrix x total by reversing rows/columns");

        System.Console.WriteLine("How many numbers?");
        int n = Convert.ToInt32(System.Console.ReadLine()!.Trim());

        List<List<int>> matrix = new List<List<int>>();

        for (int i = 0; i < 2 * n; i++)
        {
            System.Console.WriteLine($"Enter {2 * n} numbers separated by space");
            matrix.Add(System.Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
        }

        Execute(matrix);

        void Execute(List<List<int>> matrix)
        {
            _timer.Start();
            var result = MockTest1.Execute(matrix);
            _timer.StopAndLog();
            System.Console.WriteLine($"Result: {result}");
        }
    }
}