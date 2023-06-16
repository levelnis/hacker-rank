namespace HackerRank.Console;

public class ConsoleTimer : ITimer
{
    private Stopwatch _sw;

    public ConsoleTimer()
    {
        _sw = new Stopwatch();
    }

    public void Start()
    {
        _sw.Start();
    }

    public void StopAndLog()
    {
        _sw.Stop();
        var elapsed = _sw.Elapsed.ToString(@"m\:ss\.fff");
        System.Console.WriteLine($"Time: {elapsed}");
    }
}