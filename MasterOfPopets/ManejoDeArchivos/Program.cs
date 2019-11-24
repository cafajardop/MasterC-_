using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos el directorio
            string ruta = @"G:\CargaArchivos\Profesores";
            string rutaEstudiantes = @"G:\CargaArchivos\Alumnos";
            
            Directory.CreateDirectory(ruta);

            //Eliminar un directorio vacio si el contiene archivos no lo elimina
            //Directory.Delete(ruta);

            //Si lo quiero eliminar le paso el parametro true
            //Directory.Delete(ruta,true);

            //Si quiero enumerar los directorios el metodo se llama EnumerateDirectories
            List<string> lista =  Directory.EnumerateDirectories(ruta).ToList();

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }
            //Si quiero filtrar el directorio le paso el parametro con el que empiece  si quiero que termine le antepongo el asterisco *
            List<string> listaWhere = Directory.EnumerateDirectories(ruta,"P*").ToList();

            foreach (string item in listaWhere)
            {
                Console.WriteLine("Queda filtrado con: "  + item);
            }

            //Para leer archivos como excel power point txt
            List<string> leerArchivos =  Directory.EnumerateFiles(rutaEstudiantes).ToList();
            foreach (var item in leerArchivos)
            {
                Console.WriteLine("Leo solo archivos Excel, Power Point, txt etc" + item);
            }
            //Para filtar tambine puedo 
            List<string> leerArchivosFiltro = Directory.EnumerateFiles(rutaEstudiantes).ToList();
            foreach (var item in leerArchivosFiltro)
            {
                Console.WriteLine("Leo solo archivos Excel, Power Point, txt etc" + item);
            }
            //Directory Info
            DirectoryInfo dir = new DirectoryInfo(@"G:\CargaArchivos\Profesores");

            if (dir.Exists)
            {
                Console.WriteLine("Existe directorio");
            }
            else
            {
                Console.WriteLine("No existe");
            }

            //Dir.parent nos devuelve el nombre del directorio padre
            Console.WriteLine("Este es el nombre del directorio padre:" + dir.Parent);

            //Root nos devuelve la ruta
            Console.WriteLine("Nos devuelve la ruta " + dir.Root);

            //El metodo create nos crea un directorio nuevo si no existe
            DirectoryInfo dirCreate = new DirectoryInfo(@"G:\CargaArchivos\EntityFramework");
            dirCreate.Create();

            //Crear un archivo
            string rutaCreacion = @"G:\CargaArchivos\csharp.txt";
            //File.Create(rutaCreacion);
            //File.Delete(rutaCreacion);
            
            //Luego llenamos informacion definimos una lista 
            List<string> nombreLista = new List<string>();
            nombreLista.Add("Carlos");
            nombreLista.Add("Andres");
            nombreLista.Add("Fajardo");
            nombreLista.Add("Pedraza");

            //Leemos nuestro archivo creado de C# con el metodo AppendAllLines
            File.AppendAllLines(rutaCreacion, nombreLista);

            //Tenemos el metodo AppendAllText (permite agregar todo el codigo sin problema)
            string rutaCreacionAppend = @"G:\CargaArchivos\csharp.txt";
            string nombresAppend = "Carlos Es el mejor desarrollador";

            File.AppendAllText(rutaCreacionAppend, nombresAppend);


            Console.ReadLine();

        }
    }
}
