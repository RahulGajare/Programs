using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.BalancedParenthses
{
    class input
    {
        public static void Main()
        {
            Console.WriteLine("Enter the size of Stack");
            string stringStackSize = Console.ReadLine();

            if (utility.IsNumber(stringStackSize) == false)
            {
                Console.WriteLine("invalid number,Enter a positive Integer");
                Console.Read();
                return;
            }
            Stack stack = new Stack();

            stack.StackInitialise(Convert.ToInt32(stringStackSize));

            Console.WriteLine("Enter the Expression");
            string userExpression = Console.ReadLine();

            long expressionlength = userExpression.Length;

            for (int i = 0; i < expressionlength; i++)
            {
                char character = userExpression[i];

                if (character == '(')
                {
                    stack.Push(character);
                }
                else
                {
                    if(character == ')')
                    {
                        try
                        {
                            stack.Pop();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Experession is not Balanced Parentheses");
                            Console.Read();
                        }
                        
                    }
                }
            }

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
    }
}
