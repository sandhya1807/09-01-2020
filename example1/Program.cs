using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("enter the no_of trainee");
            int n = int.Parse(Console.ReadLine());
            List<trainee> tlist = new List<trainee>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("trainee id");
                int s = int.Parse(Console.ReadLine());
                Console.WriteLine("trainee name");
            string d = Console.ReadLine();
                Console.WriteLine("project id");
            int j = int.Parse(Console.ReadLine());



                tlist.Add(new trainee(s,d,j));
            }
            List<trainee> pi = tlist.FindAll(j => j.project_id != -1);
            foreach(trainee t in pi)
            {
                Console.WriteLine(t.ToString());
            }
        }
    }
}
