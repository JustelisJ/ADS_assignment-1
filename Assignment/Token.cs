using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    abstract class Token
    {
        private Visitor visitor;

        public abstract void accept(Visitor visitor);
       
    }
}
