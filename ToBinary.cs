
namespace Algorithms
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ToBinary
    {
        public static void ConvertToBinary()
        {
            ArrayList binaryArrayList = new ArrayList();
            int[] binaryArray = new ;


            int userNumber;
            bool loopNumber = true;

            while (loopNumber)
            {
                Console.WriteLine("Enter the Number");
                string stringUserNumber = Console.ReadLine();

                if (Utility.IsNumber(stringUserNumber) == false)
                {
                    Console.WriteLine("Enter a valid Positive Integer");
                    continue;
                }

                    userNumber = Convert.ToInt32(stringUserNumber);

                while (userNumber > 0)
                {
                    binaryArrayList.Add(userNumber%2);
                    userNumber = userNumber / 2;
                }

                Array
                


            }
        }

    }
}
