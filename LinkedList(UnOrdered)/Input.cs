using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructures.LinkedList_UnOrdered_
{
    public class Input
    {
        public static void UnOrderedList()
        {
            string path =string.Empty;
            SinglyLinkedList<String> singlyLinkedList = new SinglyLinkedList<String>();

            bool loopPath = true;
            while (loopPath)
            {
                Console.WriteLine("Specify the path");
                 path = Console.ReadLine();

                if (File.Exists(path) == false)
                {
                    Console.WriteLine("Specified Path does not exist");
                    Console.Read();
                    continue;
                }

                loopPath = false;
            }
          

            string dataFromFile = System.IO.File.ReadAllText(path);
            String[] splitArray = dataFromFile.Split(" ");

            foreach (string word in splitArray)
            {               
                    singlyLinkedList.Add(word.Trim());             
            }

            Console.WriteLine("Enter the word you want to search");
            string wordToSearch = Console.ReadLine();

            if (singlyLinkedList.Contains(wordToSearch))
            {
                if (singlyLinkedList.Delete(wordToSearch))
                {
                    Console.WriteLine("Word " + wordToSearch + " has been removed ");
                    
                }
            }
            else
            {
                singlyLinkedList.Add(wordToSearch);
                Console.WriteLine("The word " + wordToSearch + " not found , Added to linked list and written to file");
            }

            singlyLinkedList.WriteToFile(path);
            Console.Read();
        }

       
    }
}
