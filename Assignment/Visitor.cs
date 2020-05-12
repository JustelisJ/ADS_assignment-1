using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Visitor
    {
        public Stack<int> stack;

        public Visitor()
        {
            stack = new Stack<int>();
        }

        public void visit(Operand operand)
        {
            pushOperand(operand);
        }

        public void visit(Operator _operator)
        {
            performOperation(_operator);
        }

        private void pushOperand(Operand operand)
        {
            stack.push(operand.getValue());
            stack.printStack();
        }

        private void performOperation(Operator _operator)
        {
            if (stack.size() >= 2)
            {
                int number2 = stack.pop();
                int number1 = stack.pop();

                if(_operator.getType() == '+')
                {
                    stack.push(number1 + number2);
                }
                if (_operator.getType() == '-')
                {
                    stack.push(number1 - number2);
                }
                if (_operator.getType() == '/')
                {
                    stack.push(number1 / number2);
                }
                if (_operator.getType() == '*')
                {
                    stack.push(number1 * number2);
                }
            }
            else
            {
                Console.WriteLine("Not enough numbers to perform an operation");
            }
            stack.printStack();
        }
    }
}
