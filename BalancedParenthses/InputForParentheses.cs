// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InputForParentheses.cs" company="Bridgelabz">
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
    /// Takes required input To Check Parentheses
    /// </summary>
    public class InputForParentheses
    {
        /// <summary>
        /// Checks the parentheses.
        /// </summary>
        public static void CheckParentheses()
        {
            string userExpression = string.Empty;

            try
            {
                ////Console.WriteLine("Enter the size of Stack");
                ////string stringStackSize = Console.ReadLine();

                ////if (Utility.IsNumber(stringStackSize) == false)
                ////{
                ////    Console.WriteLine("invalid number,Enter a positive Integer");
                ////    Console.Read();
                ////    return;
                ////}

                Stack stack = new Stack();

                stack.StackInitialise(Convert.ToInt32(150));

                ////keep asking until valid expression is given
                bool loopForExpression = true;
                {
                    while (loopForExpression)
                    {
                        Console.WriteLine("Enter the Expression");
                        userExpression = Console.ReadLine();

                        if (Utility.CheckString(userExpression))
                        {
                            Console.WriteLine("invlaid Expression");
                            continue;
                        }
                    }

                    loopForExpression = false;                 
                }
              
                long expressionlength = userExpression.Length;

                ////loop our each letter in the expression 
                for (int i = 0; i < expressionlength; i++)
                {
                    char character = userExpression[i];
                    if (character == '(')
                    {
                        stack.Push(character);
                    }
                    else
                    {
                        if (character == ')')
                        {
                            try
                            {
                                stack.Pop();
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Experession is  Balanced Parentheses");
                                Console.Read();
                            }
                        }
                    }
                }

                ////if Stack is Empty ,it Means the Expression is Balanced
                if (stack.IsEmpty())
                {
                    Console.WriteLine("Experession have Balanced Parentheses");
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("Experession is not Balanced Parentheses");
                    Console.Read();
                }
            }
            catch (Exception ex)
            {
               throw new Exception(ex.Message);
            }         
        }
    }
}
