namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Diagnostics;
    using System.Threading;
    public class StopWatchProgram
    {
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
