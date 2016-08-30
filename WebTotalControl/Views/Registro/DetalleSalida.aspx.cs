using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using TotalControlLib;

namespace WebTotalControl.Views.Registro
{
    public partial class DetalleSalida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int SesionActiva = (int)Session["SesionActiva1"];
            }
            catch (Exception)
            {
                Response.Redirect("~/Views/Default.aspx");
            }
        }
    }
}