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
    public partial class Default : System.Web.UI.Page
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

        protected void btnCrearVisitante_Click(object sender, EventArgs e)
        {

            Response.Redirect("DetalleVisitante.aspx", false);
        }


        protected void btnIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                TotalControlLib.Registro.Ingreso objIngreso = new TotalControlLib.Registro.Ingreso();

                DataTable dtIngreso = new DataTable();

                string NumDoc = "";

                DataTable dtConsulta = (DataTable)Session["consultaa"];

                NumDoc = txtDocumento.Text;

                dtIngreso = objIngreso.TraerIngresoLib(NumDoc);

                Session["consultaa"] = dtIngreso;

                Response.Redirect("DetalleIngreso.aspx", false);
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "El usuario no existe, por favor regístrese. Detalle del error: " + ex.Message.ToString();
            }
        }
    }
}