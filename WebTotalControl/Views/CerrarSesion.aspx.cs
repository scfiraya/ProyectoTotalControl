using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTotalControl.Views
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

             Session["SesionInactiva"] = -1;
             Session.Abandon();
             Response.Redirect("Default.aspx");
           
           
        }
    }
}