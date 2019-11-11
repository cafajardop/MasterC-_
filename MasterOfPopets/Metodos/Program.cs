using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Carlos","Andres", "Fajardo"};
            string[] apellidos = { "Pedraza", "Gonzalez", "Pacheco" };

            mensaje("Hola");
            mensaje("Estudia mucho!!");

            imprimirArray(nombres);
            imprimirArray(apellidos);

            noCerrarVentana();
        }

        //Metodo para recibir un array 
        static void imprimirArray(string[] array)
        {
            foreach (var item in array)
            {
                mensaje(item);
            }
        }

        static void mensaje(string cadena)
        {
            Console.WriteLine(cadena);
        }



        static void noCerrarVentana()
        {
            Console.ReadLine();
        }

        static decimal sueldoSemanal(decimal sueldoDiario)
        {
            return sueldoDiario * 7;
        }

        static decimal sueldoMensual(decimal sueldDiario)
        {
            return sueldDiario * 30;
        }

        static decimal sueldoAnual(decimal sueldoDiario)
        {
            return sueldoDiario * 365;
        }

    }
}
