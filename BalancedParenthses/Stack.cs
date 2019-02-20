using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.BalancedParenthses
{
    class Stack
    {
        private int maxSize;
        private char[] stackArray;
        private int top;



        public void StackInitialise(int s)
        {
            maxSize = s;
            stackArray = new char[maxSize];
            top = -1;
        }

        public void Push(char j)
        {
            stackArray[++top] = j;
        }

        public long Pop()
        {
            return stackArray[top--];
        }

        public long Peek()
        {
            return stackArray[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool isFull()
        {
            return top == maxSize - 1;
        }

    }
}
