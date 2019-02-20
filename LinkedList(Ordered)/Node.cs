

namespace DataStructures.LinkedList_Ordered_
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Node
    {
        private Node next;
        private int data;
        private long position;


        public Node(int data, long position)
        {
            this.position = position;
            this.data = data;
        }

        public Node Next
        {
            get { return next; }
            set { this.next = value; }
        }

        public long Position
        {
            get { return position; }
            set { this.position = value; }
        }

        public int Data
        {
            get { return data;}
            set { this.data = value; }
        }
    }
}
