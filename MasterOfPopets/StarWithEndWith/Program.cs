using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWithEndWith
{
    class Program
    {
        static void Main(string[] args)
        {
            string aves = "pollo";
            //Este metodo nos sirve para determinar si algo empieza por cierto metodo o cierta cadena 
            if(aves.StartsWith("p"))
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Mal");
            }

            //Ejemplo con un arreglo

            string[] nombres = { "Pepe", "Pedro", "Damian" };
            int c = 0;
            foreach (string item in nombres)
            {
                if (item.StartsWith("D")) c++;
            }

            Console.WriteLine("existen " + c + " Nombre que comienza por la letra D");
            Console.ReadLine();
        }
    }
}
