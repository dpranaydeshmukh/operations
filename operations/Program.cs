using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operations
{
    internal class Program
    {
        public void Addition()
        {
            int a=10, b=20, c;
            c = a + b;
            Console.WriteLine("Addition="+c);
        }
        static void Main(string[] args)
        {
            Program P = new Program();
            P.Addition();
            Console.ReadLine();
        }
    }
}
