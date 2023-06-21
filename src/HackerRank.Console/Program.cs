// See https://aka.ms/new-console-template for more information
Console.WriteLine("Choose from the following challenges:");
Console.WriteLine("1. Plus Minus");
Console.WriteLine("2. Mini-Maxi Sum");
Console.WriteLine("3. Time Conversion");
Console.WriteLine("4. Matching Strings (Sparse Arrays)");
Console.WriteLine("5. Lonely Integer");
Console.WriteLine("6. Flipping Bits");
Console.WriteLine("7. Diagonal Difference");
Console.WriteLine("8. Counting Sort 1");
Console.WriteLine("9. Pangrams");
Console.WriteLine("10. Two Arrays");
Console.WriteLine("11. Birthday");
Console.WriteLine("12. Mock Test 1");

int choice = Convert.ToInt32(Console.ReadLine()!.Trim());
var runner = Selector.Create(choice);
runner.Run();