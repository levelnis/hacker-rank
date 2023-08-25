namespace HackerRank.Core.Challenges.OneMonthWeekOne;

public static class Birthday
{
    public static int Execute(List<int> s, int n, int d, int m)
    {
        Console.WriteLine($" Running execution for {s.Count} items ({n}), day {d}, month {m} at {DateTime.Now.ToLongTimeString()}...");
        if (s.Count != n)
        {
            Console.WriteLine("Error: n and length of s do not match.");
            return -1;
        }

        var totals = new List<int>();
        for (var i = 0; i < n; i++)
        {
            var total = SumSubArray(s, i, m);
            if (total > 0)
            {
                totals.Add(total);
            }
        }

        return totals.Count(x => x == d);

        int SumSubArray(List<int> s, int start, int length)
        {
            Console.WriteLine($"Summing array at start {start} of length {length}.");
            var end = length + start;
            if (end > s.Count)
            {
                Console.WriteLine(" *** Invalid. Returning 0 ***");
                return 0;
            }

            var total = 0;
            for (var i = start; i < end; i++)
            {
                total += s[i];
            }

            Console.WriteLine($" * Valid. Returning {total} *");
            return total;
        }
    }
}