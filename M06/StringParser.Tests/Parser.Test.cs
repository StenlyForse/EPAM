using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace StringParser.Tests
{
    [TestFixture]
    internal class Parser
    {
        private static readonly ServiceProvider? Srv = new ServiceCollection().AddLogging().BuildServiceProvider();
        private static readonly ILoggerFactory LoggerFactory = Srv.GetService<ILoggerFactory>()!;
        private ILogger<Parser> logger = LoggerFactory.CreateLogger<Parser>();

        [TestCase("12", 12)]
        [TestCase("-55", -55)]
        [TestCase("-2147483648", -2147483648)]
        [TestCase("2147483647", 2147483647)]
        public void ParserNormalWork(string str, int expected)
        {
            // Act
            StringParser.Parser par = new StringParser.Parser(logger);
            int act = par.ParseStringToInteger(str);

            // Assert
            Assert.That(act, Is.EqualTo(expected));
        }

        [Test]
        public void ParserThrowsArgumenNullException()
        {
            // Arrange
            string str = "";

            // Act
            StringParser.Parser par = new StringParser.Parser(logger);

            // Assert
            Assert.That(() => par.ParseStringToInteger(str), Throws.ArgumentNullException);
        }

        [Test]
        public void ParserThrowsFormatException()
        {
            // Arrange
            string str = "9999999999";

            // Act
            StringParser.Parser par = new StringParser.Parser(logger);
            ActualValueDelegate<object> testDelegate = () => par.ParseStringToInteger(str);

            // Assert
            Assert.That(testDelegate, Throws.TypeOf<System.FormatException>());
        }

        [Test]
        public void ParserThrowsOverflowException()
        {
            // Arrange
            string str = "5468543452345134252456";

            // Act
            StringParser.Parser par = new StringParser.Parser(logger);
            ActualValueDelegate<object> testDelegate = () => par.ParseStringToInteger(str);

            // Assert
            Assert.That(testDelegate, Throws.TypeOf<System.OverflowException>());
        }

        [Test]
        public void ParserThrowsArgumentException()
        {
            // Arrange
            string str = "abcd";

            // Act
            StringParser.Parser par = new StringParser.Parser(logger);
            ActualValueDelegate<object> testDelegate = () => par.ParseStringToInteger(str);

            // Assert
            Assert.That(testDelegate, Throws.TypeOf<System.ArgumentException>());
        }
    }
}