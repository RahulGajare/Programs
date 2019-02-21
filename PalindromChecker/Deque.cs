using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.PalindromChecker
{
    class Deque<T>
    {
        DequeNode<T> front;
        DequeNode<T> rear;
        long size = 0;

        public void AddFront(T data)
        {
            if (front == null)
            {
                front.Data = data;
                rear = front;
            }
            else
            {
                DequeNode<T> tempNode = null;
                tempNode.Data = data;
                tempNode.Next = front;
                front.Pre = tempNode;
                front = tempNode;
            }
            size++;
        }

        public void Addrear(T data)
        {
            if (front == null)
            {
                DequeNode<T> dequeNode = new DequeNode<T>(data);
                front = dequeNode;
                rear = front;
            }
            else
            {
                DequeNode<T> dequeNode = new DequeNode<T>(data);
                rear.Next = dequeNode;
                dequeNode.Pre = rear;
                rear = dequeNode;
            }
            size++;
        }

        public T RemoveFront()
        {
            T dataToRemove = default(T);
            if (front == null)
            {
                Console.WriteLine("Allready empty, nothing to delete");
            }
            else
            {
                dataToRemove = front.Data;
                front = front.Next;

            }
            size--;
            return dataToRemove;

        }
        public T RemoveRear()
        {
            T dataToRemove = default(T);
            if (front == null)
            {
                Console.WriteLine("Allready empty, nothing to delete");
            }
            else
            {
                 dataToRemove = rear.Data;
                rear = rear.Pre;
                rear.Next = null;
            }
            size--;
            return dataToRemove;
        }

        public bool IsEmpty()
        {
            if (front == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long Size()
        {
            return size;
        }

    }
}
