using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClasesPropiedades
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
            oPersona.sueldo = 10000000;

            Persona oPersona2 = new Persona();
            oPersona2.nombre = "Andres";
            oPersona2.primerApellido = "Fajardo";
            oPersona2.segundoApellido = "Pedraza";
            oPersona2.edad = 33;
            oPersona2.sueldo = 20000000;

            Console.WriteLine("El señor " +  oPersona.nombre + " " + oPersona.primerApellido + " se gana la modica suma de: " + oPersona.sueldo.ToString());

            Usuario oUsuario = new Usuario();
            oUsuario.nombreUsuario = "lrol";
            oUsuario.contraseña = "123456789";

            //Se accede directamente al metodo 
            string saludoStatic =  Persona.saludoStatic(oPersona.nombre);

            Console.WriteLine("El usuario es: " + oUsuario.nombreUsuario + " y la contraseña es: " + oUsuario.contraseña);
            Console.WriteLine("Su nombre completo es " +  oPersona.nombreCompleto() + " y su sueldo anual es " + oPersona.sueldoAnual());
            Console.WriteLine(oPersona2.saludo(oPersona2.nombre));
            Console.WriteLine("Este saludo es con static " + saludoStatic);

            Console.ReadLine();
        }
    }
}
