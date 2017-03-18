using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericQueue<T>
    {
        //Make node class
        protected class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        protected Node Head;
        protected Node Tail;
        protected int position = 0;

        public int Position
        {
            get { return position; }
        }

        //Add droid to generic queue
        public void Enqueue(T droid)
        {
            Node node = new Node();
            node.Data = droid;
            if (Head == null)
            {
                Head = node;
                Tail = node;
                Tail.Next = null;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
                Tail.Next = null;
            }
            position++;
        }

        //Remove droid from generic queue
        public T Dequeue()
        {
            T droid = Head.Data;
            Head = Head.Next;

            position--;

            return droid;
        }
    }
}
