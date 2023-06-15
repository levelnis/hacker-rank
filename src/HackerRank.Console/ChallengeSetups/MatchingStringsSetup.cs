namespace HackerRank.Console.ChallengeSetups;

public class MatchingStringsSetup
{
    public static void Setup(int choice)
    {
        System.Console.WriteLine($"{choice}. Matching Strings");
        System.Console.WriteLine("  ==  Problem: There is a collection of input strings and a collection of query strings. For each query string, determine how many times it occurs in the list of input strings. Return an array of the results.");

        System.Console.WriteLine("How many input strings?");
        int stringsCount = Convert.ToInt32(System.Console.ReadLine()!.Trim());

        List<string> strings = new List<string>();

        for (int i = 0; i < stringsCount; i++)
        {
            System.Console.Write("Input: ");
            string stringsItem = System.Console.ReadLine()!;
            strings.Add(stringsItem);
        }

        System.Console.WriteLine("How many query strings?");
        int queriesCount = Convert.ToInt32(System.Console.ReadLine()!.Trim());

        List<string> queries = new List<string>();

        for (int i = 0; i < queriesCount; i++)
        {
            System.Console.Write("Query: ");
            string queriesItem = System.Console.ReadLine()!;
            queries.Add(queriesItem);
        }

        Execute(strings, queries);

        static void Execute(List<string> strings, List<string> queries)
        {
            var sw = new Stopwatch();
            sw.Start();
            List<int> result = MatchingStrings.Execute(strings, queries);
            sw.Stop();
            var elapsed = sw.Elapsed.ToString(@"m\:ss\.fff");
            System.Console.WriteLine("Result:");
            for(var i = 0; i < result.Count; i++)
                System.Console.WriteLine(result[i]);
            System.Console.WriteLine($"Time: {elapsed}");
        }
    }
}