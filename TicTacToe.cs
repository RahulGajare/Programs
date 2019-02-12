

namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class TicTacToe
    {
        public static void StartTicTacToe()
        {
            bool flag = true;

            // creating a display game board using 2d Array
            char[,] gameBoard = new char[,]
            {
            {'-','-','-'},
            {'-','-','-'},
            {'-','-','-'}
            };

            Console.WriteLine("====================================================================================================");
            display(gameBoard);
            Console.WriteLine("====================================================================================================");

            //keeps looping untill Correct command "GO" is given.
            while (flag)
            {

                Console.WriteLine("Enter GO to start game");
                String go = Console.ReadLine();
                if (!go.Equals("GO"))
                {
                    Console.WriteLine("Invalid Command");
                }
                else
                {
                    //if command is correct(GO);
                    Console.WriteLine(" You are X. \n Computer is O.");
                    //display(gameBoard);
                    flag = false;
                }
            }

            //first played by Computer
            Console.WriteLine("====================================================================================================");
            display(gameBoard);

            Console.WriteLine("====================================================================================================");
            for (int i = 0; i < 4; i++)
            {
                playComputer(gameBoard);
                display(gameBoard);
                Console.WriteLine("====================================================================================================");

                playHuman(gameBoard);
               
                display(gameBoard);
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

            if (CheckWinner(gameBoard).Equals("DRAW"))
            {
                Console.WriteLine("Its a Draw ");
                return;
            }
            return;
        }//main();end

        //Displays the Game Board On Console
        public static void display(char[,] gameBoard)
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

        //Generates a random Number between 1 and 9
        public static int generateRandom()
        {
            Random r = new Random();
            return r.Next(1, 10);

        }

        //takes the position and fills the game board accoding to the postion in matrix
        //also takes a string if its palyers or Computers turn
        public static void fillBoard(int position, char[,] gameBoard, string player)
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
                        playHuman(gameBoard);

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
                        playHuman(gameBoard);

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
                        playHuman(gameBoard);

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
                        playHuman(gameBoard);

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
                        playHuman(gameBoard);

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
                        playHuman(gameBoard);

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
                        playHuman(gameBoard);

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
                        playHuman(gameBoard);

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
                        playHuman(gameBoard);

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
                        fillBoard(generateRandom(), gameBoard, "COMPUTER");
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
                        fillBoard(generateRandom(), gameBoard, "COMPUTER");
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
                        fillBoard(generateRandom(), gameBoard, "COMPUTER");
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
                        fillBoard(generateRandom(), gameBoard, "COMPUTER");
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
                        fillBoard(generateRandom(), gameBoard, "COMPUTER");
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
                        fillBoard(generateRandom(), gameBoard, "COMPUTER");
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
                        fillBoard(generateRandom(), gameBoard, "COMPUTER");
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
                        fillBoard(generateRandom(), gameBoard, "COMPUTER");
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
                        fillBoard(generateRandom(), gameBoard, "COMPUTER");
                    }
                }
            }

        }

        //calling this method , the computer plays a move
        public static void playComputer(char[,] gameboard)
        {
            fillBoard(generateRandom(), gameboard, "COMPUTER");
        }

        //calling this method , the human plays a move
        public static void playHuman(char[,] gameBoard)
        {

            bool b = true;
            //this while loop is for keep asking position for user until  valid int is given.
            while (b)
            {
                //try
                //{
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


                    fillBoard(position, gameBoard, "PLAYER");//calling fillboard method.
                    b = false;
                    return;

                }
                //}
                //catch(Exception)
                //{
                //Console.WriteLine("IN CATCH");
                //Console.WriteLine("Insert only Integers between 1 & 9");
                //}


            }
        }

        /// <summary>
        /// Checks the winner. Checks for each Winning Cases ,return String "HUMANWIN" or "COMPUTERWIN" and return "DRAW" if its a Draw
        /// </summary>
        /// <param name="gameBoard">The game board.</param>
        /// <returns></returns>
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
                if (gameBoard[0, 0] == 'X')
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
                if (gameBoard[0, 0] == 'X')
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
                if (gameBoard[0, 0] == 'X')
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
                if (gameBoard[0, 0] == 'X')
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
            if ((gameBoard[2, 0] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[0, 2] == 'X') || (gameBoard[0, 0] == 'O' && gameBoard[0, 1] == 'O' && gameBoard[0, 2] == 'O'))
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

            return "DRAW";
            

        }
    }
}
