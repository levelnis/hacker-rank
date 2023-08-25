namespace HackerRank.Core.Challenges.OneMonthWeekOne;

public static class MiniMaxiSum
{
    public static void Execute(List<int> arr)
    {
        Console.WriteLine($" Running execution for {arr.Count} items at {DateTime.Now.ToLongTimeString()}...");

        int min = 0, max = 0;
        for(var i = 0; i < arr.Count; i++){
            min = FindMin(min, arr[i]);
            max = FindMax(max, arr[i]);
        }
        
        var total = GetTotal(arr);
        var minSum = total - max;
        var maxSum = total - min;
        
        Console.WriteLine($"{minSum} {maxSum}");

        static int FindMin(int currentMin, int next)
        {
            if (currentMin == 0)
                return next;
                
            return currentMin < next ? currentMin : next;
        }

        static int FindMax(int currentMax, int next)
        {
            if (currentMax == 0)
                return next;
                
            return currentMax > next ? currentMax : next;
        }
        
        static double GetTotal(List<int> values)
        {
            double currentTotal = 0;
            for(var i = 0; i < values.Count; i++){
                currentTotal += values[i];
            }
            
            return currentTotal;
        }
    }
}