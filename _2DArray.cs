// --------------------------------------------------------------------------------------------------------------------
// <copyright file="_2DArray.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// For printing elements from 2D Array
    /// </summary>
    public class _2DArray
    {
        /// <summary>
        /// Takes the input of number of rows and columns , and elements to be filled in.
        /// </summary>
        public static void Print2DArray()
        {
            try
            {
                int i = 0;
                int j = 0;
                int rows = 0;
                int columns = 0;
                int userNumber;
                int rowNumber = 1;
                double[,] array;

                bool rowFlag = true;
                while (rowFlag)
                {
                    Console.WriteLine("Enter the number of Rows");
                    string strRows = Console.ReadLine();

                    if (Utility.IsNumber(strRows) == true)
                    {
                        rows = Convert.ToInt32(strRows);
                        rowFlag = false;
                    }
                    else
                    {
                        Console.WriteLine("Enter only Integres");
                    }
                }

                bool columnFlag = true;
                while (columnFlag)
                {
                    Console.WriteLine("Enter the number of Columns");
                    string strColumns = Console.ReadLine();

                    if (Utility.IsNumber(strColumns) == true)
                    {
                        columns = Convert.ToInt32(strColumns);
                        columnFlag = false;
                    }
                    else
                    {
                        Console.WriteLine("Enter only Integres");
                    }
                }

                array = new double[rows, columns];

            //// iteration as many as rows
            loopagain:
                for (int q = 0; q < rows; q++)
                {
                    Console.WriteLine("Enter the elements in " + rowNumber + " row");

                    //// iteration as many as columns to fill  a single row

                    for (int time = 0; time < columns; time++)
                    {
                        string num = Console.ReadLine();
                        if (Utility.IsNumber(num) == false)
                        {
                            Console.WriteLine("You can add only Numbers");
                            rowNumber = 1;
                            goto loopagain;
                        }
                        else
                        {
                            userNumber = Convert.ToInt32(num);
                            array[i, j] = userNumber;
                            j++; ////for moving to next Column
                        }
                    }

                    j = 0; //// resetting the j(column value to 0)
                    i = i + 1;
                    rowNumber++;
                }

                PrintMatrix(array);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// Prints the matrix.
        /// </summary>
        /// <param name="array">The array</param>
        public static void PrintMatrix(double[,] array)
        {
            try
            {
                var rowCount = array.GetLength(0);
                var colCount = array.GetLength(1);
                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        Console.Write(string.Empty + array[row, col] + string.Empty);
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }
    }
}