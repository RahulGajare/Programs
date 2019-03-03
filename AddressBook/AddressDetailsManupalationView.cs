using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.AddressBook
{
    class AddressDetailsManupalationView
    {
        public static void EditDetails(string bookName)
        {
            int option = 0;
            string nameToEdit = string.Empty;
            
            Console.WriteLine("Enter the First Name you want to edit");
            nameToEdit = Console.ReadLine();

            if (AddressDetails.DoesNameExist(nameToEdit,bookName) == false)
            {
                Console.WriteLine("The Name You Entered Does not Exist");
                return;
            }
            Console.WriteLine("------------------------------------------");
            AddressBook.PrintSingleAddresss(bookName, nameToEdit);
            Console.WriteLine("------------------------------------------");

            while (true)
            {
                Console.WriteLine("Choose what you want to edit");
                Console.WriteLine("0) To Go back");
                Console.WriteLine("1) Address");
                Console.WriteLine("2) City");
                Console.WriteLine("3) State");
                Console.WriteLine("4) Zip");
                Console.WriteLine("5) PhoneNumber");
               string stringOption = Console.ReadLine();

                if (Utility.IsNumber(stringOption) == false)
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }

               
                option = Convert.ToInt32(stringOption);

                switch(option)
                {
                    case 0:
                        {
                            return;
                        }
                    case 1:
                        {
                            AddressDetailsManupalation.ChangeAddress(bookName,nameToEdit);
                            break;
                        }

                    case 2:
                        {
                            AddressDetailsManupalation.ChangeCity(bookName, nameToEdit);
                            break;
                        }

                    case 3:
                        {
                            AddressDetailsManupalation.ChangeState(bookName, nameToEdit);
                            break;
                        }

                    case 4:
                        {
                            AddressDetailsManupalation.ChangeZip(bookName, nameToEdit);
                            break;
                        }

                    case 5:
                        {
                            AddressDetailsManupalation.ChangePhoneNumber(bookName, nameToEdit);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid Input");
                            break;
                        }
                }
            }


        }
    }
}
