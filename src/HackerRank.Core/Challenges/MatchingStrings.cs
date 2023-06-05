namespace HackerRank.Core.Challenges;

public class MatchingStrings
{
    public static List<int> Execute(List<string> strings, List<string> queries)
    {
        Console.WriteLine($" Running execution for {strings.Count} strings and {queries.Count} queries at {DateTime.Now.ToLongTimeString()}...");
        var inputs = new Dictionary<string, int>();
        foreach(var item in strings){
            if (!inputs.ContainsKey(item))
                inputs.Add(item, 1);
            else
                inputs[item]++;
        }
        
        var outputCounts = new int[queries.Count];
        for(var i = 0; i < queries.Count; i++){
            var query = queries[i];
            if (inputs.ContainsKey(query))
                outputCounts[i] = inputs[query];
        }
        
        return outputCounts.ToList();
    }
}