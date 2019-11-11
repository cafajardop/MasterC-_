using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoTrim
{
    class Program
    {
        static void Main(string[] args)
        {
            //El metodo trim elimina los espacios al inicio y al final si hay espacios en medio no los elimina
            string apellidoTrim = " Gonzalez ";

            Console.WriteLine(apellidoTrim.Trim().Length);

            string objetoTrimStart = " Meza ";

            //TRIM START Quita el espacio en blanco del inicio ojo
            Console.WriteLine("Metodo TrimStart " + objetoTrimStart.TrimStart().Length);

            //TRIM END Quita el espacio en blanco del Final ojo
            Console.WriteLine("Metodo TrimEnd " + objetoTrimStart.TrimEnd().Length);



            Console.ReadLine();

        }
    }
}
