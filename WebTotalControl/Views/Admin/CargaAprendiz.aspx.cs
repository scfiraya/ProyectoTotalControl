using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTotalControl.Views
{
    public partial class CargaAprendiz : System.Web.UI.Page
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

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}