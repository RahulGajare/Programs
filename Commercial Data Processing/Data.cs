using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOP.Commercial_Data_Processing
{
    class Data
    {
        public static List<CompanyShares> ReadFromFile()
        {
            if (File.Exists("C:\\Users\\Bridge labz\\Desktop\\Commersial\\CompanyShares.json"))
            {
                string jsonData = File.ReadAllText("C:\\Users\\Bridge labz\\Desktop\\Commersial\\CompanyShares.json");
                List<CompanyShares> jsonObjectArray = JsonConvert.DeserializeObject<List<CompanyShares>>(jsonData);

                return jsonObjectArray;
            }
            else
            {
                Console.WriteLine("Specified file path does not exist");
                return new List<CompanyShares>();
            }
        }

        public static void WriteToFile(List<CompanyShares> companySharesList)
        {
            string jsonData = JsonConvert.SerializeObject(companySharesList);

            Console.WriteLine("Json string Created \n" + jsonData);
            System.IO.File.WriteAllText("C:\\Users\\Bridge labz\\Desktop\\Commersial\\CompanyShares.json", jsonData);
        }
    }
}
