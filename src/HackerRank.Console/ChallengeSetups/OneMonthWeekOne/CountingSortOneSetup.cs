namespace HackerRank.Console.ChallengeSetups.OneMonthWeekOne;

public class CountingSortOneSetup : IChallengeSetup
{
    private readonly ITimer _timer;

    public CountingSortOneSetup(ITimer timer)
    {
        _timer = timer;
    }

    public void Run()
    {
        System.Console.WriteLine("Counting Sort 1");
        System.Console.WriteLine("  ==  Problem: Quicksort usually has a running time of n x log(n), but is there an algorithm that can sort even faster? In general, this is not possible. Most sorting algorithms are comparison sorts, i.e. they sort a list just by comparing the elements to one another. A comparison sort algorithm cannot beat n x log(n) (worst-case) running time, since n x log(n) represents the minimum number of comparisons needed to know where to place each element.");
        System.Console.WriteLine();
        System.Console.WriteLine("  ==  Another sorting method, the counting sort, does not require comparison. Instead, you create an integer array whose index range covers the entire range of values in your array to sort. Each time a value occurs in the original array, you increment the counter at that index. At the end, run through your counting array, printing the value of each non-zero valued index that number of times.");
        System.Console.WriteLine("  ==  For this exercise, always return a frequency array with 100 elements. The example above shows only the first 4 elements, the remainder being zeros.");
        System.Console.WriteLine("  ==  Given a list of integers, count and return the number of times each value appears as an array of integers.");
        System.Console.WriteLine("Enter a mixture of positive ints, separated by a space");

        List<int> arr = System.Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Execute(arr);

        void Execute(List<int> arr)
        {
            _timer.Start();
            var result = CountingSortOne.Execute(arr);
            _timer.StopAndLog();
            System.Console.WriteLine($"Results: {String.Join(" ", result)}");
        }
    }
}