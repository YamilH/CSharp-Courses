using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindows2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string resultado = ConstruirResultado();

            txtResultado.Text = resultado;
        }

        private bool ValidarCampos()
        {
            bool camposValidos = true;

            camposValidos &= ValidarCampoNoVacio(txtApellido);
            camposValidos &= ValidarCampoNoVacio(txtNombre);
            camposValidos &= ValidarCampoNoVacio(txtDireccion);
            camposValidos &= ValidarEdad();

            return camposValidos;
        }

        private bool ValidarCampoNoVacio(TextBox campo)
        {
            if (string.IsNullOrWhiteSpace(campo.Text))
            {
                campo.BackColor = System.Drawing.Color.Red;
                return false;
            }
            else
            {
                campo.BackColor = System.Drawing.Color.White;
                return true;
            }
        }

        private bool ValidarEdad()
        {
            if (!int.TryParse(txtEdad.Text, out _))
            {
                txtEdad.BackColor = System.Drawing.Color.Red;
                return false;
            }
            else
            {
                txtEdad.BackColor = System.Drawing.Color.White;
                return true;
            }
        }



        private string ConstruirResultado()
        {
            string resultado = $"Apellido y Nombre: {txtApellido.Text.ToUpper()}, {txtNombre.Text.ToUpper()}" +
                              $"{Environment.NewLine}Edad: {txtEdad.Text}" +
                              $"{Environment.NewLine}Dirección: {txtDireccion.Text.ToUpper()}";

            return resultado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
