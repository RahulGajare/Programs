// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Stack.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace DataStructures.BalancedParenthses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// stack
    /// </summary>
    public class Stack
    {
        private int maxSize;
        private char[] stackArray;
        private int top;


        /// <summary>
        /// Stacks the initialise.
        /// </summary>
        /// <param name="stackSize">Size of the stack.</param>
        public void StackInitialise(int stackSize)
        {
            maxSize = stackSize;
            stackArray = new char[maxSize];
            top = -1;
        }

        public void Push(char character)
        {
            top++;
            stackArray[top] = character;
        }

        public long Pop()
        {
            top--;
            return stackArray[top];
            
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
