using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 9, numero2 = 0;
            try
            {
                int resultado = numero1 / numero2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ocurrio un error , no se puede dividir entre cero");
            }
            Console.WriteLine("Hola");

            //Ejemplo con Finaly siempre se va a ejecutar siempre 

            try
            {
                int[] numeros = new int[4];
                numeros[0] = 10;
                numeros[1] = 15;
                numeros[2] = 18;
                numeros[3] = 16;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ingreso un indice fuera de rango" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Hola yo siempre termino jejejej");
            }

            Console.ReadLine();
        }
    }
}