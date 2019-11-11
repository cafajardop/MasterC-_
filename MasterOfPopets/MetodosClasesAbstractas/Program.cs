using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            //la clase abstracta se utiliza solo como clase padre
            //No se puede instanciar objetos a partir de una clase abstracta
            //Sirve para dar una referencia o bosquejo de lo que tenran las clases hijas (sublases)
            Invierno oInvierno = new Invierno();
            oInvierno.sensacion();

            Verano oVerano = new Verano();
            oVerano.sensacion();

            Console.ReadLine();


        }
    }
}
