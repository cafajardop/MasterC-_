using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosToUpperToLower
{
    class Program
    {
        static void Main(string[] args)
        {

            string utiles = "Me fui de paseo";

            Console.WriteLine(utiles.ToUpper());

            //Convierte a mayuscula
            string nombre1 = "Carlos";
            string nombre2 = "carlos";

            if(nombre1.ToUpper().Equals(nombre2.ToUpper()))
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son diferentes");
            }
            
        }
    }
}
