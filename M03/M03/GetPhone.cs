namespace M03
{
    using System.Text.RegularExpressions;

    internal class GetPhone
    {
        public static List<string> GetPhoneNumber(string txtInput, string txtOutput)
        {
            string text = File.ReadAllText(Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName + "\\" + txtInput);

            Regex reg = new Regex(@"\+?([0-9]{1,3})\s\(?([0-9]{2,3})\)?\s([0-9]{3})\-([0-9]{2}|[0-9]{4})\-?([0-9]{2})?", RegexOptions.Multiline);
            MatchCollection rere = reg.Matches(text);
            List<string> lst = new List<string>();
            foreach (Match match in rere)
                lst.Add(match.Value);

            File.WriteAllLines(Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName + "\\" + txtOutput, lst);

            return lst;
        }
    }
}