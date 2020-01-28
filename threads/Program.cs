using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace threads
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("main start");
            thread th = new thread();
            Thread t1 = new Thread(th.counteven);
            Thread t2 = new Thread(th.countodd);
          //  t1.Priority = ThreadPriority.Lowest;
         //   t2.Priority = ThreadPriority.Highest;
            t1.Start();
            t2.Start();
            Console.WriteLine("thread got suspended");
            t1.Suspend();
            Console.WriteLine("main ends");
           
        }
    }
}
