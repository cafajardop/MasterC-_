using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerenciaParte1
{
    class Program
    {
        static void Main(string[] args)
        {
            Comercial oComercial = new Comercial();

            oComercial.nombre = "Felipe";
            oComercial.edad = 18;
            oComercial.salario = 4000;
            oComercial.comision = 1000;
            oComercial.plus();

            Repartidor oRepartidor = new Repartidor();
            oRepartidor.nombre = "Carlos";
            oRepartidor.edad = 25;
            oRepartidor.salario = 2000;
            oRepartidor.zona = "zona 3";
            oRepartidor.plus();

            Console.WriteLine(oComercial.salario);
            Console.WriteLine(oRepartidor.salario);
            Console.ReadLine();

        }
    }
}
