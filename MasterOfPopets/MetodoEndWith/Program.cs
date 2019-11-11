using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoEndWith
{
    class Program
    {
        static void Main(string[] args)
        {
            string apellido = "Romancho";

            if (apellido.EndsWith("m"))
            {
                Console.WriteLine("Termina con m");
            }
            else
            {
                string ultimaLetra = apellido.Substring(apellido.Length - 1, 1);
                Console.WriteLine("No termina con m termina con: " + ultimaLetra );
            }
            Console.ReadLine();
        }
    }
}
