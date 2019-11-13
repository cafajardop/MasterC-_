using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesParte1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Lista son una coleccion de datos del mismo tipo, como los arrays, a diferencia de que en una lista podemos añadir yquitar datos
            Facilmente y cuando queramos*/

            Estudiante oEstudiante1 = new Estudiante("Carlos", 14, 19);
            Estudiante oEstudiante2 = new Estudiante("Andres", 14, 19);
            Estudiante oEstudiante3 = new Estudiante("Charles", 14, 19);

            //Primera forma
            List<Estudiante> listaEstudiando = new List<Estudiante>
            {
                oEstudiante1, oEstudiante2, oEstudiante3
            };

            //Segunda Forma
            List<Estudiante> listaEstudiante2 = new List<Estudiante>
            {
                new Estudiante("Carlos",14,19), new Estudiante ("Luis", 15,18), new Estudiante("Jorge",11,15)
            };
            double promedio =  (listaEstudiante2[0].nota1 + listaEstudiante2[0].nota2) / 2.0 ;

            Console.WriteLine("el promedio es: " + promedio);


            List<string> listaNombres = new List<string>();
            listaNombres.Add("Carlos");
            listaNombres.Add("Andres");
            listaNombres.Add("Charles");
            listaNombres.Add("Andrwes");

            foreach (string item in listaNombres)
            {
                Console.WriteLine(item);
            }

            //Sacar el numero de elementos de una lista
            int numeroElementos = listaNombres.Count;
            Console.WriteLine(numeroElementos);

            //Agregar un rango de valores  
            List<Estudiante> lista1 = new List<Estudiante>
            {
                new Estudiante("Santiago",10,12),new Estudiante("Benito",18,15)
            };
            lista1.Add(new Estudiante("Pedro", 11, 16));
            Console.WriteLine(lista1.Count);

            //Agregar un AddRange el cual le puedo agregar una lista completa
            listaEstudiante2.AddRange(lista1);
            Console.WriteLine("El conteo de la lista de estudiante con el AddRange es: " + listaEstudiante2.Count);

            foreach (Estudiante item in listaEstudiante2)
            {
                Console.WriteLine(item.nombre);
            }

            Console.ReadLine();
        }
    }
}
