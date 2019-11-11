using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 5, 18, 21, 22, 4, 13, 16, 22 };
            string[] nombres = { "Pedro", "Luis", "Jose", "Andrés" };

            int longitud = numeros.Length;
            Console.WriteLine("El numero de elementos es " + longitud);

            //Array.Find => Saca el primer elemento del array que sea mayor a 15 y solo devuelve el primer elemento
            int arrayFindMayor15 = Array.Find(numeros, p => p > 15);
            //Array.FindAll => Trae todos los elementos mayores a 15
            int[] todosArraysMayor15 = Array.FindAll(numeros, p => p > 15);

            Console.WriteLine("El primer elemento del filtro es : " + arrayFindMayor15);

            foreach (int item in todosArraysMayor15)
            {
                Console.WriteLine(item);
            }

            //ArrayIndexOf me devuelve el indice donde se encuentra el valor buscado en el array si no le encuentra me devuelve -1 si lo en
            //encuentra me devuelve el indice retorna un valor 

            int indice = Array.IndexOf(numeros, 22);
            if (indice > 0)
            {
                Console.WriteLine("Existe valor" + indice);
            }
            else
            {
                Console.WriteLine("No existe valor" + indice);
            }

            //Find last es igual que el find pero busca de derecha a izquierda
            int numeroFindLast = Array.FindLast(numeros, p => p > 20);
            Console.WriteLine("Array.FindLast el primer elemento de derecha a izquierda es: " + numeroFindLast);

            //Find index busca el primer indice de izquierda a derecha pereo con filtro
            int numeroFindIndex = Array.FindIndex(numeros, p => p > 20);
            Console.WriteLine("Array.FindIndex el indice de izq a der es : " + numeroFindIndex);
            Console.WriteLine("Su valor es: " + numeros[numeroFindIndex]);

            //FindLastindex busca el primer indice de derecha a izquierda pereo con filtro sacar el indice 
            int numFindLastIndex = Array.FindLastIndex(numeros, p => p > 15);
            Console.WriteLine("Array.FindLastIndex el indice de der a izq es: " + numFindLastIndex);
            Console.WriteLine("Su valor es: " + numeros[numFindLastIndex]);

            //true o false devuelve el array.Exists
            bool exito = Array.Exists(nombres, p => p.StartsWith("A"));

            if(exito)
            {
                Console.WriteLine("Array.Exists con StartsWith nos devuelve un true o false en caso de que exista en el arreglo");
            }
            else
            {
                Console.WriteLine("No existe Array.Exists con StartsWith nos devuelve un true o false en caso de que exista en el arreglo");
            }

            Console.ReadLine();

        }
    }
}
