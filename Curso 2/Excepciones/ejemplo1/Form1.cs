using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //int a, b, r;
            //try
            //{
            //    a = int.Parse(txt1.Text);
            //    b = int.Parse(txt2.Text);
            //    r = a / b;
            //    lblResultado.Text = "= " + r;
            //}

            int resultado;
            try
            {
                resultado = calcular();
                lblResultado.Text = "= " + resultado;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor cargar solo números..");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por cero..");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no reconocido.. Contactar a tu dev..");
            }
            finally
            {
                // instrucciones que se van a ejecutar si o si
                // operaciones sensibles
            }


        }

        private int calcular()
        {
            int a, b, r;
            try
            {
                a = int.Parse(txt1.Text);
                b = int.Parse(txt2.Text);
                r = a / b;
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
