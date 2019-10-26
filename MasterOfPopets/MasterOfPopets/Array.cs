using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterOfPopets
{
    class Array
    {
        static void Main(string[] args)
        {
            string[] Nombres = { "Julieta", "Valeria", "Carlos", "Ximena", "Andres" };
            Console.WriteLine("El numero de elementos es: " + Nombres.Length);
            Console.WriteLine("El ultimo Nombre es: " + Nombres[3]);


            //Acceder al ultimo elemento

            Console.WriteLine("El ultimo elemento es: " + Nombres[Nombres.Length - 1]);

            //Recorrer los elementos
            for (int i = 0; i < Nombres.Length; i++)
            {
                Console.WriteLine("El nombre corresponde a: " + Nombres[i]);
            }

            foreach (string Nom in Nombres)
            {
                Console.WriteLine(Nom);
            }


            //Recorrer enteros con un foreach

            int[] Numeros = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("El numero mayor es :" + Numeros[Numeros.Length - 1]);

            foreach (int Num in Numeros)
            {
                Console.WriteLine("El conteo de numeros es: " + Num);
            }

            //Recorrer con un for

            for (int i = 0; i < Numeros.Length; i++)
            {
                Console.WriteLine("El numero mayor con un for es: " + Numeros[Numeros.Length - 1]);
            }

            //Definir un array de forma diferente 
            int[] NumerosDif = new int[4];
            NumerosDif[0] = 15;
            NumerosDif[1] = 18;
            NumerosDif[2] = 19;
            NumerosDif[3] = 20;

            //Foreach
            foreach (int NumD in NumerosDif)
            {
                Console.WriteLine("Definir array de forma diferente con un foreach: " + NumD);
            }

            for (int i = 0; i < NumerosDif.Length; i++)
            {
                Console.WriteLine("Recorro con un for array de forma diferente: " + NumerosDif[i]);
            }

            Console.WriteLine("Este es el mayor de la lista: " + NumerosDif[NumerosDif.Length - 1]);

            //Array de arrays
            string[,] NombreArrayArrays =
            {
                   { "Carlos","Valeria","Julieta"},
                   { "Fajardo","Fajardo","Fajardo"}
            };

            Console.WriteLine(NombreArrayArrays[0, 2]);

            Console.ReadLine();

        }
    }
}
