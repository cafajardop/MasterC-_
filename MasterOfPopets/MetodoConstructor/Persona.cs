using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstructor
{
    public class Persona
    {
        //Constructor explicito vuelve a la vida
        public Persona()
        {

        }
        
        //Constructor implicito
        public Persona(string nombre, string apellido, int edad, int sueldo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.sueldo = sueldo;
        }

        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public double sueldo { get; set; }
    }
}
