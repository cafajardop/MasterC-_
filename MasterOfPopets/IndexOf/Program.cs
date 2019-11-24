using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            string distrito = "Puente uuuu Piedra";
            //                 0123456789
            string Pais = "Colombia";
            Console.WriteLine("Index Of: " + distrito.IndexOf("u"));

            // => se ubica la posicion 2 arranca en la e ubica la primera u que encuentre
            Console.WriteLine("Index Of con 2 parametros: " + distrito.IndexOf("u",2));

            // => Busca de derecha a izquierda
            Console.WriteLine("Last Index Of: " + distrito.LastIndexOf("u"));

            // => si no encuentra nada el index of devuelve -1
            Console.WriteLine("Si no encuentra nada devuelve: " + Pais.IndexOf("J"));

            //Sirve para encontrar en una cadena algun valor ejemplo, tambien sirve el contains
            if (Pais.IndexOf("p") > -1)
            {
                Console.WriteLine("Se encontro");
            }
            else
            {
                Console.WriteLine("No se encontro");
            }

            Console.ReadLine();
        }
    }
}
