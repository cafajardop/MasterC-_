using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1POO
{
    public class Cuenta
    {
        private string titular { get; set; }
        private double cantidad { get; set; }

        //Propiedad titula (get y set)
        public string getTitular()
        {
            return titular;
        }
        public void setTitular(string titular)
        {
            this.titular = titular;
        }
        //Propiedad Cantidad (get set)
        public double getCantidad()
        {
            return cantidad;
        }
        public void setCantidad(double cantidad)
        {
            if (cantidad > 0)
                this.cantidad = cantidad;
            else
                this.cantidad = 0;
        }

        public void Ingresar(double cantidad)
        {
            this.cantidad = this.cantidad + cantidad;
        }
        public void Retirar(double cantidad)
        {
            this.cantidad = this.cantidad - cantidad;
        }

    }
}
