using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Es una propiedad que permite que los objetos sean creados a partir de otros ya existentes, obteniendo caracteres
            //(métodos y atributos) similares a ls ya existentes

            Empleado emp = new Empleado();
            emp.nombre = "Carlos";
            emp.apPaterno = "Fajardo";
            emp.apMaterno = "Pedraza";
            emp.edad = 35;
            emp.sueldo = 10000000;
            emp.fechaContrato = DateTime.Now;
            string nombreCompleto =  emp.nombreCompleto();

            Console.WriteLine(nombreCompleto);
            Console.WriteLine("Fecha de contrato " + emp.fechaContrato + " sueldo " + emp.sueldo);

            Cliente oCliente = new Cliente();
            oCliente.nombre = "Joseph";
            oCliente.apPaterno = "De la Cruz";
            oCliente.apMaterno = "Aurelio";
            oCliente.edad = 22;
            oCliente.direccion = "ABC";
            oCliente.fechaNacimiento = DateTime.Now;

            string nombreCompl = oCliente.nombreCompleto();
            Console.WriteLine(nombreCompl);

            Console.ReadLine();

        }
    }
}
