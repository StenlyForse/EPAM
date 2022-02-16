namespace M03
{
    using System.Text;

    internal class AvgWordLen
    {
        public static double AverageLength(string str)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Inputed string: " + str);
            foreach (char c in str)
            {
                if (char.IsLetter(c) || char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                }
            }

            str = sb.ToString();
            double spacesCount = str.Count(char.IsWhiteSpace);
            double wordCount = str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            if (wordCount == 0)
                throw new ArgumentException("String does not contain letters");
            return (str.Length - spacesCount) / wordCount;
        }
    }
}