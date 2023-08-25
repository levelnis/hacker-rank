namespace HackerRank.Core.Challenges.OneMonthWeekTwo;

public static class SockMerchant
{
    public static int Execute(List<int> arr)
    {
        Console.WriteLine($" Running execution for {arr.Count} items at {DateTime.Now.ToLongTimeString()}...");

        var sortedItems = arr.OrderBy(x => x).ToList();
        var matches = 0;
        while (sortedItems.Count > 0)
        {
            Console.WriteLine($"Array has {sortedItems.Count} items");
            if (sortedItems.Count == 1)
            {
                sortedItems.RemoveAt(0);
                break;
            }

            var endIndex = sortedItems.Count - 1;
            var last = sortedItems[endIndex];
            var previous = sortedItems[endIndex - 1];
            sortedItems.RemoveAt(endIndex);
            if (last == previous)
            {
                matches++;
                sortedItems.RemoveAt(endIndex - 1);
            }
        }

        return matches;
    }
}