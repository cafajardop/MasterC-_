using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoToCharArray
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombre = "Pepe ";
            char[] array = nombre.Trim().ToLower().ToCharArray();
            int c = 0;
             
            foreach (char item in array)
            {
                if(item.Equals('e')) c++;
            }
            Console.WriteLine("Se repite la letra e " + c + " veces");

            Console.ReadKey();
        }
    }
}
