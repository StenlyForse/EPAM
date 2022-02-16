namespace M03.Tests
{
    using NUnit.Framework;

    [TestFixture]
    internal class DoubleChar
    {
        [TestCase("omg i love shrek", "o kek", "oomg i loovee shreekk")]
        [TestCase("omg i love shrek", "", "omg i love shrek")]
        [TestCase("omg i love shrek", "o", "oomg i loove shrek")]
        [TestCase("omg i love shrek", "kek", "omg i lovee shreekk")]
        [TestCase("3", "3", "33")]
        [TestCase("", "d", "")]
        public void DoubleChar_Test(string orig, string plus, string expected)
        {
            // Act
            var result = M03.DoubleChar.DoubleString(orig, plus);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}