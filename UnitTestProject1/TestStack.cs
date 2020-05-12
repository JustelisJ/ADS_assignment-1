using Assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class TestStack
    {
        Stack<int> stack;

        [TestInitialize]
        public void TestInitialize()
        {
            stack = new Stack<int>();
        }

        //Push
        [TestMethod]
        public void pushToStack()
        {
            stack.push(4);
            Assert.AreEqual(1, stack.size());
        }

        //Pop
        [TestMethod]
        public void popFromStack()
        {
            stack.push(4);
            stack.push(5);
            Assert.AreEqual(5, stack.pop());
        }

        [TestMethod]
        public void popFromEmptyStack()
        {
            Exception ex = null;
            try
            {
                stack.pop();
            }
            catch(Exception e)
            {
                ex = e;
            }
            Assert.IsNotNull(ex);
        }

        //IsEmpty
        [TestMethod]
        public void isEmptyTest1()
        {
            Assert.IsTrue(stack.isEmpty());
        }

        [TestMethod]
        public void isEmptyTest2()
        {
            stack.push(1);
            Assert.IsFalse(stack.isEmpty());
        }

        //Peek
        [TestMethod]
        public void peekTest()
        {
            stack.push(1);
            Assert.AreEqual(1, stack.peek());
        }

        [TestMethod]
        public void peekAtEmptyTest()
        {
            Assert.IsNull(stack.peek());
        }

        //Size
        [TestMethod]
        public void sizeTestWithOne()
        {
            stack.push(4);
            Assert.AreEqual(1, stack.size());
        }

        [TestMethod]
        public void sizeTestWithMany()
        {
            stack.push(4);
            stack.push(4);
            stack.push(4);
            Assert.AreEqual(3, stack.size());
        }

        [TestMethod]
        public void emptySizeTest()
        {
            Assert.AreEqual(0, stack.size());
        }
    }
}
