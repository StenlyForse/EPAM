using System.Linq;
using NUnit.Framework;

namespace M08.Tests
{
    [TestFixture]
    internal class GenericQueue
    {
        [Test]
        public void GenericQueue_Dequeue()
        {
            // Assume
            GenericQueue<string> queue = new GenericQueue<string>();
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            string expected = "a";

            // Act
            string actual = queue.Dequeue();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GenericQueue_Throws_InvalidOperationException()
        {
            // Assume
            GenericQueue<string> queue = new GenericQueue<string>();

            // Act

            // Assert
            Assert.That(() => queue.Dequeue(), Throws.InvalidOperationException);
        }

        [Test]
        public void GenericQueue_Added6_Dequeued1_Items_Count5()
        {
            // Assume
            GenericQueue<bool> queue = new GenericQueue<bool>();
            queue.Enqueue(true);
            queue.Enqueue(false);
            queue.Enqueue(true);
            queue.Enqueue(false);
            queue.Enqueue(false);
            queue.Enqueue(true);
            queue.Dequeue();
            int expected = 5;

            // Act
            int actual = queue.Count();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}