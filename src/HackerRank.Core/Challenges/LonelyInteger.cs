namespace HackerRank.Core.Challenges;

public static class LonelyInteger
{
    public static int Execute(List<int> a)
    {
        Console.WriteLine($" Running execution for {a.Count} items at {DateTime.Now.ToLongTimeString()}...");

        var uniqueInts = new List<int>();
        foreach(var i in a){
            if (uniqueInts.Contains(i))
                uniqueInts.Remove(i);
            else
                uniqueInts.Add(i);
        }
        
        return uniqueInts[0];
    }
}