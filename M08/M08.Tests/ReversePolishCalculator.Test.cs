using NUnit.Framework;

namespace M08.Tests
{
    [TestFixture]
    internal class ReversePolishCalculator
    {
        [Test]
        public void ReversePolishCalculator_Calculate()
        {
            // Assume
            string calc = "20 2 +";
            int expected = 22;

            // Act
            int actual = M08.ReversePolishCalculator.Calculate(calc);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ReversePolishCalculator_Calculate2()
        {
            // Assume
            string calc = "5 1 2 + 4 * + 3 -";
            int expected = 14;

            // Act
            int actual = M08.ReversePolishCalculator.Calculate(calc);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}