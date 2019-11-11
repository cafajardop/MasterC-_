using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoSubString
{
    class Program
    {
        static void Main(string[] args)
        {
            string codigo = "123145678";
            string nombre = "Pepe lucho ";

            //Inicializa el posicion 0 y desde esa posicion toma la longitud
            string past = codigo.Substring(4,5);
            string nompast = nombre.Trim().Substring(5, 5);

            Console.WriteLine("el codigo es :" + past + " El nombre es: " + nompast );

            Console.ReadLine();
        }
    }
}
