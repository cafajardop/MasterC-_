using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSueldoFunciones
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal sueldoGanaSemanal = sueldoSemanal(143000m);
            Console.WriteLine("Este es el sueldo Semanal :" + sueldoGanaSemanal);

            decimal sueldGanaMensual = sueldoMensual(143000m);
            Console.WriteLine("Este es el sueldo Mensual: " + sueldGanaMensual);

            decimal sueldoGanaAnual = sueldoAnual(143000m);
            Console.WriteLine("Este es el sueld Anual: " + sueldoGanaAnual);

            Console.ReadLine();
        }

        //semanal (7 dias)
        static decimal sueldoSemanal(decimal sueldoDiario)
        {
            return sueldoDiario * 7;
        }
        //mensual (30 dias)
        static decimal sueldoMensual(decimal sueldoDiario)
        {
            return sueldoDiario * 30;
        }
        //anual (365 dias)
        static decimal sueldoAnual(decimal sueldoDiario)
        {
            return sueldoDiario * 365;
        }
    }
}
