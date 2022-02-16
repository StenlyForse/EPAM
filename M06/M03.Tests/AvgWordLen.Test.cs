using NUnit.Framework;

namespace M03.Tests
{
    [TestFixture]
    internal class AvgWordLen
    {
        [Test]
        public void AverageLength_3wordsBy3_3Returned()
        {
            // Arrange
            string str = "abc abc abc";
            int expected = 3;

            // Act
            double actual = M03.AvgWordLen.AverageLength(str);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AverageLength_IntegerString_ThrowsException()
        {
            // Arrange
            string str = "333 333 333";

            // Act

            // Assert
            Assert.That(() => M03.AvgWordLen.AverageLength(str), Throws.ArgumentException);
        }
    }
}