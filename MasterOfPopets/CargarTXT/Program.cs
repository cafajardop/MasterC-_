using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargarTXT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> info = ReadInfoTemporaly();

            foreach (var item in info)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }

        private static List<string> ReadInfoTemporaly()
        {
            List<string> infofile = new List<string>();
            using (StreamReader sr = new StreamReader(@"G:\CargaArchivos\TextPrueba.txt", false))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    infofile.Add(line);
                }
            }
            return infofile;
        }
    }
}
