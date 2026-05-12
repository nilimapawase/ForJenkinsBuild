using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForJenkinsBuild
{ 
    internal class Program
    {
        void Add()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine("The Addition is: " + c);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Add();
        }
    }
}
