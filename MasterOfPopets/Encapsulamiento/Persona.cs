using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public double sueldo { get; set; }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getApellido()
        {
            return nombre;
        }

        public void setApellido (string apellido)
        {
            this.apellido = apellido;
        }

        public int getEdad()
        {
            return edad;
        }
        public void setEdad (int edad)
        {
            if (edad > 0) this.edad = edad;
            else this.edad = 0;
        }
        public double getSueldo()
        {
            return sueldo;
        }
        public void setSueldo(double sueldo)
        {
            if (sueldo >= 0) this.sueldo = sueldo;
            else this.sueldo = 0;
        }


    }
}
