public static class TwoArrays
{
    public static string Execute(int k, int n, List<int> a, List<int> b)
    {
        Console.WriteLine($" Running execution for the values {k} and {n} at {DateTime.Now.ToLongTimeString()}...");
        if (a.Count != n || b.Count != n)
            return "ERROR";

        var orderedA = a.OrderBy(x => x).ToArray();
        var orderedB = b.OrderByDescending(x => x).ToArray();
        for (var i = 0; i < n; i++)
        {
            var total = orderedA[i] + orderedB[i];
            Console.WriteLine($"{orderedA[i]} + {orderedB[i]} = {total}");
            if (orderedA[i] + orderedB[i] < k)
                return "NO";
        }
        
        return "YES";
    }
}