using System.Collections.Generic;
using NUnit.Framework;

namespace M08.Tests
{
    [TestFixture]
    internal class FibonacciNumber
    {
        [Test]
        public void FibonacciNumber_5Inputed_SequenceReturned()
        {
            // Assume
            int position = 5;
            IEnumerable<int> seq = new List<int>() { 0, 1, 1, 2, 3 };

            // Act
            var actual = M08.FibonacciNumber.GenerateFibonacci(position);

            // Assert
            Assert.That(actual, Is.EqualTo(seq));
        }
    }
}