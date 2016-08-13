using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace WebTotalControl.Views
{
    public partial class DetalleFichas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            TotalControlLib.Ficha objDetallesBll = new TotalControlLib.Ficha();
            DataTable dtFichas = new DataTable();
            string Detalle = "";
            lblEncabezado.Text = "";
          

            dtFichas = objDetallesBll.TraerDetalleFichaBll(Detalle);
            gvDetalle.DataSource = dtFichas;
            gvDetalle.DataBind();



        }
    }
}