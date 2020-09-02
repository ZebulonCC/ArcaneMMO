using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace ArcaneMMO_Server
{
    class Program
    {
        private static bool isRunning = false;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static void Main(string[] args)//FK WINDOWS FORMS, ALL MY HOMIES HATE WINDOWS FORMS -cc
        {
            Console.Title = "Server";
            isRunning = true;

            Thread mainThread = new Thread(new ThreadStart(MainThread));
            mainThread.Start();

            Server.Start(50, 3660);
            
        }

        private static void MainThread()
        {
            //System.Console.WriteLine($"Main thread started. Running at {Constants.TICKS_PER_SEC} ticks per second.");
            Console.WriteLine($"Main thread started. Running at {Constants.TICKS_PER_SEC} ticks per second.");

            DateTime _nextLoop = DateTime.Now;

            while (isRunning)
            {
                while (_nextLoop < DateTime.Now)
                {
                    GameLogic.Update();

                    _nextLoop = _nextLoop.AddMilliseconds(Constants.MS_PER_TICK);

                    if (_nextLoop > DateTime.Now) //Reduces processing data
                    {
                        Thread.Sleep(_nextLoop - DateTime.Now);
                    }
                }
            }
        }
    }
}
