using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate1
{
    public delegate void deligatepointer();
    public delegate double calAreapointer(double x);

    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //   deligatepointer mydeligate = new deligatepointer();
            deligatepointer mydeligate = p.print;
            mydeligate += p.display;//multicaste delegates
            mydeligate();
           mydeligate -= p.print;
            mydeligate();
            calAreapointer ca = calculator.calArea;
            ca += calculator.caldistance;
            Console.WriteLine("enter the area ");
            int s = int.Parse(Console.ReadLine());
            double area = ca(s);
            Console.WriteLine(area);



        }
        public void print()
        {
            Console.WriteLine("welcome to deligate");
        }
        public void display()
        {
            Console.WriteLine("this is multicaste delegates");
        }
        
    }
}
