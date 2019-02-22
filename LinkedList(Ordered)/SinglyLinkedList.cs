// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="singlyLinkedList.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace DataStructures.LinkedList_Ordered_
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Singly linked list
    /// </summary>
    /// <seealso cref="DataStructures.LinkedList_Ordered_.ILinkedList" />
    public class SinglyLinkedList : ILinkedList
    {
        /// <summary>
        /// The head
        /// </summary>
        private Node head;

        /// <summary>
        /// The last
        /// </summary>
        private Node last;

        /// <summary>
        /// The size/
        /// </summary>
        private long size = 0;

        /// <summary>
        /// Sorts the linked list.
        /// </summary>
        /// <param name="head">The head.</param>
        public static void SortLinkedList(Node head)
        {
            Node i;
            Node j;

            i = head;

            for (i = head; i.Next != null; i = i.Next)
            {
                for (j = i.Next; j != null; j = j.Next)
                {
                    if (i.Data > j.Data)
                    {
                        int temp = i.Data;
                        i.Data = j.Data;
                        j.Data = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Adds the specified number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>
        /// returns true or false
        /// </returns>
        public bool Add(int number)
        {
            Node n = new Node(number, this.size);
            this.size++;

            if (this.head == null && this.last == null)
            {
                this.head = n;
                this.last = n;
            }
            else
            {
                this.last.Next = n;
                this.last = n;
            }

            SortLinkedList(this.head);
            return true;
        }

        /// <summary>
        /// Determines whether this instance contains the object.
        /// </summary>
        /// <param name="word">The number.</param>
        /// <returns>
        /// <c>true</c> if [contains] [the specified number]; otherwise, <c>false</c>.
        /// </returns>
        public bool Contains(int word)
        {
            Node temp = this.head;

            while (temp != null)
            {
                if (temp.Data.Equals(word))
                {
                    return true;
                }

                temp = temp.Next;
            }

            return false;
        }

        /// <summary>
        /// Deletes the specified number to delete.
        /// </summary>
        /// <param name="numberToDelete">The number to delete.</param>
        /// <returns>returns true or false</returns>
        public bool Delete(int numberToDelete)
        {
            if (this.head == null)
            {
                Console.WriteLine("list is already empty");
                return false;
            }
            else
            {
                Node temp = this.head;
                Node remove = null;

                if (temp.Data.Equals(numberToDelete))
                {
                    remove = temp;
                    this.head = temp.Next;
                    return true;
                }

                for (int i = 0; i < this.size; i++)
                {
                    if (temp.Next.Data.Equals(numberToDelete))
                    {
                        remove = temp.Next;
                        temp.Next = remove.Next;
                        break;
                    }

                    temp = temp.Next;
                }

                Console.WriteLine("removed " + remove.Data);
                remove.Next = null;

                this.Reposition();

                this.size = this.size - 1;
                return true;
            }
        }

        /// <summary>
        /// Inserts the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="pos">The position.</param>
        /// <returns> returns true or false </returns>
        public bool Insert(int data, long pos)
        {
            if (pos > this.size)
            {
                Console.WriteLine("Specified position is greater than existing size");
                return false;
            }
            else
            {
                Node n = new Node(data, pos);

                Node temp = this.head;

                for (int i = 0; i < pos - 1; i++)
                {
                    temp = temp.Next;
                }

                Node n1 = temp.Next;
                temp.Next = n;
                n.Next = n1;
                temp = null;
                this.size++;
                this.Reposition();
                return true;
            }
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        /// <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            if (this.size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node temp = this.head;
                while (temp != null)
                {
                    Console.WriteLine(temp.Data + " " + temp.Position);
                    temp = temp.Next;
                }
            }
        }

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns> returns size</returns>
        public long Size()
        {
            return this.size;
        }

        /// <summary>
        /// Repositions this instance.
        /// </summary>
        public void Reposition()
        {
            Node temp = this.head;

            int i = 0;

            while (temp != null)
            {
                temp.Position = i++;
                temp = temp.Next;
            }
        }

        /// <summary>
        /// Writes to file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>returns true or false</returns>
        public bool WriteToFile(string path)
        {
            if (this.head == null)
            {
                Console.WriteLine("list is already empty");
                return false;
            }
            else
            {
                Node temp = this.head;
                using (var writer = new System.IO.StreamWriter(path))
                {
                    while (temp != null)
                    {
                        writer.Write(temp.Data.ToString().Trim() + " ");
                        temp = temp.Next;
                    }
                }
            }

            return true;
        }
    }
}
