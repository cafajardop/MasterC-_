using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClasesPropiedades
{
    public class Persona
    {
        //Lo que queremos almacenar
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public int edad { get; set; }
        public double sueldo  { get; set; }

        //Metodo concatena nombre completo
        public string nombreCompleto()
        {
            return nombre + " " + primerApellido + " " + segundoApellido;
        }

        //Metodo calcula sueldo anual
        public double sueldoAnual()
        {
            return sueldo * 12;
        }

        //Metodo Saludo sin static
        public string saludo (string nombre)
        {
            return "Hola como estas " + nombre;
        }

        //Metodo Saludo con static se refiere a que debe acceder de una vez al objeto Persona.saludo()
        public static string saludoStatic(string nombre)
        {
            return "Hola como estas " + nombre;
        }

    }
}
