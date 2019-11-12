using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerenciaParte1
{
    public abstract class Empleado
    { 
        //El readOnly significa que es una constante
        public readonly int PLUS = 400;
        public string nombre { get; set; }
        public int edad { get; set; }
        public double salario { get; set; }
        public abstract double plus();
    }
}
