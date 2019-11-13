using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListRecibeTodoTipoDato
{
    class Program
    {
        static void Main(string[] args)
        {
            //Puedo agregar de todo tipo de dato string , int etc...
            ArrayList arraylist = new ArrayList();
            arraylist.Add("Matematica");
            arraylist.Add(140);
            arraylist.Add(true);

            Console.WriteLine("El primer elemento " + arraylist[0]);
            Console.WriteLine("El segundo elemento " + arraylist[1]);
            Console.WriteLine("El tercer elemento " + arraylist[2]);

            arraylist.Insert(0, "Programacion");

            //Al arraylist si se recorre se debe colocar la palabra reservada var para que acepte cualquier tipo de dato
            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
