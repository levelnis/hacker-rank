using System.Diagnostics;
using HackerRank.Core.Challenges;

namespace HackerRank.Console.ChallengeSetups;

public class TimeConversionSetup
{
    public static void Setup(int choice)
    {
        System.Console.WriteLine($"{choice}. Time Conversion");
        System.Console.WriteLine("  ==  Problem: Given a time in -hour AM/PM format, convert it to military (24-hour) time.");
        System.Console.WriteLine("Enter a 12 hour time string including the AM/PM, e.g. 06:30:25AM");

        string s = System.Console.ReadLine()!;

        Execute(s);

        static void Execute(string s)
        {
            var sw = new Stopwatch();
            sw.Start();
            string result = TimeConversion.Execute(s);
            sw.Stop();
            var elapsed = sw.Elapsed.ToString(@"m\:ss\.fff");
            System.Console.WriteLine($"Result: {result}, time: {elapsed}");
        }
    }
}