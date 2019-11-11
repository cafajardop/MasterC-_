using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoVirtualOverrideSobreEscrituraM
{
    public class Fruta
    {
        //Debemos colocar la palabra reservada virtual para que se deje sobreescribir
        public virtual void color()
        {
            Console.WriteLine("Tiene varios colores");
        }
    }
}
