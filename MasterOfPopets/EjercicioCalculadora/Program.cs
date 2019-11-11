using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("La operacion es: " +  calculadora(8, 7, '*'));

            Console.ReadLine();

        }

        static decimal calculadora(decimal a, decimal b, char operacion)
        {
            decimal res = 0;
            switch (operacion)
            {
                case '+':
                    res = a + b;
                    break;
                case '-':
                    res = a - b;
                    break;
                case '*':
                    res = a * b;
                    break;
                case '/':
                    res = a / b;
                    res = a * b;
                    break;
                default:
                    res = 0;
                    break;
            }
            return res;
        }
    }
}
