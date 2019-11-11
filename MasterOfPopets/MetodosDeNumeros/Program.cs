using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero = "15";
            int resultado;

            bool exito = Int32.TryParse(numero,out resultado);

            if(exito == true)
            {
                Console.WriteLine("Lo pude convertir");
            }
            else
            {
                Console.WriteLine("No lo pude convertir");
            }

            int suma = resultado + 115;

            Console.ReadLine();
        }
    }
}
