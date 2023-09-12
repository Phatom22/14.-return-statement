using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.return_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Cube(x));

            //freeze
            Console.ReadLine();


        }

        static int Cube(int x)
        {
            return x*x*x;
        }


    }
}
