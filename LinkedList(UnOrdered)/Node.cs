

namespace DataStructures.LinkedList_UnOrdered_
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Node<T>
    {
        private Node<T> next;
        private T data;
        private long position;


        public Node(T data, long position)
        {
            this.position = position;
            this.data = data;
        }

        public Node<T> Next
        {
            get { return next; }
            set { this.next = value; }
        }
       
        public long Position
        {
            get { return position; }
            set { this.position = value; }
        }

        public T Data
        {
            get { return data;}
            set { this.data = value; }
        }
    }
}
