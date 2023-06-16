namespace HackerRank.Core.Challenges;

public static class Pangrams
{
    private const string PangramSuccess = "pangram";
    private const string PangramFail = "not pangram";

    public static string Execute(string s)
    {
        var source = s.ToCharArray();
        var letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        var counts = new int[26];

        for (var i = 0; i < source.Length; i++)
        {
            if (!Char.IsLetter(source[i]))
                continue;

            var letterIndex = Array.IndexOf(letters, Char.ToLower(source[i]));
            counts[letterIndex]++;
        }

        for (var i = 0; i < counts.Length; i++)
        {
            if (counts[i] == 0)
                return PangramFail;
        }

        return PangramSuccess;
    }
}