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
            List<string> lista = Directory.EnumerateDirectories(ruta).ToList();

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }
            //Si quiero filtrar el directorio le paso el parametro con el que empiece  si quiero que termine le antepongo el asterisco *
            List<string> listaWhere = Directory.EnumerateDirectories(ruta, "P*").ToList();

            foreach (string item in listaWhere)
            {
                Console.WriteLine("Queda filtrado con: " + item);
            }

            //Para leer archivos como excel power point txt
            List<string> leerArchivos = Directory.EnumerateFiles(rutaEstudiantes).ToList();
            foreach (var item in leerArchivos)
            {
                Console.WriteLine("Leo solo archivos Excel, Power Point, txt etc" + item);
            }
            //Para filtar tambine puedo 
            List<string> leerArchivosFiltro = Directory.EnumerateFiles(rutaEstudiantes).ToList();
            foreach (string item in leerArchivosFiltro)
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

            //Sacar el directorio actual
            string directorioActual = Directory.GetCurrentDirectory();
            Console.WriteLine("Directorio Actual" + directorioActual);

            //Para verificar en que ruta se encuentra compilando nuestra aplicacion ejemplo en c/:
            string unidad = Directory.GetDirectoryRoot(directorioActual);

            Console.WriteLine("Unidad " + unidad);

            //Para mover un directorio es decir una carpeta a otro parte 
            string rutaInicio = @"G:\CargaArchivos\Profesores";
            string rutaFinal = @"G:\CargaArchivos\RutaMover";

            Directory.Move(rutaInicio, rutaFinal);

            //File.Copy mover un archivo
            string rutaOrigen1 = @"G:\CargaArchivos\csharp.txt";
            string rutaDestino2 = @"G:\CargaArchivos\RutaMoverFileCopy";

            File.Copy(rutaOrigen1, rutaDestino2);

            //File.Create
            string rutaFileCreate = @"G:\CargaArchivos\PruebaFileCreate.txt";
            //El using y streamwrinter sirve eliminar el archivo crear uno nuevo y sobreescribirlo
            using (StreamWriter sw = File.CreateText(rutaFileCreate))
            {
                sw.Write("Hola como estas!!");
            }

            //Para borrar un archivo ojo no una carpeta por que para la carpeta esta el metodo Directory.Delete y este es 
            //File.Delete que sirve es para borrar el txt
            File.Delete(rutaFileCreate);

            //Para mover un archivo FileMove
            string rutaMove = @"G:\CargaArchivos\move.txt";
            string rutaDestinoMove = @"G:\CargaArchivos\Mover\move.txt";

            File.Move(rutaMove, rutaDestinoMove);
            //File.Encrypt
            //File.Encrypt()

            //Metodo ReadAllBytes => Devuelve un array de bites y podemos capturar una imagen
            string rutaImagenes = @"G:\CargaArchivos\Imagenes\Bebe.jpg";
            string rutaDestinoImagen = @"G:\CargaArchivos\ImagenReadAllBytes\Bebe.jpg";

            byte[] archivo = File.ReadAllBytes(rutaImagenes);
            File.WriteAllBytes(rutaDestinoImagen, archivo);

            //Escribir en un archivo con WriteAllText
            string rutaWriteAllText = @"G:\CargaArchivos\WriteAllText.txt";
            string contenidoWAT = "Este archivo se escribe con writealltext";

            File.WriteAllText(rutaWriteAllText, contenidoWAT);

            //Para leer el archivo lo hago con ReadAllText()
            string rutaDestino = @"G:\CargaArchivos\contenido.txt";
            string contenidoArchivo = File.ReadAllText(rutaWriteAllText);
            File.WriteAllText(rutaDestino, contenidoArchivo);

            //Leer un archivo File.ReadAllLines => Retorna un array de string
            string rutaFileReadLines = @"G:\CargaArchivos\contenido.txt";
            string[] lineasFileReadAllLines = File.ReadAllLines(rutaFileReadLines);

            foreach (string lineas in lineasFileReadAllLines)
            {
                Console.WriteLine("Voy a leer las lineas en un FileReadAllLines" + lineas);
            }

            //File Info nos sirve para saber las propiedades del archivo
            FileInfo f = new FileInfo(rutaFileReadLines);
            Console.WriteLine(f.Exists);
            bool Existe = f.Exists;
            Console.WriteLine(f.Length);//Devuelve la longitud el peso que tiene el archivo
            Console.WriteLine(f.Directory);//Devuelve el directorio o la carpeta que se encuentra el archivo
            Console.WriteLine(f.Name);//Obtiene el nombre del archivo con su extension
            Console.ReadLine();
        }
    }
}
