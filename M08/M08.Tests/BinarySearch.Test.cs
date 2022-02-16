using NUnit.Framework;

namespace M08.Tests
{
    [TestFixture]
    internal class BinarySearch
    {
        [Test]
        public void BinarySearch_Array_3Inputed_TrueReturned()
        {
            // Assume
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int value = 3;
            bool expected = true;

            // Act
            bool actual = M08.BinarySearch.DoSearch(arr, value);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void BinarySearch_Array_50Inputed_FalseReturned()
        {
            // Assume
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int value = 50;
            bool expected = false;

            // Act
            bool actual = M08.BinarySearch.DoSearch(arr, value);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void BinarySearch_ArrayOfOneElem_3Inputed_TrueReturned()
        {
            // Assume
            int[] arr = { 3 };
            int value = 3;
            bool expected = true;

            // Act
            bool actual = M08.BinarySearch.DoSearch(arr, value);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void BinarySearch_ArrayOfOneElem_3Inputed_FalseReturned()
        {
            // Assume
            int[] arr = { 5 };
            int value = 3;
            bool expected = false;

            // Act
            bool actual = M08.BinarySearch.DoSearch(arr, value);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void BinarySearch_Array_EmptyArrayInputed_NotFoundReturned()
        {
            // Assume
            int[] arr = { };
            int value = 3;

            // Act & Assert
            Assert.That(() => M08.BinarySearch.DoSearch(arr, value), Throws.ArgumentNullException);
        }
    }
}