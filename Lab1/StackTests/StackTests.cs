using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;

namespace StackTests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void TestCreatureSize()
        {
            Stack<int> Stack = new Stack<int>();
            int ExpetctedSize = 0;

            int ActualSize = Stack.Size;

            Assert.AreEqual(ExpetctedSize, ActualSize);

        }
        [TestMethod]
        public void TestResizeWhenPush()
        {
            Stack<int> Stack = new Stack<int>();
            Stack.Push(5);
            int ExpetctedSize = 1;

            int ActualSize = Stack.Size;

            Assert.AreEqual(ExpetctedSize, ActualSize);
            
        }
        [TestMethod]
        public void TestResizeWhenPop()
        {
            Stack<int> Stack = new Stack<int>();
            Stack.Push(5);
            Stack.Push(3);
            Stack.Pop();
            int ExpetctedSize = 1;

            int ActualSize = Stack.Size;

            Assert.AreEqual(ExpetctedSize, ActualSize);

        }
        [TestMethod]
        public void TestPush()
        {
            Stack<int> Stack = new Stack<int>();
            Stack.Push(5);
            Stack.Push(3);
            int ExpetctedItem = Stack.Pop();

            int ActualItem = 3;

            Assert.AreEqual(ExpetctedItem, ActualItem);

        }
        [TestMethod]
        public void TestPop()
        {
            Stack<int> Stack = new Stack<int>();
            Stack.Push(5);
            Stack.Push(3);
            int ExpetctedItem = 3;

            int ActualItem = Stack.Pop();

            Assert.AreEqual(ExpetctedItem, ActualItem);

        }
        [TestMethod]
        public void TestSizeWhenPeek()
        {
            Stack<int> Stack = new Stack<int>();
            Stack.Push(7);
            Stack.Push(1);
            Stack.Peek();
            int ExpetctedSize = 2;

            int ActualSize = Stack.Size;

            Assert.AreEqual(ExpetctedSize, ActualSize);

        }
        [TestMethod]
        public void TestPeek()
        {
            Stack<int> Stack = new Stack<int>();
            Stack.Push(7);
            Stack.Push(1);
            int ExpetctedItem = 1;

            int ActualItem = Stack.Peek();

            Assert.AreEqual(ExpetctedItem, ActualItem);

        }
        [TestMethod]
        public void TestContainsTrue()
        {
            Stack<int> Stack = new Stack<int>();
            Stack.Push(7);
            Stack.Push(1);
            Stack.Push(3);

            bool ActualItem = Stack.Contains(1);

            Assert.IsTrue(ActualItem);

        }
        public void TestContainsFalse()
        {
            Stack<int> Stack = new Stack<int>();
            Stack.Push(7);
            Stack.Push(1);
            Stack.Push(3);

            bool ActualItem = Stack.Contains(2);

            Assert.IsFalse(ActualItem);

        }


    }
}
