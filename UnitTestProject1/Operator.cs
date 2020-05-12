using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Operator : Token
    {
        private char type;

        public Operator(char type)
        {
            this.type = type;
        }

        public char getType()
        {
            return type;
        }

        public override void accept(Visitor visitor)
        {
            visitor.visit(this);
        }
    }
}
