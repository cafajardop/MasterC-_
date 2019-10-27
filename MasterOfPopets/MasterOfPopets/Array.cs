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

            //Arrays con condicionales
            int[] NumeroCondicional = { -100, -58, 50, 36, 40, 69 };

            foreach (int item in NumeroCondicional)
            {
                if (item >= 0)
                    Console.WriteLine(item);
            }

            //Array con contadores
            int c = 0;
            foreach (int item in NumeroCondicional)
            {
                if (item >= 0)
                    c++;
            }
            Console.WriteLine("El numero de enteros positivos es: " + c);
            //Arrays con acumuladores

            int suma = 0;
            foreach (int item in NumeroCondicional)
            {
                if (item % 2 == 0)
                    suma += item;
            }
            Console.WriteLine("La suma es: " + suma);

            //Arrays cantidad de positivos y cantidad de negativos y acumular suma de positivos y negativos (+=)
            int cantidadPositivos = 0, cantidadNegativos = 0, sumaPositivos = 0, sumaNegativos = 0;
            foreach (int item in NumeroCondicional)
            {
                if (item >= 0)
                {
                    cantidadPositivos++;
                    sumaPositivos += item;
                }
                else
                {
                    cantidadNegativos++;
                    sumaNegativos += item;
                }
            }

            //Tarea arrays Se tiene el siguiente array de números . Calcular cuantos elementos son pares
            int[] valores = { 7, 9, 23, 56, 23, 34, 66, 78, 79, 34, 12, 16, 15 };
            int numerosPares = 0, numeroImpares = 0;

            foreach (int val in valores)
            {
                if (val % 2 == 0)
                {
                    numerosPares++;
                }
                else
                {
                    numeroImpares++;
                }

            }
            Console.WriteLine("Los numero impares son:" + numerosPares);
            Console.WriteLine("Los numeros pares son :" + numeroImpares);
            Console.WriteLine("La cantidad de positivos es: " + cantidadPositivos + " y la cantidad de negativos es " + cantidadNegativos);
            Console.WriteLine("La suma de positivos es: " + sumaPositivos + " y la suma de negativos es " + sumaNegativos);


            //2. Se tiene el siguiente array de números indicar cuantos números de tres cifras positivos hay
            int[] valores1 = { 721, 9, 423, 56, 23, 34, 966, 78, 79, 3664, 12, 5516, 15, 100 };
            int MayorTresPositivo = 0;
            int MayorTresPositivoFor = 0;
            int numerosPositivosForeach = 0;
            int numerosPositivosFor = 0;

            foreach (int val1 in valores1)
            {
                if (val1 > 99 && val1 < 1000)
                {
                    if (val1 % 2 == 0)
                    {
                        MayorTresPositivo++;
                        numerosPositivosForeach += val1;
                    }
                }
            }

            //2 Ejemplo del profesor
            int v = 0;
            foreach (int n in valores1)
            {
                if (n >= 0 && n >= 100 && n <= 999) v++;
            }

            Console.WriteLine("Ejemplo del profe Hay " + v + " numeros positivos de tres cifras");

            Console.WriteLine("la cantidad de números de tres cifras positivos con un foreach " + MayorTresPositivo);
            Console.WriteLine("la suma de los numeros son con foreach: " + numerosPositivosForeach);

            for (int i = 0; i < valores1.Length; i++)
            {
                if (valores1[i] > 99 && valores1[i] < 1000)
                {
                    if (valores1[i] % 2 == 0)
                    {
                        MayorTresPositivoFor++;
                        numerosPositivosFor += valores1[i];
                    }

                }
            }

            Console.WriteLine("la cantidad de números de tres cifras positivos con un for: " + MayorTresPositivoFor);
            Console.WriteLine("la suma de los numeros son con for : " + numerosPositivosFor);


            //3.Se tiene el siguiente array, hallar la suma de los elementos que son mayores a 15

            int[] numerosEjecicio3 = { 5, 8, 6, 4, 8, 25, 4, 2, 8, 12, 45, 12, 6, 7, 8 };
            int varSuma = 0;

            foreach (int valNum in numerosEjecicio3)
            {
                if (valNum > 15)
                    varSuma += valNum;
            }

            Console.WriteLine("la suma de los elementos que son mayores a 15 es: " + varSuma);


            //Array complejo con readline
            int[] ArrayComplejo = new int[4];
            string IngreseNumero;
            int sumar = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese Numero " + (i + 1));
                IngreseNumero = Console.ReadLine();
                ArrayComplejo[i] = int.Parse(IngreseNumero);
            }
            sumar = ArrayComplejo[0] + ArrayComplejo[3];
            Console.WriteLine("la suma es: " + suma);

            Console.ReadLine();
        }
    }
}

