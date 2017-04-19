using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //MQ.Sendor.runSendor();
            //MQ.Receivor.runReceivor();
           // System.Console.WriteLine("hello console library!");
           
            Hello h = new Hello();

            Console.WriteLine("start TickCount st");
            int st = Environment.TickCount;
            h.appendString();
            int md = Environment.TickCount;
            System.Console.WriteLine("Time spend for append fundtion is {0}", (md - st));
            
            h.addString();
            int et = Environment.TickCount;
            System.Console.WriteLine("Time spend for add fundtion is {0}",  (et - md));
            System.Console.ReadKey();
            //Thread.Sleep(10000);                  
        }
    }
}
