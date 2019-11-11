using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoVirtualOverrideSobreEscrituraM
{
    public class Fresa:Fruta
    {
        public override void color()
        {
            Console.WriteLine("Rojo");
        }
    }
}
