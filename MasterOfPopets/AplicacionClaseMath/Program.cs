using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionClaseMath
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio = 20.6;
            int a = 2;
            int b = 5;
            int raizCuadrada = 36;
            int valorAbsoluto = -2;
            //EL MATH.FLOOR SOLO TOMA LA PARTE ENTERA ES DECIR EL 20 REDONDEA
            Console.WriteLine("Math.floor (20.6) " + Math.Floor(precio));
            //LE SUMA UNO
            Console.WriteLine("Math.ceiling (20.6) " + Math.Ceiling(precio));
            //ESTE METODO REDONDEA LA CANTIDAD
            Console.WriteLine("Math.Round (20.6) " + Math.Round(precio));
            //HALLAR LA POTENCIA
            Console.WriteLine("Math.Pow (20.6) " + Math.Pow(a,b));
            //RAIZ CUADRADA
            Console.WriteLine("Raiz Sqrt" + Math.Sqrt(raizCuadrada));
            //SABER CUAL ES EL MAYOR DE DOS NUMEROS
            Console.WriteLine("El mayor es " + Math.Max(a, b));
            //SABER CUAL ES EL MENOR DE DOS NUMEROS
            Console.WriteLine("El menor es " + Math.Min(a, b));
            //SACAR EL VALOR ABSOLUTO
            Console.WriteLine("El valor absoluto es " + Math.Abs(valorAbsoluto));

            Console.ReadLine();
        }
    }
}
