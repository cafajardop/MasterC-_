using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolacionDeCadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tecnica de argumentos 
            string ProductName = "Azucar";
            double UnitPrice = 12.45;
            string Nombre = "carlos";

            Console.WriteLine("El producto {0} tiene un precio de {1} y pertenece a {2}", ProductName, UnitPrice, Nombre);

            //Cadena interpolada
            Console.WriteLine($"El producto {ProductName} tiene un precio de {UnitPrice} y pertenece a {Nombre}");

            //Si quiero incluirle un caracter le colocamos las llaves o cualquier caracter {{{ProductName}}}
            Console.WriteLine($"El producto {{{ProductName}}} tiene un precio de {UnitPrice} y pertenece a {Nombre}");

            //Aplicando formato
            Console.WriteLine($"El producto {ProductName,20} tiene un precio de {UnitPrice:C2}");

            //Multiplicar y meterle decimales
            Console.WriteLine($"20 kilos equivalen a {UnitPrice * 20:C0} pesos");

            //Cadena dentro de cadena
            int n = 33;
            var s =
                    $"El número {n} es {(n % 2 == 0 ? "Par" : "Inpar")}";

            Console.WriteLine(s);

            Console.ReadLine();

        }
    }
}
