using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoVirtualOverrideSobreEscrituraM
{
    class Program
    {
        static void Main(string[] args)
        {
            //La palabra reservada virtual quiere decir que puedo sobreescribir el metodo y el Overrride sobreescribe la palabra
            Pera oPera = new Pera();
            oPera.color();

            Fresa oFresa = new Fresa();
            oFresa.color();

            Console.ReadLine();

        }
    }
}
