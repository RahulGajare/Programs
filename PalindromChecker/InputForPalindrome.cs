using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.PalindromChecker
{
    class InputForPalindrome
    {
        public static void CheckPalindrome()
        {
            Deque<char> deque = new Deque<char>();
            Console.WriteLine("Enter the String");
            string userString = Console.ReadLine();

            //// adding elements to rear
            for (int i = 0; i < userString.Length; i++)
            {
                char c = userString[i];
                deque.Addrear(c);
            }

            while (deque.Size() > 1)
            {
                if (deque.RemoveFront() != deque.RemoveRear())
                {
                    Console.WriteLine("Given String is not Palindrome");
                    return;
                }
            }

            Console.WriteLine("Given String is a Palindrome");



        }
    }
}
