namespace HackerRank.Console;

public static class Selector
{
    public static IChallengeSetup Create(int choice)
    {
        var timer = new ConsoleTimer();
        return choice switch
        {
            1 => new PlusMinusSetup(timer),
            2 => new MiniMaxiSumSetup(timer),
            3 => new TimeConversionSetup(timer),
            4 => new MatchingStringsSetup(timer),
            5 => new LonelyIntegerSetup(timer),
            6 => new FlippingBitsSetup(timer),
            7 => new DiagonalDifferenceSetup(timer),
            8 => new CountingSortOneSetup(timer),
            9 => new PangramsSetup(timer),
            10 => new TwoArraysSetup(timer),
            11 => new BirthdaySetup(timer),
            12 => new MockTest1Setup(timer),
            _ => throw new InvalidOperationException("Invalid option."),
        };
    }
}