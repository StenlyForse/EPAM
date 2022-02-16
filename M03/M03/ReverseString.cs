namespace M03
{
    internal class ReverseString
    {
        public static string ReverseWords(string origString)
        {
            string[] temp = origString.Split(' ', StringSplitOptions.None);
            Array.Reverse(temp);
            return string.Join(" ", temp);
        }
    }
}