namespace SubstringCheck;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>() { "cat", "car", "bar", "ata", "abc" };

        var substr = "a";

        foreach (var item in list)
        {
            bool result = IsSubstring(item, substr);
            Console.WriteLine($"{item}: {result}");
        }
    }

    static bool IsSubstring(string str, string substr)
    {
        if (substr.StartsWith("*") && substr.EndsWith("*"))
        {
            string sub = substr.Trim('*');
            return str.Contains(sub);
        }
        else if (substr.StartsWith("*"))
        {
            string sub = substr.TrimStart('*');
            return str.EndsWith(sub);
        }
        else if (substr.EndsWith("*"))
        {
            string sub = substr.TrimEnd('*');
            return str.StartsWith(sub);
        }
        else
        {
            return str.Contains(substr);
        }
    }
}