using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargaMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona oPersona = new Persona();
            oPersona.nombre = "Carlos";
            oPersona.primerApellido = "Fajardo";
            oPersona.segundoApellido = "Pedraza";
            oPersona.edad = 35;

            //Sobre carga de metodo es que el metodo puede sobrecargarse con diferente variables y las acepta
            string result =   Persona.saludo(oPersona.primerApellido, oPersona.segundoApellido);
            string resultInt = Persona.saludo(oPersona.edad);

            Console.WriteLine("El resultado de la sobrecarga de metodo es : " + result);
            Console.WriteLine(resultInt);

            Console.ReadLine();
        }
    }
}
