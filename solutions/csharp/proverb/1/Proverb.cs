public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        List<string> proverb = new();

        for (int i = 0; i < subjects.Length-1; i++)
        {
                proverb.Add(Opening(subjects[i], subjects[i + 1]));
        }   
        
        if (subjects.Length > 0)
                proverb.Add(Closing(subjects[0]));

        return proverb.ToArray();
    }

    private static string Opening(string first, string second) => $"For want of a {first} the {second} was lost.";
    private static string Closing(string first) => $"And all for the want of a {first}.";
}