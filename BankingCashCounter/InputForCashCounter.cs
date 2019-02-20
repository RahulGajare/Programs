using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.BankingCashCounter
{
    class InputForCashCounter
    {
        public static void Counter()
        {
            int option = 0;
            Person[] personArray;
            int personNumber = 0;

            Queue queue = new Queue();

            Console.WriteLine("Enter the Number of people in Queue");
            int numberOfPeople = Console.Read();

            personArray = new Person[numberOfPeople];

            for (int i = 0; i < numberOfPeople; i++)
            {
                Console.WriteLine("Enter the Name for the "+personNumber +  "peron");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Balance for person "+ name);
                int balance = Console.Read();

                personArray[i]  = new Person(name,balance);

            }

            for (int i = 0; i< numberOfPeople; i++)
            {
                queue.Enqueue(personArray[i]);
            }

            Console.WriteLine("All " + numberOfPeople + "Enqueued" );


            while (true)
            {
                int i = 0;
                Console.WriteLine("Person " + personArray[i]);
                Console.WriteLine("What do you want to do");
                Console.WriteLine("1) deposite");
                Console.WriteLine("2) withdraw");
                string stringOption = Console.ReadLine();

                if (utility.IsNumber(stringOption) == false)
                {
                    Console.WriteLine("Please provide Correct input");
                    continue;
                }

                option = Convert.ToInt32(stringOption);
                switch (option)
                {
                    case 1:
                        {
                            
                        }

                    case 2:
                        {
                            break;
                        }
                }

            }
           

        }
    }
}
