namespace Project498.WebApi.Services;

public class StringService : IStringService
{
    public string Reverse(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public string? ReverseWords(string? input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return input; // keeps null as null, keeps "   " as "   "
        }

        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}

