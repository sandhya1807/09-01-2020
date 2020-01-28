using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  //  public delegate double calAreapointer(double x);

    class Program
    {

        static void Main(string[] args)

        {
            //  employe e = new employe();
            List<employe> elist = new List<employe>();
            elist.Add(new employe("hamsi", "a7", 456));
            elist.Add(new employe("sfujd", "fdtgfr", 43543));
            elist.Add(new employe("shreyas", "6u7", 3435646));
            List<employe> highpay = elist.FindAll(e => e.salary > 12000);
            foreach(employe e1 in highpay)
            {
                Console.WriteLine(highpay);
            }

            // calAreapointer cal =new calAreapointer(caldistance);

            //   calAreapointer cal = new calAreapointer(delegate (double r) { return r * 100; }); //anonymous method
            //   calAreapointer cal1 = (r => 3.14 * r * r);
            //  double a = cal1(50);
            //  Console.WriteLine(a);
            //prebuild deligates Func<>,Action<>,Predicate<>
            //func deligate have input and output parameters
            Func<double, double> f1 = (r => 3.14 * r * r);
            double area2 = f1(4);
            Console.WriteLine(area2);
            //action deligate only have input value
            Action<string> act = (x => Console.WriteLine(x));
            act("hamsitha");
            Predicate<int> pt = (y => y > 8);
            Console.WriteLine(pt(5));
            int[] array = new int[] { 1, 2, 3, 4 };
            List<string> names = new List<string>();
            names.Add("hamsi");
            names.Add("shreyas");
            names.Add("summu");
            int a= array.Count(x => x > 2);
            Console.WriteLine(a);
    List<string> sn= names.FindAll(y => y.Contains('i'));
            foreach(string n in sn)
            {
                Console.WriteLine(n);
            }

            //       public static double caldistance(double d)
            //       {
            //           return d * 100;
            //       }


        }
    }
}
