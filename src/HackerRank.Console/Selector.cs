namespace HackerRank.Console;

public static class Selector
{
    public static IChallengeSetup Create(int choice)
    {
        var timer = new ConsoleTimer();
        switch(choice)
        {
            case 1:
                return new PlusMinusSetup(timer);
            case 2:
                return new MiniMaxiSumSetup(timer);
            case 3:
                return new TimeConversionSetup(timer);
            case 4:
                return new MatchingStringsSetup(timer);
            case 5:
                return new LonelyIntegerSetup(timer);
            case 6:
                return new FlippingBitsSetup(timer);
            case 7:
                return new DiagonalDifferenceSetup(timer);
            case 8:
                return new CountingSortOneSetup(timer);
            case 9:
                return new PangramsSetup(timer);
            default:
                throw new InvalidOperationException("Invalid option.");
        }
    }
}