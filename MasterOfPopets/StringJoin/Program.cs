using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringJoin
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vec = { "Blue", "Red", "Brown","Yellow" };
            string str = string.Join("/",vec);

            Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}
