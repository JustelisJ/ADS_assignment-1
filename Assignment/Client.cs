using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Client
    {
        Visitor visitor;

        public Client()
        {
            visitor = new Visitor();
        }

        public void useToken(string input)
        {
            Token token = null;
            try
            {
                int num = Int32.Parse(input);
                token = new Operand(num);
            }
            catch { }
            if (input.Equals("+"))
            {
                token = new Operator('+');
            }
            //-
            if (input.Equals("-"))
            {
                token = new Operator('-');
            }
            // /
            if (input.Equals("/"))
            {
                token = new Operator('/');
            }
            //*
            if(input.Equals("*"))
            {
                token = new Operator('*');
            }
           
            if(token != null)
            {
                token.accept(visitor);
            }
            else
                Console.WriteLine("Invalid character");
        }
    }
}
