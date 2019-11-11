using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprimirRangoNumeroMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            imprimirRango(5, 7);
            imprimirRango(10, 20);

            noCerrarVentana();

        }

        static void imprimirRango(int inicio, int fin)
        {
            for (int i = inicio; i <= fin; i++)
            {
                mensaje(i.ToString());
            }
        }

        static void mensaje (string cadena)
        {
            Console.WriteLine(cadena);
        }

        static void noCerrarVentana()
        {
            Console.ReadLine();
        }

    }
}
