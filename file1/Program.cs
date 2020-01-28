using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file1
{
    class Program
    {
        static void Main(string[] args)
        {
            //    DirectoryInfo di = new DirectoryInfo(@"d:\\Hamsithan");
            //    if (di.Exists == false) di.Create();//if file does"nt exists it will create a file
            //    di.CreateSubdirectory("dfhlk");

            //    DirectoryInfo[] d = di.GetDirectories();
            //    foreach(DirectoryInfo x in d)
            //    {
            //        Console.WriteLine(x.Name + " " + x.FullName+" "+x.CreationTime);
            //    }
            //    FileInfo[] f1 = di.GetFiles();
            //    Console.WriteLine("*******************************");
            //    foreach(FileInfo x in f1)
            //    {
            //        Console.WriteLine(x.Name + " " + x.FullName + " " + x.CreationTime);

            //}
            //    //**********************to create  a file we use filestream******************
            //    FileStream fs = new FileStream(@"d:\\Hamsithan\file1.txt", FileMode.OpenOrCreate, FileAccess.Write);
            //    StreamWriter sw = new StreamWriter(fs);

            //    sw.WriteLine("welcome");
            //    for (int i = 0; i < 2; i++)
            //    {
            //        string s = Console.ReadLine();
            //        sw.WriteLine(s);
            //    }
            //    sw.Close();
            //     fs.Close();
            //FileStream fs1 = new FileStream(@"d:\Hamsithan\file1.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //StreamReader sw1 = new StreamReader(fs1);
            //string s1;
            //while ((s1 = sw1.ReadLine() )!= null){
            //    Console.WriteLine(s1);
            //}
            //sw1.Close();
            //fs1.Close();
            //********************************* using binarywriter and reader******************************
            FileStream fs1 = new FileStream(@"d:\Hamsithan\file2.txt", FileMode.OpenOrCreate, FileAccess.Write);

            BinaryWriter bw = new BinaryWriter(fs1);
            int i = 10;
            char c = 'a';
            string f = "hello";
            bw.Write(i);
            bw.Write(c);
            bw.Write(f);
            bw.Close();
            fs1.Close();
            FileStream fs2 = new FileStream(@"d:\Hamsithan\file2.txt", FileMode.OpenOrCreate, FileAccess.Read);

            BinaryReader bw1 = new BinaryReader(fs2);
            int x = bw1.ReadInt32();
            
            char c1 = bw1.ReadChar();
            string s = bw1.ReadString();
            Console.WriteLine(x + " " + s + " " + c1);
            bw1.Close();
            fs1.Close();
           
        

        }
    }
}
