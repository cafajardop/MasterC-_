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

            foreach (Cliente item in oCliente6)
            {
                Console.WriteLine("Estoy agregando el addrange: " + item.nombre);
            }

            Console.ReadLine();
        }
    }
}