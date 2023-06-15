using HackerRank.Console.ChallengeSetups;

public static class Selector
{
    public static IChallengeSetup Create(int choice)
    {
        switch(choice)
        {
            case 1:
                return new PlusMinusSetup();
            case 2:
                return new MiniMaxiSumSetup();
            case 3:
                return new TimeConversionSetup();
            case 4:
                return new MatchingStringsSetup();
            case 5:
                return new LonelyIntegerSetup();
            case 6:
                return new FlippingBitsSetup();
            case 7:
                return new DiagonalDifferenceSetup();
            case 8:
                return new CountingSortOneSetup();
            default:
                throw new InvalidOperationException("Invalid option.");
        }
    }
}