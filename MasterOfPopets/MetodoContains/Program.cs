using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoContains
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje = "me fui a comprar al cine";

            if (mensaje.Contains("fui"))
            {
                Console.WriteLine("se encuentra");
            }
            else
            {
                Console.WriteLine("no esta");
            }
        }
    }
}
