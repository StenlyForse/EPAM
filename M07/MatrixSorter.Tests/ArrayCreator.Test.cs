using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace MatrixSorter.Tests
{
    [TestFixture]
    internal class ArrayCreator
    {
        [Test]
        public void Input2_2_Returned2DArray()
        {
            // Arrange
            int rowsNum = 2;
            int colsNum = 2;
            int[,] actArr = M07.ArrayCreator.GenerateArray(rowsNum, colsNum);

            // Act & Assert
            Assert.That(actArr.GetLength(0), Is.EqualTo(rowsNum));
            Assert.That(actArr.GetLength(1), Is.EqualTo(colsNum));
        }

        [TestCase(-5, -5)]
        [TestCase(0, 0)]
        [TestCase(5, -5)]
        [TestCase(5, 0)]
        public void Input_NotAllowedValues_ArgumentError_Returned(int rowsNum, int colsNum)
        {
            ActualValueDelegate<object> testDelegate = () => M07.ArrayCreator.GenerateArray(rowsNum, colsNum);

            Assert.That(testDelegate, Throws.TypeOf<System.ArgumentException>());
        }
    }
}