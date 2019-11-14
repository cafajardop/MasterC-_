using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //

            Dictionary<int, string> diccionario = new Dictionary<int, string>();
            diccionario.Add(1, "Domingo");
            diccionario.Add(2, "Lunes");
            diccionario.Add(3, "Martes");
            diccionario.Add(4, "Miercoles");
            diccionario.Add(5, "Jueves");
            diccionario.Add(6, "Viernes");
            diccionario.Add(7, "Sabado");

            //Otra forma de agregar al dicicionario
            diccionario[7] = "Sabado";

            //Borrar diccionario

            diccionario.Clear();

            //Contains key

            if (diccionario.ContainsKey(8))
            {
                Console.WriteLine("Existe");
            }

            if (diccionario.ContainsValue("Enero"))
            {
                Console.WriteLine("Existe");
            }
             

        }
    }
}
