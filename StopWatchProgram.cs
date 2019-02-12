// --------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="StopWatchProgram.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------------------------------------

namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Text;
    using System.Threading;

    /// <summary>
    /// Simulates a stopwatch
    /// </summary>
    public class StopWatchProgram
    {
        /// <summary>
        /// Gives the elapsed time between start and stop of stopwatch
        /// </summary>
        public static void StartStopWatch()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("Stopwatch Started,Press Enter key to stop");
            Console.ReadKey();
            Console.WriteLine("Total Elapsed time = " + stopWatch.Elapsed);
        }
    }
}
