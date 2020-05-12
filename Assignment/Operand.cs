using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Operand : Token
    {
        private int value;

        public Operand(int value)
        {
            this.value = value;
        }

        public int getValue()
        {
            return value;
        }

        public override void accept(Visitor visitor)
        {
            visitor.visit(this);
        }
    }
}
