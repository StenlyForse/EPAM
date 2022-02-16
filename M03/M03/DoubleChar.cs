namespace M03
{
    using System.Text;

    internal class DoubleChar
    {
        public static string DoubleString(string origStr, string plusStr)
        {
            StringBuilder sb = new StringBuilder();
            var HashSet = new HashSet<char>(plusStr);

            foreach (var symb in origStr)
            {
                if (HashSet.Contains(symb) && !char.IsWhiteSpace(symb))
                {
                    sb.Append(symb);
                    sb.Append(symb);
                }
                else
                {
                    sb.Append(symb);
                }
            }

            return sb.ToString();
        }
    }
}