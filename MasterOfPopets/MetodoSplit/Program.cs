using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            //siempre que hagamos un split nos va a devolver un arrays de string
            string palabra = "hola|cmoo|estas|que|me|cuentas";
            string [] arrglo = palabra.Split('|');

            foreach (string item in arrglo)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

    }
}
