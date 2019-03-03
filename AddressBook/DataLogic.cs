// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="LoadAddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace OOP.AddressBook
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class DataLogic
    {
        public static void CreateAddressBookFile(AddressBook addressBook)
        {
            string jsonAdddressBook = JsonConvert.SerializeObject(addressBook);
            if (File.Exists("C:\\Users\\Bridge labz\\Desktop\\AddressBook\\" + addressBook.AddressBookName + ".json"))
            {
                Console.WriteLine("AddressBook with name : " + addressBook.AddressBookName + " already exist");
                return;
            }

            using (StreamWriter sw = new StreamWriter("C:\\Users\\Bridge labz\\Desktop\\AddressBook\\" + addressBook.AddressBookName + ".json"))
            {
                sw.Close();
                System.IO.File.WriteAllText("C:\\Users\\Bridge labz\\Desktop\\AddressBook\\" + addressBook.AddressBookName + ".json", jsonAdddressBook);

                Console.WriteLine("Address Book with name " + addressBook.AddressBookName + " created");
            }
        }

        public static List<string> GetAddressBookList()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("C:\\Users\\Bridge labz\\Desktop\\AddressBook");
            FileInfo[] Files = directoryInfo.GetFiles("*.json"); //Getting json files
            List<string> fileNameArray = new List<string>();
            foreach (FileInfo file in Files)
            {
                fileNameArray.Add(file.Name);
            }

            return fileNameArray;
        }


        public static AddressBook GetBookDetails(string bookname)
        {

            string jsonData = File.ReadAllText("C:\\Users\\Bridge labz\\Desktop\\AddressBook\\" + bookname + ".json");
            AddressBook addressBook = JsonConvert.DeserializeObject<AddressBook>(jsonData);

            return addressBook;


        }

        public static void WriteAddressBookToFile(AddressBook addressBook)
        {
            string jsonAdddressBook = JsonConvert.SerializeObject(addressBook);
            System.IO.File.WriteAllText("C:\\Users\\Bridge labz\\Desktop\\AddressBook\\" + addressBook.AddressBookName + ".json", jsonAdddressBook);
        }
    }
}
