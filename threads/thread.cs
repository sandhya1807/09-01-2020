using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace threads
{
    class thread
    {
        public void counteven()
        {
            for (int i = 0; i < 100; i += 2)
            {
                Console.WriteLine(i);
              //  if (i == 50) 
               // {
               //     Thread.Sleep(0);
               // }
            }
        }
            public void countodd()
            {
                for (int i = 1; i < 100; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
    }
}
