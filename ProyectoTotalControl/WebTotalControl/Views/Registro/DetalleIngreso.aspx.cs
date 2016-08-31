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
    public partial class DetalleIngreso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int SesionActiva = (int)Session["SesionActiva1"];

                if (!IsPostBack)
                {
                    TotalControlLib.Registro.Ingreso objSeccion = new TotalControlLib.Registro.Ingreso();

                    DataTable dtSeccion = new DataTable();
                    dtSeccion = objSeccion.SeccionLib();
                    dllSeccion.DataSource = dtSeccion;
                    dllSeccion.DataTextField = "Nombre";
                    dllSeccion.DataValueField = "IdSeccion";
                    dllSeccion.DataBind();
                }

                DataTable dtIngreso = (DataTable)Session["consultaa"];

                lblNombre.Text = dtIngreso.Rows[0][0].ToString();
                lblNumDoc.Text = dtIngreso.Rows[0][1].ToString();
                lblCargo.Text = dtIngreso.Rows[0][2].ToString();
                lblFicha.Text = dtIngreso.Rows[0][3].ToString();
            }
            catch (Exception)
            {
                Response.Redirect("~/Views/Default.aspx");
            }
        }

        protected void btnRegisNewDis_Click(object sender, EventArgs e)
        {

            int NumDoc = Convert.ToInt32(lblNumDoc.Text);

            int TraerNumDoc = Convert.ToInt32(NumDoc);

            if (TraerNumDoc != 0)
            {

                Session["consulta"] = TraerNumDoc;
            }

            Response.Redirect("DetalleDispositivo.aspx", false);

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}