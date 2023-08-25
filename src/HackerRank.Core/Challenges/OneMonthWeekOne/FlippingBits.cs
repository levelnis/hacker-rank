namespace HackerRank.Core.Challenges.OneMonthWeekOne;

public static class FlippingBits
{
    public static long Execute(long n)
    {
        Console.WriteLine($" Running execution for {n} at {DateTime.Now.ToLongTimeString()}...");
        var sourceBin = Convert.ToString(n, 2).PadLeft(32, '0');
        Console.Write($"Source: {sourceBin}");
        var flippedBin = sourceBin.Replace('0', 'x').Replace('1', '0').Replace('x', '1');
        Console.Write($" | Flipped: {flippedBin}");
        var result = Convert.ToInt64(flippedBin, 2);
        Console.WriteLine($" | Result: {result}");
        return result;
    }
}