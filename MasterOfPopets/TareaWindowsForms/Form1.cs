using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btbMostrar_Click(object sender, EventArgs e)
        {
            string respuesta = txtRespuesta.Text;

            lblRespuesta.Text = "El valor de la respuesta es" + respuesta;
        }

        private void btnNumeric_Click(object sender, EventArgs e)
        {
            decimal respuesta = nudRespuesta.Value;

            lblRespuesta2.Text = "El valor del dato del NumericUpdown es: " + respuesta;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblRespuesta.Text = "";
            lblRespuesta2.Text = "";
            txtRespuesta.Text = "";
            nudRespuesta.Value = 0;
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFecha.Value;
            lblFecha.Text = "La fecha correcta es " + fecha;
        }
    }
}
