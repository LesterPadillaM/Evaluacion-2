using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "" || txtcuenta.Text == "" || txtnota1.Text == "" || txtnota2.Text == "" || txtnota3.Text == "" || txtnota4.Text == "")
            {
                MessageBox.Show("Datos Incompletos");
            }
            else
            {
                Alumno Alum = new Alumno();
                Alum.Nombre = txtnombre.Text;
                Alum.Cuenta = Convert.ToInt64(txtcuenta.Text);
                Alum.Nota1 = Convert.ToInt32(txtnota1.Text);
                Alum.Nota2 = Convert.ToInt32(txtnota2.Text);
                Alum.Nota3 = Convert.ToInt32(txtnota3.Text);
                Alum.Nota4 = Convert.ToInt32(txtnota4.Text);

                MessageBox.Show("El promedio del alumno "+Alum.Nombre +" con el numero de Cuenta "+Alum.Cuenta+" es de " + Convert.ToString(Alum.DevolverPromedio()));
                MessageBox.Show("El Alumno " + Alum.AproboOReprobo());
                txtnombre.Enabled = false;
                txtcuenta.Enabled = false;
                txtnota1.Enabled = false;
                txtnota2.Enabled = false;
                txtnota3.Enabled = false;
                txtnota4.Enabled = false;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcuenta.Text = "";
            txtnombre.Text = "";
            txtnota1.Text = "";
            txtnota2.Text = "";
            txtnota3.Text = "";
            txtnota4.Text = "";
            txtnombre.Enabled = true;
            txtcuenta.Enabled = true;
            txtnota1.Enabled = true;
            txtnota2.Enabled = true;
            txtnota3.Enabled = true;
            txtnota4.Enabled = true;
        }

        private void txtcuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
      if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtnota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
      if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtnota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
      if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtnota3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
      if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtnota4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
      if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
