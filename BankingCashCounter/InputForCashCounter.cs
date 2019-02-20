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
            int personNumber = 1;

            Queue queue = new Queue();

            Console.WriteLine("Enter the Number of people in Queue");
            int numberOfPeople = Convert.ToInt32(Console.ReadLine());

            personArray = new Person[numberOfPeople];

            for (int i = 0; i < numberOfPeople; i++)
            {
                Console.WriteLine("Enter the Name for the "+personNumber +  " peron");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Balance for person "+ name);
                int balance = Convert.ToInt32(Console.ReadLine());
                personNumber++;

                personArray[i]  = new Person(name,balance);

            }

            for (int i = 0; i< numberOfPeople; i++)
            {
                queue.Enqueue(personArray[i]);
            }

            Console.WriteLine("All " + numberOfPeople + " people are Enqueued" );
        
            int person = 0; //// this for accessing as index for personArray.

            while (true)
            {
                
                Console.WriteLine("Person " + personArray[person].Name);
                Console.WriteLine("What do you want to do");
                Console.WriteLine("1) deposite");
                Console.WriteLine("2) withdraw");
                Console.WriteLine("3) Check the Size of queue");
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
                            TransactionInput.DepositeDetails(personArray[person]);
                            queue.Dequeue();
                            person = person + 1;
                                break;
                        }

                    case 2:
                        {
                            TransactionInput.WithdrawlDetails(personArray[person]);
                            queue.Dequeue();
                            person = person + 1;
                            break;
                        }

                    case 3:
                        {
                            int size =queue.CheckSize();
                            Console.WriteLine("There are " + size + " in queue");
                            break;
                        }
                }

            }
           

        }
    }
}
