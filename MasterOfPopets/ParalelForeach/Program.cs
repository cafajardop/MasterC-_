using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParalelForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primer ejemplo de paralel foreach

            //List<Car> Autos = new List<Car>();
            //Autos.Add(new Car("Aston Martin"));
            //Autos.Add(new Car("McLaren"));
            //Autos.Add(new Car("Corvette ZR1 Centennial"));

            //Random r = new Random();

            //do
            //{
            //    Parallel.ForEach(Autos, auto =>
            //    {
            //        Console.WriteLine(auto.Encender());
            //        auto.acelerar(r.Next(0, 300));
            //        Console.WriteLine("El coche {0} esta corriendo a {1} kmph", auto.Modelo, auto.KMPorHora);
            //    });
            //    Thread.Sleep(3000);
            //} while (true);

            //segundo ejemplo de paralel foreach

            int Count_Step = -1;
            string[] lines = new string[]
            {
                    "0",
                    "1",
                    "2",
                    "3",
                    "4",
                    "5",
                    "6",
                    "7",
                    "8",
                    "9",
                    "10",
                    "11",
                    "12",
                    "13",
                    "14",
                    "15",
                    "16",
                    "17",
                    "18",
                    "19"
            };

            List<string> list_lines = new List<string>(lines);

            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.MaxDegreeOfParallelism = 3;

            Parallel.ForEach(list_lines, parallelOptions, (line, state, index) =>
            {
                if (Count_Step == 10)
                    state.Stop();
                Count_Step++;
                Console.WriteLine(index + " : " + line + " : " + Count_Step);
                //Thread.Sleep(5000);
            });

            Console.ReadLine();
        }
    }
}
