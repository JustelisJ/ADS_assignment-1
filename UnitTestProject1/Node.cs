using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Node<T>
    {

        private T data { get; set; }
        private Node<T> next { get; }

        public Node(T data, Node<T> next)
        {
            this.data = data;
            this.next = next;
        }

        public Node(T data)
        {
            this.data = data;
            next = null;
        }

        public void setData(T data)
        {
            this.data = data;
        }

        public T getData()
        {
            return data;
        }

        public Node<T> getNext()
        {
            return next;
        }
    }
}
