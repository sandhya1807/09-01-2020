using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<employe> elist = new List<employe>();
            elist.Add(new employe("hamsi", "a7", 456));
            elist.Add(new employe("sfujd", "fdtgfr", 43543));
            elist.Add(new employe("shreyas", "6u7", 3435646));
            List<employe> highpay = elist.FindAll(e => e.salary > 12000);
            foreach (employe e1 in highpay)
            {
                Console.WriteLine(e1.ToString());
            }
        }
    }
}
