using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace winform_app
{
    public partial class frmAltaPokemon : Form
    {
        private Pokemon pokemon = null;
        private OpenFileDialog archivo = null;

        public frmAltaPokemon()
        {
            InitializeComponent();
        }
        public frmAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //declaraciones dominio
            //Pokemon poke = new Pokemon();
            //declaracion negocio
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                if(pokemon == null)
                    pokemon = new Pokemon();
                //carga del objeto
                pokemon.Numero = int.Parse(txtNumero.Text);
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                pokemon.UrlImagen = txtUrlImagen.Text;
                pokemon.Tipo = (Elemento)cbTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cbDebilidad.SelectedItem;

                //mandarlo a la base de datos

                if(pokemon.Id != 0)
                {
                negocio.modificar(pokemon);
                MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                negocio.agregar(pokemon);
                MessageBox.Show("Agregado exitosamente");
                }

                //guardo imagen si la levantó localmente:
                if(archivo != null && !(txtUrlImagen.Text.Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                //para cargar las lista desplegables
                cbTipo.DataSource = elementoNegocio.listar();
                cbTipo.ValueMember = "Id";
                cbTipo.DisplayMember = "Descripcion";
                cbDebilidad.DataSource = elementoNegocio.listar();
                cbDebilidad.ValueMember = "Id";
                cbDebilidad.DisplayMember = "Descripcion";

                if (pokemon != null)
                {
                    txtNumero.Text = pokemon.Numero.ToString();
                    txtNombre.Text = pokemon.Nombre;
                    txtDescripcion.Text = pokemon.Descripcion;
                    cargarImagen(pokemon.UrlImagen);
                    txtUrlImagen.Text = pokemon.UrlImagen;
                    cbTipo.SelectedValue = pokemon.Tipo.Id;
                    cbDebilidad.SelectedValue = pokemon.Debilidad.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbPokemon.Load(imagen);
            }
            catch (Exception ex)
            {

                pbPokemon.Load("https://thinkfirstcommunication.com/wp-content/uploads/2022/05/placeholder-1-1.png");
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg | png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //guardado de imagen
               // File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
            }
        }
    }
}
