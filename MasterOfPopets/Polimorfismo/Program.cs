using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Importante para que halla polimorfismo debe haber herencia, significa que un objeto de la superclase puede almacenar
            un objeto de cualquiera de sus subclases */

            Persona per = new Persona();
            per.nombre = "Carlos";
            per.apPaterno = "Fajardo";
            per.apMaterno = "Pedraza";

            Persona oPersona1 = new Empleado();
            Persona oPersona2 = new Cliente();
        }
    }
}