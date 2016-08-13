using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebTotalControl.Views
{
    public partial class ListadoFichas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Se valida la seguridad de la pagina
            try
            {
                int SesionActiva = (int)Session["SesionActiva"];
            }
            catch (Exception ex)
            {
                Response.Redirect("~/views/Default.aspx");
            }
        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            TotalControlLib.Ficha objconsulta = new TotalControlLib.Ficha();
            DataTable dtFichas = new DataTable();
            string consulta = "";

            dtFichas = objconsulta.TraerFichasBll(consulta);
            gvListas.DataSource = dtFichas;
            gvListas.DataBind();
        }
    }

    }