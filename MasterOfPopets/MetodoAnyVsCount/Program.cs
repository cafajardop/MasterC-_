using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoAnyVsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> palabras = new List<string>();
            palabras.Add("Primera");
            palabras.Add("Segunda");
            palabras.Add("Tercera");
            palabras.Add("Perra");
            palabras.Add("Piroberta");

            bool contieneElementosCount = palabras.Count() > 0;

            //Devuelve un bool si se cumple la condicion
            bool contieneElementosAny = palabras.Any(f =>f.StartsWith("w"));

            bool result = palabras.All(f => f.StartsWith("P"));

            ICollection<string> collection = palabras as ICollection<string>;
            int numeroElementos = collection.Count;

            Console.WriteLine(contieneElementosAny + result.ToString());

            Console.ReadLine();


        }
    }
}

