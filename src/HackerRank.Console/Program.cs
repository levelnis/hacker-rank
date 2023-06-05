﻿using HackerRank.Console.ChallengeSetups;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Choose from the following challenges:");
Console.WriteLine("1. Plus Minus");
Console.WriteLine("2. Mini-Maxi Sum");
Console.WriteLine("3. Time Conversion");
Console.WriteLine("4. Sparse Arrays");
Console.WriteLine("5. Lonely Integer");
Console.WriteLine("6. Flipping Bits");

int choice = Convert.ToInt32(Console.ReadLine()!.Trim());
switch(choice){
    case 1:
        PlusMinusSetup.Setup(choice);
        break;
    case 2:
        MiniMaxiSumSetup.Setup(choice);
        break;
    case 3:
        TimeConversionSetup.Setup(choice);
        break;
    case 6:
        FlippingBitsSetup.Setup(choice);
        break;
    default:
        throw new InvalidOperationException("Invalid option.");
}