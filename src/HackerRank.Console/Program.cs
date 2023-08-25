// See https://aka.ms/new-console-template for more information


Console.WriteLine("Select Group:");
Console.WriteLine("1. One Month Week One");
Console.WriteLine("2. One Month Week Two");
var group = Convert.ToInt32(Console.ReadLine()!.Trim());
var challengeOption = (ChallengeOption)group;

Console.WriteLine("Choose from the following challenges:");
Console.WriteLine(Selector.GetChallengeOptionsText(challengeOption));

int choice = Convert.ToInt32(Console.ReadLine()!.Trim());
var runner = Selector.SelectChallenge(challengeOption, choice);
runner.Run();