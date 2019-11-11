using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un constructor es un método especial que le pertenece a una clase que se invoca siempre que se crea un objeto de esa clase
            Persona oPersona = new Persona("Carlos","Fajardo",35,10000000);

            //Con constructor explicito
            Persona oPersonaContructorExplicito = new Persona();
            oPersonaContructorExplicito.nombre = "Carlos";
            oPersonaContructorExplicito.apellido = "Fajardo";
            
            Console.WriteLine("Imprimir constructor Edad " + oPersona.edad);
            Console.WriteLine("Imprimir contructor explicito: " + oPersonaContructorExplicito.nombre);

            Console.ReadLine();
        }
    }
}
