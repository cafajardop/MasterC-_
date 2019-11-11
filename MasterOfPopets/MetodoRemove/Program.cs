using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            string codigo = "A20191525";
            //Es igual que el substring toma desde la posision y el length que toca eliminar
            Console.WriteLine("Nueva cadena " + codigo.Remove(0, 2));

            Console.ReadLine();

        }
    }
}
