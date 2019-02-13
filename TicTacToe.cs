// -----------------------------------------------------------------------------------------------------------------------
// <copyright file="TicTacToe.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// ----------------------------------------------------------------------------------------------------------------------------

namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Simulates a TicTacToe game
    /// </summary>
    public class TicTacToe
    {
        /// <summary>
        /// Starts the tic tac toe.
        /// </summary>
        public static void StartTicTacToe()
        {
            bool flag = true;

            //// creating a Display game board using 2d Array
            char[,] gameBoard = new char[,]
            {
            { '-', '-', '-' },
            { '-', '-', '-' },
            { '-', '-', '-' }
            };

            Console.WriteLine("====================================================================================================");
            Display(gameBoard);
            Console.WriteLine("====================================================================================================");

            ////keeps looping untill Correct command "GO" is given.
            while (flag)
            {
                Console.WriteLine("Enter GO to start game");
                string go = Console.ReadLine();
                if (!go.Equals("GO"))
                {
                    Console.WriteLine("Invalid Command");
                }
                else
                {
                    ////if command is correct(GO);
                    Console.WriteLine(" You are X. \n Computer is O.");

                    flag = false;
                }
            }

            ////first played by Computer
            Console.WriteLine("====================================================================================================");
            Display(gameBoard);

            Console.WriteLine("====================================================================================================");
            for (int i = 0; i < 5; i++)
            {
                PlayComputer(gameBoard);
                Display(gameBoard);
                Console.WriteLine("====================================================================================================");

                if (CheckWinner(gameBoard).Equals("HUMANWIN"))
                {
                    Console.WriteLine("Congrtas you won");
                    return;
                }

                if (CheckWinner(gameBoard).Equals("COMPUTERWIN"))
                {
                    Console.WriteLine("You Lose. ");
                    return;
                }

                //// This will break the loop and after the last slot by computer is played and doesnot allow to play further for human.
                if (i == 4)
                {
                    break;
                }

                PlayHuman(gameBoard);

                Display(gameBoard);
                Console.WriteLine("====================================================================================================");
                if (CheckWinner(gameBoard).Equals("HUMANWIN"))
                {
                    Console.WriteLine("Congrtas you won");
                    return;
                }

                if (CheckWinner(gameBoard).Equals("COMPUTERWIN"))
                {
                    Console.WriteLine("You Loose ");
                    return;
                }
            }

            ////If the control comes outside the for loop ,it means Draw
            if (CheckWinner(gameBoard).Equals("DRAW"))
            {
                Console.WriteLine("Its a Draw ");
                return;
            }

            return;
        }

        /// <summary>
        /// Displays the specified game board.
        /// </summary>
        /// <param name="gameBoard">The game board.</param>
        public static void Display(char[,] gameBoard)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(gameBoard[i, j]);
                    Console.Write("  ");
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Generates the random.
        /// </summary>
        /// <returns>Random integer </returns>
        public static int GenerateRandom()
        {
            Random r = new Random();
            return r.Next(1, 10);
        }

        /// <summary>
        /// Fills the board. Takes the position and fills the game board according to the position in matrix
        /// also takes a string if its "PLAYER" or "COMPUTER" turn.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="gameBoard">The game board.</param>
        /// <param name="player">The player.</param>
        public static void FillBoard(int position, char[,] gameBoard, string player)
        {
            if (player.Equals("PLAYER"))
            {
                if (position == 1)
                {
                    if (gameBoard[0, 0] == '-')
                    {
                        gameBoard[0, 0] = 'X';
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Cell already occupied");
                        PlayHuman(gameBoard);
                    }
                }

                if (position == 2)
                {
                    if (gameBoard[0, 1] == '-')
                    {
                        gameBoard[0, 1] = 'X';
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Cell already occupied");
                        PlayHuman(gameBoard);
                    }
                }

                if (position == 3)
                {
                    if (gameBoard[0, 2] == '-')
                    {
                        gameBoard[0, 2] = 'X';
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Cell already occupied");
                        PlayHuman(gameBoard);
                    }
                }

                if (position == 4)
                {
                    if (gameBoard[1, 0] == '-')
                    {
                        gameBoard[1, 0] = 'X';
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Cell already occupied");
                        PlayHuman(gameBoard);
                    }
                }

                if (position == 5)
                {
                    if (gameBoard[1, 1] == '-')
                    {
                        gameBoard[1, 1] = 'X';
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Cell already occupied");
                        PlayHuman(gameBoard);
                    }
                }

                if (position == 6)
                {
                    if (gameBoard[1, 2] == '-')
                    {
                        gameBoard[1, 2] = 'X';
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Cell already occupied");
                        PlayHuman(gameBoard);
                    }
                }

                if (position == 7)
                {
                    if (gameBoard[2, 0] == '-')
                    {
                        gameBoard[2, 0] = 'X';
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Cell already occupied");
                        PlayHuman(gameBoard);
                    }
                }

                if (position == 8)
                {
                    if (gameBoard[2, 1] == '-')
                    {
                        gameBoard[2, 1] = 'X';
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Cell already occupied");
                        PlayHuman(gameBoard);
                    }
                }

                if (position == 9)
                {
                    if (gameBoard[2, 2] == '-')
                    {
                        gameBoard[2, 2] = 'X';
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Cell already occupied");
                        PlayHuman(gameBoard);
                    }
                }
            }

            if (player.Equals("COMPUTER"))
            {
                if (position == 1)
                {
                    if (gameBoard[0, 0] == '-')
                    {
                        gameBoard[0, 0] = 'O';
                        return;
                    }
                    else
                    {
                        FillBoard(GenerateRandom(), gameBoard, "COMPUTER");
                    }
                }

                if (position == 2)
                {
                    if (gameBoard[0, 1] == '-')
                    {
                        gameBoard[0, 1] = 'O';
                        return;
                    }
                    else
                    {
                        FillBoard(GenerateRandom(), gameBoard, "COMPUTER");
                    }
                }

                if (position == 3)
                {
                    if (gameBoard[0, 2] == '-')
                    {
                        gameBoard[0, 2] = 'O';
                        return;
                    }
                    else
                    {
                        FillBoard(GenerateRandom(), gameBoard, "COMPUTER");
                    }
                }

                if (position == 4)
                {
                    if (gameBoard[1, 0] == '-')
                    {
                        gameBoard[1, 0] = 'O';
                        return;
                    }
                    else
                    {
                        FillBoard(GenerateRandom(), gameBoard, "COMPUTER");
                    }
                }

                if (position == 5)
                {
                    if (gameBoard[1, 1] == '-')
                    {
                        gameBoard[1, 1] = 'O';
                        return;
                    }
                    else
                    {
                        FillBoard(GenerateRandom(), gameBoard, "COMPUTER");
                    }
                }

                if (position == 6)
                {
                    if (gameBoard[1, 2] == '-')
                    {
                        gameBoard[1, 2] = 'O';
                        return;
                    }
                    else
                    {
                        FillBoard(GenerateRandom(), gameBoard, "COMPUTER");
                    }
                }

                if (position == 7)
                {
                    if (gameBoard[2, 0] == '-')
                    {
                        gameBoard[2, 0] = 'O';
                        return;
                    }
                    else
                    {
                        FillBoard(GenerateRandom(), gameBoard, "COMPUTER");
                    }
                }

                if (position == 8)
                {
                    if (gameBoard[2, 1] == '-')
                    {
                        gameBoard[2, 1] = 'O';
                        return;
                    }
                    else
                    {
                        FillBoard(GenerateRandom(), gameBoard, "COMPUTER");
                    }
                }

                if (position == 9)
                {
                    if (gameBoard[2, 2] == '-')
                    {
                        gameBoard[2, 2] = 'O';
                        return;
                    }
                    else
                    {
                        FillBoard(GenerateRandom(), gameBoard, "COMPUTER");
                    }
                }
            }
        }

        /// <summary>
        /// Calling this method , the computer plays a move
        /// </summary>
        /// <param name="gameboard">The gameboard.</param>
        public static void PlayComputer(char[,] gameboard)
        {
            FillBoard(GenerateRandom(), gameboard, "COMPUTER");
        }

        /// <summary>
        /// Plays the human.
        /// calling this method , the human can play a move
        /// </summary>
        /// <param name="gameBoard">The game board.</param>
        public static void PlayHuman(char[,] gameBoard)
        {
            bool b = true;
            ////this while loop is for keep asking position for user until  valid int is given.
            while (b)
            {
                Console.WriteLine("Enter the position you want");

                string s = Console.ReadLine();
                if (Utility.IsNumber(s) == false)
                {
                    Console.WriteLine("Invalid Command");
                    continue;
                }

                int position = Convert.ToInt32(s);
                Console.WriteLine("position = " + position);

                if (position > 9 || position == 0)
                {
                    Console.WriteLine("Enter a position between 1 and 9");
                }
                else
                {
                    FillBoard(position, gameBoard, "PLAYER"); ////calling fillboard method.
                    b = false;
                    return;
                }
            }
        }

        /// <summary>
        /// Checks the winner. Checks for each Winning Cases ,return String "HUMANWIN" or "COMPUTERWIN" and return "DRAW" if its a Draw
        /// </summary>
        /// <param name="gameBoard">The game board.</param>
        /// <returns>Return String  </returns>
        public static string CheckWinner(char[,] gameBoard)
        {
            if ((gameBoard[0, 0] == 'X' && gameBoard[0, 1] == 'X' && gameBoard[0, 2] == 'X') || (gameBoard[0, 0] == 'O' && gameBoard[0, 1] == 'O' && gameBoard[0, 2] == 'O'))
            {
                if (gameBoard[0, 0] == 'X')
                {
                    return "HUMANWIN";
                }
                else
                {
                    return "COMPUTERWIN";
                }
            }

            if ((gameBoard[1, 0] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[1, 2] == 'X') || (gameBoard[1, 0] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[1, 2] == 'O'))
            {
                if (gameBoard[1, 0] == 'X')
                {
                    return "HUMANWIN";
                }
                else
                {
                    return "COMPUTERWIN";
                }
            }

            if ((gameBoard[2, 0] == 'X' && gameBoard[2, 1] == 'X' && gameBoard[2, 2] == 'X') || (gameBoard[2, 0] == 'O' && gameBoard[2, 1] == 'O' && gameBoard[2, 2] == 'O'))
            {
                if (gameBoard[2, 0] == 'X')
                {
                    return "HUMANWIN";
                }
                else
                {
                    return "COMPUTERWIN";
                }
            }

            if ((gameBoard[0, 1] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 1] == 'X') || (gameBoard[0, 1] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[2, 1] == 'O'))
            {
                if (gameBoard[0, 1] == 'X')
                {
                    return "HUMANWIN";
                }
                else
                {
                    return "COMPUTERWIN";
                }
            }

            if ((gameBoard[0, 0] == 'X' && gameBoard[1, 0] == 'X' && gameBoard[2, 0] == 'X') || (gameBoard[0, 0] == 'O' && gameBoard[1, 0] == 'O' && gameBoard[2, 0] == 'O'))
            {
                if (gameBoard[0, 0] == 'X')
                {
                    return "HUMANWIN";
                }
                else
                {
                    return "COMPUTERWIN";
                }
            }

            if ((gameBoard[0, 2] == 'X' && gameBoard[1, 2] == 'X' && gameBoard[2, 2] == 'X') || (gameBoard[0, 2] == 'O' && gameBoard[1, 2] == 'O' && gameBoard[2, 2] == 'O'))
            {
                if (gameBoard[0, 2] == 'X')
                {
                    return "HUMANWIN";
                }
                else
                {
                    return "COMPUTERWIN";
                }
            }

            if ((gameBoard[0, 0] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 2] == 'X') || (gameBoard[0, 0] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[2, 2] == 'O'))
            {
                if (gameBoard[0, 0] == 'X')
                {
                    return "HUMANWIN";
                }
                else
                {
                    return "COMPUTERWIN";
                }
            }

            if ((gameBoard[2, 0] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[0, 2] == 'X') || (gameBoard[2, 0] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[0, 2] == 'O'))
            {
                if (gameBoard[2, 0] == 'X')
                {
                    return "HUMANWIN";
                }
                else
                {
                    return "COMPUTERWIN";
                }
            }

            return "DRAW";
        }
    }
}
