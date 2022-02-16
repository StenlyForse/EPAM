using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;

namespace StringParser
{
    public class Parser
    {
        private readonly ILogger _logger;

        public Parser(ILogger logger)
        {
            _logger = logger;
        }

        public int ParseStringToInteger(string? str)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
            {
                _logger.LogError("String is null or empty or contains only whitespaces");
                throw new ArgumentNullException(nameof(str));
            }

            if ((str.Length > 10 && !str[0].Equals('-')) || (str.Length > 11 && str[0].Equals('-')))
            {
                _logger.LogError("String should be equals or less than 10 characters");
                throw new OverflowException(nameof(str));
            }

            var match = Regex.Match(str, @"^\-?[0-9]{1,10}$");

            if (!match.Success)
            {
                _logger.LogError("String should only contain a number");
                throw new ArgumentException(nameof(str));
            }

            return Parse(str);
        }

        private int Parse(string str)
        {
            _logger.Log(LogLevel.Debug, str);
            double num = 0;
            var isNegative = str[0].Equals('-');
            var counter = isNegative ? 1 : 0;

            for (; counter < str.Length; counter++)
            {
                int tempNum = (int)char.GetNumericValue(str[counter]);
                num += tempNum * Math.Pow(10, str.Length - counter - 1);
            }

            if (isNegative) num *= -1;

            if (num > int.MaxValue || num < int.MinValue)
            {
                _logger.LogError($"String should not be greater than max int value and less than min int value");
                throw new FormatException();
            }

            return Convert.ToInt32(num);
        }
    }
}