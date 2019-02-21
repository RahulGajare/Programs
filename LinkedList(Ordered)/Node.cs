// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Node.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

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

        /// <summary>
        /// Gets or sets the next.
        /// </summary>
        /// <value>
        /// The next.
        /// </value>
        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public long Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public int Data
        {
            get { return this.data;}
            set { this.data = value; }
        }
    }
}
