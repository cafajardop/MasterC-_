using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Puntos para recordar:
            StringBuilder es mutable.
            StringBuilder funciona más rápido que la cadena al agregar varios valores de cadena.
            
            Inicializar StringBuilder como clase, por ejemplo StringBuilder sb = new StringBuilder()
            Use StringBuilder cuando necesite agregar más de tres o cuatro cadenas.
            Use el método Append() para agregar o agregar cadenas con StringBuilder.
            Use el método ToString() para obtener la cadena de StringBuilder.
            */

            StringBuilder sb = new StringBuilder();
            //or
            StringBuilder sb1 = new StringBuilder("Hola mundillo");
            //or
            StringBuilder sb2 = new StringBuilder(50);
            //or
            StringBuilder sb3 = new StringBuilder("Hello world",50);

            //Agrega los valores pasados ​​al final del objeto StringBuilder actual.
            sb.Append("World!! = >");
            sb.AppendLine("Hello c#");
            sb.AppendLine("This is new line");

            //Reemplaza un especificador de formato pasado en una cadena con texto formateado.
            sb1.AppendFormat("{0:C}", 25);

            //Inserta una cadena en el índice especificado del objeto StringBuilder actual.
            sb3.Insert(11, "C#");


            //Elimina el número especificado de caracteres de la posición inicial dada del objeto StringBuilder actual.
            sb.Remove(6, 7);

            //Reemplaza personajes con nuevos personajes.

            Console.WriteLine("Append: " +  sb);
            Console.WriteLine("AppendFormat: " + sb1);
            Console.WriteLine("Insert: " + sb3);
            sb3.Replace("Hello world", "Hello putos");
            Console.WriteLine("Replace: " + sb3);

            //Ejemplo: StringBuilder como indexador
            for (int i = 0; i < sb.Length; i++)
            {
                Console.WriteLine(sb[i]);
            }

            //Use el método ToString () para obtener una cadena de StringBuilder.
            string str = sb.ToString(); // "Hello World!!"

            Console.WriteLine("Obtener cadena ToString : " + str);

            StringBuilder firstName = new StringBuilder();
            firstName.Capacity = 10;

            List<string> workers = new List<string>();

            workers.Add("Carlos");
            workers.Add("Andres");
            workers.Add("Fajardo");
            workers.Add("Pedraza");
            workers.Add("Schopenhauer");

            foreach (String name in workers)
            {
                firstName.Clear();
                firstName.Insert(0, name);

                Console.WriteLine(firstName); ;
                Console.WriteLine(firstName.Capacity);
               
            }


            Console.ReadLine();
        }
    }
}
