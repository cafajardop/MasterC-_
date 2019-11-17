using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionsParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Listas propiedades y metodos
            Cliente oCliente1 = new Cliente("Pedro","Garcia","Romero",19,"ACB Colombia");
            Cliente oCliente2 = new Cliente("Carlos", "Andres", "Fajardo", 18, "ACB Colombia");
            Cliente oCliente3 = new Cliente("Valeria", "Andrea", "Fajardo", 17, "ACB Colombia");
            Cliente oCliente4 = new Cliente("Issa", "Julieta", "Fajardo", 16, "ACB Colombia");
            Cliente oCliente5 = new Cliente("Ximena", "Bonilla", "Ruiz", 15, "ACB Colombia");

            List<Cliente> ListaClientes = new List<Cliente>
            {
                oCliente1,oCliente2,oCliente3,oCliente4,oCliente5
            };

            ListaClientes.Add(new Cliente("Nelly", "Sarmiento", "Garcia", 40, "DER"));

            foreach (Cliente item in ListaClientes)
            {
                Console.WriteLine(item.nombre);
            }

            List<Cliente> oCliente6 = new List<Cliente>
            {
                new Cliente("Adrian","Ugarriza","Perez",20,"Ceo"),
                new Cliente("Rodriguez","Cuba","Alfonso",20,"oia")
            };
            
            //Agregamos otraa lista
            oCliente6.AddRange(ListaClientes);

            //Metodo borrar lista
            oCliente6.Clear();

            //Metodo Find devuelve solo el primero
           Cliente oClienteResultado =  ListaClientes.Find(p => p.nombre.Equals("Nelly"));

            if (oClienteResultado != null)
                Console.WriteLine(oClienteResultado.apPaterno);
            else
                Console.WriteLine("No se encontro el objeto");

            //Metodo FindAll para traer todos los nombres que comienzan por a
            List<Cliente> ListaClientesTodos = ListaClientes.FindAll(p => p.nombre.StartsWith("A"));
            foreach (Cliente cliente in ListaClientesTodos)
            {
                Console.WriteLine(cliente.nombre);
            }

            //Agregar en la primera columna metodo Insert
            ListaClientesTodos.Insert(0, new Cliente("Carlos", "Fajardo", "Pedraza", 35, "La serena"));

            foreach (Cliente item in oCliente6)
            {
                Console.WriteLine("Estoy agregando el addrange: " + item.nombre);
            }

            //Agregamos en la posicion que querramos
            ListaClientesTodos.InsertRange(2, ListaClientes);

            //Borrar con los que terminen con n (RemoveAll)
            ListaClientes.RemoveAll(p => p.nombre.EndsWith("n"));

            //Si queremos borrar un solo cliente con find entonces hacemos lo siguiente 
            Cliente oClienteBorrar = ListaClientes.Find(p => p.nombre.EndsWith("o"));
            ListaClientes.Remove(oClienteBorrar);

            //Si queremos buscar por posicion lo hacemos con RemoveAt
            ListaClientes.RemoveAt(0);

            Console.ReadLine();
        }
    }
}