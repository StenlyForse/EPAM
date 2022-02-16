using NUnit.Framework;

namespace M08.Tests
{
    [TestFixture]
    internal class GenericStack
    {
        [Test]
        public void GenericStack_5ItemsAdded_Count5()
        {
            // Assume
            GenericStack<int> stack = new GenericStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            int expected = 5;

            // Act
            int actual = stack.Count;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GenericStack_Push()
        {
            // Assume
            GenericStack<string> stack = new GenericStack<string>();
            stack.Push("first");
            stack.Push("second");
            stack.Push("third");
            string expected = "third";

            // Act
            string actual = stack.Pop();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}