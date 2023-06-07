namespace HackerRank.Core.Challenges;

public static class DiagonalDifference
{
    public static int Execute(List<List<int>> arr)
    {
        Console.WriteLine($" Running execution for {arr.Count} items at {DateTime.Now.ToLongTimeString()}...");

        var forwardTotal = SumForwardDiagonal(arr);
        var reverseTotal = SumReverseDiagonal(arr);
        Console.WriteLine($"Forward total: {forwardTotal}. Reverse total: {reverseTotal}");
        return Math.Abs(forwardTotal - reverseTotal);

        static int SumForwardDiagonal(List<List<int>> arr)
        {
            var total = 0;
            for(var i = 0; i < arr.Count; i++)
            {
                total += arr[i][i];
            }

            return total;
        }

        static int SumReverseDiagonal(List<List<int>> arr)
        {
            var total = 0;
            var j = arr.Count - 1;
            for(var i = 0; i < arr.Count; i++)
            {
                total += arr[i][j];
                j--;
            }

            return total;
        }
    }
}