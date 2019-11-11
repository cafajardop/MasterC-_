using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargaMetodos
{
    public class Persona
    {
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public int edad { get; set; }
        public double sueldo { get; set; }


        public static string saludo(string nombre)
        {
            return "Sobrecarga de metodo con solo la variable nombre" + nombre;
        }

        public static string saludo(string primerApellido, string segundoApellido)
        {
            return "Sobrecarga de metodo con 2 variables  " + primerApellido + " " + segundoApellido;
        }

        public static string saludo(int edad)
        {
            return "Estoy retornando la edad: " + edad;

        }
    }
}
