using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Horas, Minutos y Segundos 4:10;29
            TimeSpan objeto1 = new TimeSpan(4, 10, 29);
            TimeSpan objeto2 = new TimeSpan(5, 15, 10);
            TimeSpan objeto5 = new TimeSpan(12,10,5,12,18);
            //                              day h m s m

            TimeSpan objeto3 = objeto1 + objeto2;
            TimeSpan objeto4 = objeto1 - objeto2;

            Console.WriteLine("Suma" + objeto3);
            Console.WriteLine("Resta" + objeto4);


            // Obtener la hora
            Console.WriteLine("Objeto la hora :" + objeto1.Hours);
            Console.WriteLine("Obtengo el dia: " + objeto1.Days);

            //Metodo Add Quiero sumar un time span a otro
            TimeSpan fecha3 = objeto1.Add(objeto2);
            Console.WriteLine("Metodo Add =>  Estamos adicionando una fecha: " +  fecha3);

            //Metodo Compare devuelve -1 si es menor o 1 si es mayor
            Console.WriteLine("Metodo Compare Devuelve si es -1 si es menor o 1 si es mayor:  "  + objeto2.CompareTo(objeto1));

            //Definir un timeSpan rapidamente para dias seria 
            Console.WriteLine("Con dias seria el metodo FromDays "+ TimeSpan.FromDays(2));
            Console.WriteLine("Con horas seria el metodo FromHours " + TimeSpan.FromHours(3));
            Console.WriteLine("Con Minutos seria el metodo FromMinutes " + TimeSpan.FromMinutes(4));

            //Si el valor proviene de la BD lo hacemos un parse exact
            //@"h\:m" horas minutos
            //@"h\:m\:ss" horas minutos y segundos

            string fecha = "17:20";
            string fecha1 = "17:20:10";
            Console.WriteLine("Si el valor proviene de la BD lo hacemos un parse exact: " + TimeSpan.ParseExact(fecha, @"h\:m", null));
            Console.WriteLine("Si el valor proviene de la BD lo hacemos un parse exact HH/MM/SS: " + TimeSpan.ParseExact(fecha1, @"h\:m\:ss", null));


            Console.ReadLine();

        }
    }
}
