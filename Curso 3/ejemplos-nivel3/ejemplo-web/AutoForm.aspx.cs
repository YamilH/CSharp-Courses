using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace ejemplo_web
{
    public partial class AutoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ddlColores.Items.Add("Negro");
                ddlColores.Items.Add("Azul");
                ddlColores.Items.Add("Blanco");
            }

            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                List<Auto> temporal = (List<Auto>)Session["listaAutos"];
                Auto seleccionado = temporal.Find(x => x.Id == id);
                txtModelo.Text = seleccionado.Modelo;
                txtId.Text = seleccionado.Id.ToString();
                txtId.ReadOnly = true;
            }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Auto a = new Auto();
            a.Id = int.Parse(txtId.Text);
            a.Modelo = txtModelo.Text;
            a.Descripcion = txtDescripcion.Text;
            a.Color = ddlColores.SelectedValue;
            a.Fecha = DateTime.Parse(txtFecha.Text);
            a.Usado = chkUsado.Checked;

            if (rdbImportado.Checked)
                a.Importado = true;
            else if (rdbNacional.Checked)
                a.Importado = false;

            //aca pondria codigo para mandar a la base de datos llamando un metodo

            if (Session["listaAutos"] == null)
            {
                Session["listaAutos"] = new List<Auto>();
            }

            ((List<Auto>)Session["listaAutos"]).Add(a);

            //List<Auto> temporal = (List<Auto>)Session["listaAutos"];
            //temporal.Add(a);

            Response.Redirect("Default.aspx");

        }

        protected void rdbImportado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}