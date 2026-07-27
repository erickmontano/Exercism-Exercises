using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new();

        bool isUppercase = false;
        for (int i = 0; i < identifier.Length; i++)
        {
            char c = identifier[i];

            //rule 1
            if (c == ' ')
                sb.Append('_');
            //rule 2 
            else if (char.IsControl(c))
                sb.Append("CTRL");
            
            //4 and 5
            else if (char.IsLetter(c) && !('α' <= c && c <= 'ω'))
                sb.Append(c);

            if (isUppercase)
            {
                isUppercase = false;
                sb.Replace(c, char.ToUpperInvariant(c));
            }

            //rule 3
            else if (c == '-')
                isUppercase = true;
        }

        return sb.ToString();
    }
}