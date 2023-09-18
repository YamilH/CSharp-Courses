using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosControles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbColorFavorito.Items.Add("Verde");
            cbColorFavorito.Items.Add("Rojo");
            cbColorFavorito.Items.Add("Negro");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaDeNacimiento.Value;
            // Operador Ternario
            string chocolate = cbChocolate.Checked == true ? "Le gusta el chocolate" : "No le gusta el chocolate";
            string tipo;
            if (rbMuggle.Checked)
                tipo = "Muggle";
            else if (rbWizard.Checked)
                tipo = "Wizard";
            else
                tipo = "Squibs";
            string colorFavorito = cbColorFavorito.SelectedItem.ToString();
            string numeroFavorito = nNumero.Value.ToString();

            string mensaje = chocolate + ", es " + tipo + ", su color es " + colorFavorito + ", su número es: " + numeroFavorito;
            MessageBox.Show("Nombre: " + nombre + "Fecha: " + fecha + ", " + mensaje);
        }
    }
}
