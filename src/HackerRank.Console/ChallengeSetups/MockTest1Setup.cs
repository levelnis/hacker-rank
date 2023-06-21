namespace HackerRank.Console.ChallengeSetups;

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
        System.Console.WriteLine("  ==  Problem: Find the middle number in a list");

        System.Console.WriteLine("How many numbers?");
        int n = Convert.ToInt32(System.Console.ReadLine()!.Trim());

        System.Console.WriteLine("Enter numbers separated by space?");
        List<int> arr = System.Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Execute(arr);

        void Execute(List<int> arr)
        {
            _timer.Start();
            var result = MockTest1.Execute(arr);
            _timer.StopAndLog();
            System.Console.WriteLine($"Result: {result}");
        }
    }
}