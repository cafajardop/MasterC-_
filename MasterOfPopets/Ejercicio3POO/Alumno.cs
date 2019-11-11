﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3POO
{
    public class Alumno
    {
        private string nombreAlumno;
        private int nota1;
        private int nota2;
        private int nota3;
        private int nota4;


        //Metodos get y set para nombreAlumno

        public string getNombreAlumno()
        {
            return nombreAlumno;
        }
        public void setNombreAlumno(string nombreAlumno)
        {
            this.nombreAlumno = nombreAlumno;
        }
        //Metodos 
        public int getNota1()
        {
            return nota1;
        }
        public void setNota1(int nota1)
        {
            if (nota1 >= 0 && nota1 <= 20) this.nota1 = nota1;
            else this.nota1 = 0;
        }

        public int getNota2()
        {
            return nota2;
        }
        public void setNota2(int nota2)
        {
            if (nota2 >= 0 && nota2 <= 20) this.nota2 = nota2;
            else this.nota2 = 0;
        }

        public int getNota3()
        {
            return nota3;
        }
        public void setNota3(int nota3)
        {
            if (nota3 >= 0 && nota3 <= 20) this.nota3 = nota3;
            else this.nota3 = 0;
        }
        public int getNota4()
        {
            return nota4;
        }
        public void setNota4(int nota4)
        {
            if (nota4 >= 0 && nota4 <= 20) this.nota4 = nota4;
            else this.nota4 = 0;
        }

        public double promedioDosPrimerasNotas()
        {
            return (this.nota1 + this.nota2) / 2.0;
        }
        public double promeriosDosUltimasNotas()
        {
            return (this.nota3 + this.nota4) / 2.0;
        }
        public double promedioCuatroNotas()
        {
            return (this.nota1 + this.nota2 + this.nota3 + this.nota4) / 4.0;
        }

    }
}
