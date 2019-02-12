<<<<<<< HEAD
﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Gambler.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Simulates a gambler who start with $stake and place fair $1 bets until he/she goes broke (i.e. has no money) or reach $goal. 
    /// Keeps track of the number of times he/she wins and the number of bets he/she makes
    /// </summary>
    public class Gambler
    {
        /// <summary>
        ///  simulates the game
        /// </summary>
        public static void GamblerPlay()
        {        
            int stake = 0;
            int userGoal = 0;
            int wins = 0;
            int loose = 0;
            bool stakeFlag = true;
            bool goalFlag = true;

            while (stakeFlag)
            {
                Console.WriteLine("Enter the Stake you have");
                string strStake = Console.ReadLine();

                if (Utility.IsNumber(strStake))
                {
                    stake = Convert.ToInt32(strStake);
                    stakeFlag = false;
                }
                else
                {
                    Console.WriteLine("Stake should be in Integers Only");
                }
            }

            while (goalFlag)
            {
                Console.WriteLine("Enter your goal");
                string strGoal = Console.ReadLine();

                if (Utility.IsNumber(strGoal))
                {
                    userGoal = Convert.ToInt32(strGoal);
                    goalFlag = false;
                }
                else
                {
                    Console.WriteLine("Goal should be in Integers Only");
                }
            }

            Random rdm = new Random();

            while (stake != 0 && stake != userGoal)
            {
                double r = rdm.NextDouble();

                if (r < 0.5)
                {
                    loose++;
                    stake--;
                }
                else
                {
                    wins++;
                    stake++;
                }

                Console.WriteLine("No of Wins = " + wins);
                Console.WriteLine("No of loose = " + loose);
                Console.WriteLine("No of bets = " + (loose + wins));
                if (stake == userGoal)
                {
                    Console.WriteLine("Congrats you have reached your goal = " + userGoal);
                }
                else
                {
                    Console.WriteLine("You loose ,stake = " + stake);
                }
            }
        }
    }
}
=======
﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Gambler.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Simulates a gambler who start with $stake and place fair $1 bets until he/she goes broke (i.e. has no money) or reach $goal. 
    /// Keeps track of the number of times he/she wins and the number of bets he/she makes
    /// </summary>
    public class Gambler
    {
        /// <summary>
        ///  simulates the game
        /// </summary>
        public static void GamblerPlay()
        {
            
            int stake = 0;
            int userGoal = 0;
            int wins = 0;
            int loose = 0;
            bool stakeFlag = true;
            bool goalFlag = true;

            while (stakeFlag)
            {
                Console.WriteLine("Enter the Stake you have");
                string strStake = Console.ReadLine();

                if (Utility.IsNumber(strStake))
                {
                    stake = Convert.ToInt32(strStake);
                    stakeFlag = false;
                }
                else
                {
                    Console.WriteLine("Stake should be in Integers Only");
                }
            }

            while (goalFlag)
            {
                Console.WriteLine("Enter your goal");
                string strGoal = Console.ReadLine();

                if (Utility.IsNumber(strGoal))
                {
                    userGoal = Convert.ToInt32(strGoal);
                    goalFlag = false;
                }
                else
                {
                    Console.WriteLine("Goal should be in Integers Only");
                }
            }

            Random rdm = new Random();

            while (stake != 0 && stake != userGoal)
            {
                double r = rdm.NextDouble();

                if (r < 0.5)
                {
                    loose++;
                    stake--;
                }
                else
                {
                    wins++;
                    stake++;
                }

                Console.WriteLine("No of Wins = " + wins);
                Console.WriteLine("No of loose = " + loose);
                Console.WriteLine("No of bets = " + (loose + wins));
                if (stake == userGoal)
                {
                    Console.WriteLine("Congrats you have reached your goal = " + userGoal);
                }
                else
                {
                    Console.WriteLine("You loose ,stake = " + stake);
                }
            }
        }
    }
}
>>>>>>> 4efd8afd75bcbf3290acb39f770528c13ef0907e
