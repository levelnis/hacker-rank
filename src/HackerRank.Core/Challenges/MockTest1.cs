namespace HackerRank.Core.Challenges;

public static class MockTest1
{
    public static int Execute(List<int> arr)
    {
        Console.WriteLine($" Running execution for {arr.Count} items at {DateTime.Now.ToLongTimeString()}...");
        var source = arr.OrderBy(x => x).ToArray();
        var length = arr.Count;
        var midpoint = (length - 1) / 2;
        return source[midpoint];
    }
}