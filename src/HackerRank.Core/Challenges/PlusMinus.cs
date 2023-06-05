namespace HackerRank.Core.Challenges;

public class PlusMinus
{
    public static void Execute(List<int> arr)
    {
        Console.WriteLine($" Running execution for {arr.Count} items at {DateTime.Now.ToLongTimeString()}...");
        var total = arr.Count;
        var results = new Dictionary<string, int>{
            { "p", 0 },
            { "n", 0 },
            { "z", 0 }
        };
        
        foreach(var i in arr){
            if (i > 0)
                results["p"]++;
            else if (i < 0)
                results["n"]++;
            else
                results["z"]++;
        }
        
        Console.WriteLine($" + ({results["p"]}): {CalculateRatio(results["p"], total)}");
        Console.WriteLine($" - ({results["n"]}): {CalculateRatio(results["n"], total)}");
        Console.WriteLine($" 0 ({results["z"]}): {CalculateRatio(results["z"], total)}");
    }
    
    private static string CalculateRatio(int count, int total)
    {
        var countDecimal = Convert.ToDecimal(count);
        var totalDecimal = Convert.ToDecimal(total);
        return (countDecimal / totalDecimal).ToString("N6");
    }
}