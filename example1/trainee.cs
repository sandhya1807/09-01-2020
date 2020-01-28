using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example1
{
    class trainee
    {
        int trainee_id;
        string trainee_name;
 public  int project_id;
        public trainee(int trainee_id, string trainee_name, int project_id)
        {
            this.trainee_id = trainee_id;
            this.trainee_name = trainee_name;
            this.project_id = project_id;
           // Console.WriteLine(trainee_id + " " + trainee_name + " " + project_id);
        }
        public override string ToString()
        {
            return this.trainee_id + " " + this.trainee_name + " " + this.project_id;
        }

    }
}
