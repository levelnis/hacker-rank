namespace HackerRank.Core.Challenges.OneMonthWeekOne;

public static class CountingSortOne
{
    public static List<int> Execute(List<int> arr)
    {
        Console.WriteLine($" Running execution for {arr.Count} items at {DateTime.Now.ToLongTimeString()}...");
        var results = new int[100];
        var source = arr.ToArray();
        for (var i = 0; i < source.Length; i++)
        {
            var index = source[i];
            results[index]++;
        }

        return results.ToList();
    }
}