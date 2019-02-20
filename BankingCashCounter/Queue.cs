using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.BankingCashCounter
{
    class Queue
    {
        int queueMaxSixe = 500;
        int front = -1;
        int rear = -1;
        Person[] queueArray = new Person[1000];
        int size;

        public bool Enqueue(Person data)
        {
            if (rear == queueMaxSixe - 1)
            {
                Console.WriteLine("Queue Overflow");
                return false;
                Console.Read();
            }
            else
            {
                if (front == -1)
                {
                    front = 0;
                }
                rear++;
                queueArray[rear] = data;
                size++;
                return true;
            }
        }

        public bool Dequeue()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Queue Underflow");
                return false;
            }
            else
            {
                Console.WriteLine(queueArray[front].Name + "removed from queue");
                Console.WriteLine("remaining Balance = "+ queueArray[front].Balance);
                front++;
                size--;
                return true;
            }

        }

        public  void ShowElements()
        {
            if (front == -1)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(queueArray[i]);
                }
            }
        }

        public int CheckSize()
        {
            return size;
        }
    }
}
