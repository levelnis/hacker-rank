namespace HackerRank.Console;

public static class Selector
{
    public static IChallengeSetup SelectChallenge(ChallengeOption option, int choice)
    {
        var timer = new ConsoleTimer();
        return option switch
        {
            ChallengeOption.OneMonthWeekOne => choice switch
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
            },
            ChallengeOption.OneMonthWeekTwo => choice switch
            {
                1 => new SockMerchantSetup(timer),
                _ => throw new InvalidOperationException("Invalid option."),
            },
            _ => throw new InvalidOperationException("Invalid option."),
        };
    }

    public static string GetChallengeOptionsText(ChallengeOption option)
    {
        return option switch
        {
            ChallengeOption.OneMonthWeekOne => @"1. Plus Minus
2. Mini-Maxi Sum
3. Time Conversion
4. Matching Strings (Sparse Arrays)
5. Lonely Integer
6. Flipping Bits
7. Diagonal Difference
8. Counting Sort 1
9. Pangrams
10. Two Arrays
11. Birthday
12. Mock Test 1",
            ChallengeOption.OneMonthWeekTwo => @"1. Sock Merchant",
            _ => throw new InvalidOperationException("Invalid option."),
        };
    }
}