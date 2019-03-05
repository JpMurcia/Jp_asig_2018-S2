using proyectoweb.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoweb.Views.ViewsUser
{
    public partial class Index : System.Web.UI.Page
    {
        indexController contorlador = new indexController();

        protected void Page_Load(object sender, EventArgs e)
        {
            llenar();
        }

        //public DataTable cosultarA()
        //{

        //    return activy.consul_acti(act);
        //}

        public void llenar() {
            DataTable dt = contorlador.dato_pag();
            descripcion.Text = dt.Rows[0]["Contenido"].ToString();
           
            //dt.Rows[0]["Nom_grupo"].ToString();
            //dt.Rows[0]["Creadores"].ToString();

        }
    }
}