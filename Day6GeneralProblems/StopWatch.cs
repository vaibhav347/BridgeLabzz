using System;
using System.Diagnostics;
using System.Threading;

namespace watch
{
    class StopWatch
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int time = 1;
            long start = 0,end = 0;
            do
            {
                Console.WriteLine("Press 1 to start stop watch");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Press 0 to end stop watch");
                        time = int.Parse(Console.ReadLine());
                        start = Stopwatch.GetTimestamp();
                        end = Stopwatch.GetTimestamp();
                        break;
                }
            }while (time != 0) ;
            Console.WriteLine("Elapsed Time is {0} ticks",end);
         }
    }
}
