using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tambien se puede instanciar de esta manera
            Tuple<int, string, string> person2 = new Tuple<int, string, string>(1, "Steve", "Jobs");
            
            //De esta otra manera
            var person1 = Tuple.Create(1, "Carlos", "Jobs");
            DisplayTuple(person1);

            //Una tupla solo puede incluir un máximo de ocho elementos.
            var numbers1 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);

            //
            var person = Tuple.Create(1, "Steve", "Jobs");
            Console.WriteLine(person.Item1); // returns 1
            Console.WriteLine(person.Item2); // returns "Steve"
            Console.WriteLine(person.Item3); // returns "Jobs"

            var numbers = Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, 8);
            Console.WriteLine(numbers.Item1); // returns "One"
            Console.WriteLine(numbers.Item2); // returns 2
            Console.WriteLine(numbers.Item3); // returns 3
            Console.WriteLine(numbers.Item4); // returns "Four"
            Console.WriteLine(numbers.Item5); // returns 5
            Console.WriteLine(numbers.Item6); // returns "Six"
            Console.WriteLine(numbers.Item7); // returns 7
            Console.WriteLine(numbers.Rest); // returns (8)
            Console.WriteLine(numbers.Rest.Item1); // returns 8

            //Una Tupla puede ser devuelta desde un método.
            var person4 = GetPerson();
            Console.WriteLine("Una Tupla puede ser devuelta desde un método." + person4);


            Console.ReadLine();
        }
        
        //Un método puede tener una tupla como parámetro.
        static void DisplayTuple(Tuple<int, string, string> person)
        {
            Console.WriteLine($"Id = { person.Item1}");
            Console.WriteLine($"First Name = { person.Item2}");
            Console.WriteLine($"Last Name = { person.Item3}");
        }
        //Una Tupla puede ser devuelta desde un método.
        static Tuple<int, string, string> GetPerson()
        {
            return Tuple.Create(1, "Bill", "Gates");
        }

        /*
        Uso de tupla
        Las tuplas se pueden usar en los siguientes escenarios:

        Cuando desee devolver múltiples valores de un método sin usar ref o out parámetros.
        Cuando desee pasar múltiples valores a un método a través de un solo parámetro.
        Cuando desee mantener un registro de base de datos o algunos valores temporalmente sin crear una clase separada.

        Limitaciones de la tupla:
        
        La tupla es un tipo de referencia y no un tipo de valor. Se asigna en el montón y podría resultar en operaciones intensivas de CPU.
        Tuple se limita a incluir 8 elementos.
        Debe usar tuplas anidadas si necesita almacenar más elementos. 
        Sin embargo, esto puede resultar en ambigüedad.
        Se puede acceder a los elementos de tupla usando propiedades con un patrón de nombre Elemento <elementNumber> que no tiene sentido.
        
         */
    }
}
