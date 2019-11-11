using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearFunciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;
            Console.WriteLine("La suma es : " + suma(a, b));

            Console.ReadLine();
        }

        //Aqui se pasan las funciones
        // siempre colocamos lo que vamos a retornar vemos que es static void

        static int suma(int a, int b)
        {
            return a + b;
        }
    }
}
