using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se encarga de ocultar nuestros atributos y metodos y nos previene de errores
            Persona oPersona = new Persona();
            oPersona.setNombre("Carlos");
            oPersona.setApellido("Fajardo");
            oPersona.setEdad(35);
            oPersona.setSueldo(1000000);

            Console.WriteLine(oPersona.getNombre());
            Console.ReadLine();
        }
    }
}
