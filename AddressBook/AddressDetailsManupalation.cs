using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace OOP.AddressBook
{
    class AddressDetailsManupalation
    {

        public static void ChangeAddress(string bookName,string nameToEdit)
        {
            while (true)
            {
                Console.WriteLine("Enter the New Address");
                string address = Console.ReadLine();

                if (Utility.CheckString(address))
                {
                    Console.WriteLine("Address Cant be Empty");
                    continue;
                }

                AddressBook addressBook = DataLogic.GetBookDetails(bookName);

                List<AddressDetails> list = addressBook.AddressDetailsList;

                foreach (AddressDetails addressDetail in list)
                {
                    if (addressDetail.FirstName.Equals(nameToEdit))
                    {
                        addressDetail.Address = address;
                        break;
                  
                    }
                }

                DataLogic.WriteAddressBookToFile(addressBook);
                Console.WriteLine("Successfully updated");

                break;
            }


        }

        public static void ChangeCity(string bookName,string nameToEdit)
        {
            while (true)
            {
                Console.WriteLine("Enter the New City");
                string city = Console.ReadLine();

                if (!Regex.IsMatch(city, "^[a-zA-z]+$"))
                {
                    Console.WriteLine("Wrong input,(Characters,number not allowed)");
                    continue;
                }

                AddressBook addressBook = DataLogic.GetBookDetails(bookName);

                List<AddressDetails> list = addressBook.AddressDetailsList;

                foreach (AddressDetails addressDetail in list)
                {
                    if (addressDetail.FirstName.Equals(nameToEdit))
                    {
                        addressDetail.City = city;
                        break;
                    }
                }

                DataLogic.WriteAddressBookToFile(addressBook);
                Console.WriteLine("Successfully updated");
                break;
            }
        }

        public static void ChangeState(string bookName, string nameToEdit)
        {
            while (true)
            {
                Console.WriteLine("Enter the New State");
                string state = Console.ReadLine();

                if (!Regex.IsMatch(state, "^[a-zA-z]+$"))
                {
                    Console.WriteLine("Wrong input,(Characters,number not allowed)");
                    continue;
                }

                AddressBook addressBook = DataLogic.GetBookDetails(bookName);

                List<AddressDetails> list = addressBook.AddressDetailsList;

                foreach (AddressDetails addressDetail in list)
                {
                    if (addressDetail.FirstName.Equals(nameToEdit))
                    {
                        addressDetail.State = state;
                        break;
                    }
                }

                DataLogic.WriteAddressBookToFile(addressBook);
                Console.WriteLine("Successfully updated");
                break;
            }
        }

        public static void ChangeZip(string bookName, string nameToEdit)
        {
            while (true)
            {
                Console.WriteLine("Enter the New Zip");
                string zip = Console.ReadLine();

                if (!Regex.IsMatch(zip, "^[0-9]+$"))
                {
                    Console.WriteLine("Wrong input,(Characters not allowed)");
                    continue;
                }

                AddressBook addressBook = DataLogic.GetBookDetails(bookName);

                List<AddressDetails> list = addressBook.AddressDetailsList;

                foreach (AddressDetails addressDetail in list)
                {
                    if (addressDetail.FirstName.Equals(nameToEdit))
                    {
                        addressDetail.Zip = zip;
                        break;
                    }
                }

                DataLogic.WriteAddressBookToFile(addressBook);
                Console.WriteLine("Successfully updated");
                break;
            }
        }

        public static void ChangePhoneNumber(string bookName, string nameToEdit)
        {
            while (true)
            {
                Console.WriteLine("Enter the New phoneNumber");
                string phoneNumber = Console.ReadLine();

                if (!Regex.IsMatch(phoneNumber, "^[0-9]{10}$"))
                {
                    Console.WriteLine("Wrong input,(Characters,number not allowed)");
                    continue;
                }

                AddressBook addressBook = DataLogic.GetBookDetails(bookName);

                List<AddressDetails> list = addressBook.AddressDetailsList;

                foreach (AddressDetails addressDetail in list)
                {
                    if (addressDetail.FirstName.Equals(nameToEdit))
                    {
                        addressDetail.PhoneNumber = phoneNumber;
                        break;
                    }
                }

                DataLogic.WriteAddressBookToFile(addressBook);
                Console.WriteLine("Successfully updated");
                break;
            }
        }

        public static void SortByLastName(string bookName)
        {
            AddressBook addressBook = DataLogic.GetBookDetails(bookName);

            List<AddressDetails> list = addressBook.AddressDetailsList;

            var sortedList = list.OrderBy(v => v.LastName);

            foreach (AddressDetails address in sortedList)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine(address.ToString());
                Console.WriteLine("----------------------------");
            }
        }

        public static void SortByZip(string bookName)
        {
            AddressBook addressBook = DataLogic.GetBookDetails(bookName);

            List<AddressDetails> list = addressBook.AddressDetailsList;

            var sortedList = list.OrderBy(v => v.Zip);

            foreach (AddressDetails address in sortedList)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine(address.ToString());
                Console.WriteLine("----------------------------");
            }
        }



    }
}
