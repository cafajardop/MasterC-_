using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadLengthTrimStartTrimEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Propiedad length
            string nombre = "carlos";
            string apellido = "carlos";
            Console.WriteLine(nombre.Length);

            //Equals
            if (nombre.Equals(apellido))
                Console.WriteLine("son iguales");
            else
                Console.WriteLine("Son diferentes");
            
            



            Console.ReadLine();
                       
        }
    }
}
