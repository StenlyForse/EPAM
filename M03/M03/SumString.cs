namespace M03
{
    internal class SumString
    {
        private char[] number1;
        private char[] number2;

        public SumString(string num1, string num2)
        {
            if (num1.Any(x => char.IsLetter(x)) || num2.Any(x => char.IsLetter(x)))
                throw new ArgumentException("Inputed strings should contain only a numbers");
            number1 = num1.ToCharArray();
            number2 = num2.ToCharArray();
        }

        public string SumNumbers()
        {
            int low;
            int high;

            int[] num1 = Array.ConvertAll(number1, s => (int)char.GetNumericValue(s));
            int[] num2 = Array.ConvertAll(number2, s => (int)char.GetNumericValue(s));
            Array.Reverse(num1);
            Array.Reverse(num2);

            if (num1.Length <= num2.Length)
            {
                low = num1.Length;
                high = num2.Length;
            }
            else
            {
                low = num2.Length;
                high = num1.Length;
            }

            int[] sum = new int[high];
            for (int i = 0; i < low; i++)
            {
                sum[i] = num1[i] + num2[i];
                if (sum[i] >= 10 && i != sum.Length)
                {
                    sum[i] -= 10;
                    try
                    {
                        num1[i + 1] += 1;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        num2[i + 1] += 1;
                    }
                }
            }

            for (int i = low; i < high; i++)
            {
                try
                {
                    sum[i] = num1[i];
                }
                catch (IndexOutOfRangeException)
                {
                    sum[i] = num2[i];
                }
            }

            Array.Reverse(sum);
            string res = string.Join("", sum);

            return res;
        }
    }
}