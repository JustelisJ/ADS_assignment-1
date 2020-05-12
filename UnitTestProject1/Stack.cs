using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Stack<T>
    {

        private Node<T> topOfStackRef;

        public Stack()
        {
            topOfStackRef = null;
        }

        public void push(T data)
        {
            if (topOfStackRef == null)
            {
                Node<T> newNode = new Node<T>(data);
                topOfStackRef = newNode;
            }
            else
            {
                Node<T> newNode = new Node<T>(data, topOfStackRef);
                topOfStackRef = newNode;
            }
        }

        public T pop()
        {
            T value = topOfStackRef.getData();
            topOfStackRef = topOfStackRef.getNext();
            return value;
        }

        public bool isEmpty()
        {
            if(topOfStackRef == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T peek()
        {
            T value;
            if (topOfStackRef == null)
            {
                value = default(T);
            }
            else
            {
                value = topOfStackRef.getData();
            }
            return value;
        }

        public int size()
        {
            int i = 1;
            Node<T> node;

            if (topOfStackRef != null)
            {
                node = topOfStackRef;
            }
            else
            {
                return 0;
            }

            while (true)
            {
                if (node.getNext() != null)
                {
                    node = node.getNext();
                }
                else
                {
                    break;
                }
                i++;
            }
            return i;
        }

        public void printStack()
        {
            string wholeStack = "Stack: ";
            Node<T> node = topOfStackRef;
            while (node != null)
            {
                wholeStack += node.getData() + " ";
                node = node.getNext();
            }
            Console.WriteLine(wholeStack);
        }
    }
}
