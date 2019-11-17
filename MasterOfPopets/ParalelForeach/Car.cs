using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ParalelForeach
{
    class Car
    {
        public int KMPorHora { get; private set; }
        public string Modelo { get; private set; }
        public Car(string modelo)
        {
            this.Modelo = modelo;
            this.KMPorHora = 0;
        }
        public string Encender()
        {
            return String.Format("El coche {0} ha sido encendido;......", this.Modelo);
        }
        public void acelerar(int valor)
        {
            this.KMPorHora = this.KMPorHora + valor;
        }
        public void desacelerar(int valor)
        {
            this.KMPorHora = this.KMPorHora - valor;
        }

    }
}
