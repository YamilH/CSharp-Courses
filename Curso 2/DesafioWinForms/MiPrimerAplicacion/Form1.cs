using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class MiPrimerApp : Form
    {
        public MiPrimerApp()
        {
            InitializeComponent();
            this.Click += MiPrimerApp_Click;
            lblEtiqueta.MouseMove += lblEtiqueta_MouseMove;
            lblEtiqueta.MouseLeave += lblEtiqueta_MouseLeave;
            btnRun.Click += btnRun_Click;
        }

        private void MiPrimerApp_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void MiPrimerApp_FormClosed(object sender, EventArgs e)
        {
            MessageBox.Show("Chauu Chauu");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento Click", "Atención");
            //this.BackColor = Color.Blue;
            if (txtBox.Text == "")
                txtBox.BackColor = Color.Red;
            else
                txtBox.BackColor = System.Drawing.SystemColors.Control;
        }

        private void MiPrimerApp_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");
        }


        private void lblEtiqueta_MouseMove(object sender, MouseEventArgs e)
        {
            lblEtiqueta.BackColor = Color.Cyan;
            lblEtiqueta.Cursor = Cursors.Hand;
        }
        private void lblEtiqueta_MouseLeave(object sender, EventArgs e)
        {
            lblEtiqueta.BackColor = System.Drawing.SystemColors.Control;
            lblEtiqueta.Cursor = Cursors.Arrow;
        }


    }
}
