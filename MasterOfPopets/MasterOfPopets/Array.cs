using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterOfPopets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Nombres = { "Julieta", "Valeria", "Carlos", "Ximena","Andres" };
            Console.WriteLine("El numero de elementos es: " + Nombres.Length);
            Console.WriteLine("El ultimo Nombre es: " + Nombres[3]);


            //Acceder al ultimo elemento

            Console.WriteLine("El ultimo elemento es: " + Nombres[Nombres.Length - 1]);
             
            //Recorrer los elementos
            for (int i = 0; i < Nombres.Length; i++)
            {
                Console.WriteLine("El nombre corresponde a: " +  Nombres[i]);
            }

            foreach (string Nom in Nombres)
            {
                Console.WriteLine(Nom);
            }
            Console.ReadLine();
        }
    }
}
