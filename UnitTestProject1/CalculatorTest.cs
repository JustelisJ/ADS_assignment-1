using Assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    class CalculatorTest
    {
        Stack<int> stack;
        Token operand1;
        Token operand2;
        Visitor visitor;

        [TestInitialize]
        public void TestInitialize()
        {
            stack = new Stack<int>();
            operand1 = new Operand(6);
            operand2 = new Operand(2);
            visitor = new Visitor();

            operand1.accept(visitor);
            operand2.accept(visitor);
        }

        [TestMethod]
        public void addition()
        {
            Token operation = new Operator('+');
            operation.accept(visitor);
            Assert.AreEqual(8, visitor.stack.pop());
        }

        [TestMethod]
        public void subtraction()
        {
            Token operation = new Operator('-');
            operation.accept(visitor);
            Assert.AreEqual(4, visitor.stack.pop());
        }

        [TestMethod]
        public void multiplication()
        {
            Token operation = new Operator('*');
            operation.accept(visitor);
            Assert.AreEqual(12, visitor.stack.pop());
        }

        [TestMethod]
        public void division()
        {
            Token operation = new Operator('/');
            operation.accept(visitor);
            Assert.AreEqual(3, visitor.stack.pop());
        }
    }
}
