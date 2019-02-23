// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Stack.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace DataStructures.PrimeAnagramStack
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// stack class
    /// </summary>
    public class Stack
    {
        /// <summary>
        /// The maximum size
        /// </summary>
        private int maxSize;

        /// <summary>
        /// The stack array
        /// </summary>
        private string[] stackArray;

        /// <summary>
        /// The top
        /// </summary>
        private int top;

        /// <summary>
        /// Stacks the initialize.
        /// </summary>
        /// <param name="stackSize">Size of the stack.</param>
        public void StackInitialise(int stackSize)
        {
            this.maxSize = stackSize;
            this.stackArray = new string[this.maxSize];
            this.top = -1;
        }

        /// <summary>
        /// Pushes the specified character.
        /// </summary>
        /// <param name="character">The character.</param>
        public void Push(string character)
        {
            this.top++;
            this.stackArray[this.top] = character;
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        /// <returns> returns the top element from the stack</returns>
        public string Pop()
        {
            if (this.top == 1)
            {
                return string.Empty;
            }

            this.top--;
            return this.stackArray[this.top];           
        }

        /// <summary>
        /// Peeks this instance.
        /// </summary>
        /// <returns>returns the top element</returns>
        public string Peek()
        {
            return this.stackArray[this.top];
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            return this.top == -1;
        }

        /// <summary>
        /// Determines whether this instance is full.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is full; otherwise, <c>false</c>.
        /// </returns>
        public bool IsFull()
        {
            return this.top == this.maxSize - 1;
        }
    }
}
