public static class StringExtensions
{
    public static string ToUpperFirst(
        this string value)
    {
        return char.ToUpper(value[0]) +
               value.Substring(1);
    }
}