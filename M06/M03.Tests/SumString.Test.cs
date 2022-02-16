using NUnit.Framework;

namespace M03.Tests
{
    [TestFixture]
    internal class SumString
    {
        [Test]
        public void SumString_215and20Inserted_235Returned()
        {
            // Arrange
            string num1 = "215";
            string num2 = "20";
            string expected = "235";

            // Act
            var sumString = new M03.SumString(num1, num2);
            string actual = sumString.SumNumbers();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("200", "500", "700")]
        [TestCase("", "", "")]
        public void SumString_Test(string num1, string num2, string expected)
        {
            // Act
            var sumString = new M03.SumString(num1, num2);
            string actual = sumString.SumNumbers();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        public void SumString_ThrowsArgumentException()
        {
            // Arrange
            string num1 = "ab";
            string num2 = "ad";

            // Act
            var sumString = new M03.SumString(num1, num2);

            // Assert
            Assert.That(() => sumString.SumNumbers(), Throws.ArgumentException);
        }
    }
}