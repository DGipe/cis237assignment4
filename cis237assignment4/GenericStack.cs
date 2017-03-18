using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericStack<T>
    {
        //Make node class
        protected class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        protected Node Head = null;
        protected int position = 0;

        public int Position
        {
            get { return position; }
        }

        //Add droid to generic stack
        public void Push(T droid)
        {
            Node node = new Node();
            node.Data = droid;
            node.Next = Head;
            Head = node;

            position++;
        }

        //Remove droid from generic stack
        public T Pop()
        {
            T droid = Head.Data;
            Head = Head.Next;

            position--;

            return droid;
        }
    }
}
