namespace M03.Tests
{
    using NUnit.Framework;

    [TestFixture]
    internal class ReverseString
    {
        [TestCase("The greatest victory is that which requires no battle", "battle no requires which that is victory greatest The")]
        [TestCase("111 222 333", "333 222 111")]
        [TestCase("First second  third", "third  second First")]
        [TestCase("Вау это что русский язык", "язык русский что это Вау")]
        [TestCase("落花有意 流水無情", "流水無情 落花有意")]
        public void ReverseString_Test(string input, string expected)
        {
            // Act
            string actual = M03.ReverseString.ReverseWords(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}