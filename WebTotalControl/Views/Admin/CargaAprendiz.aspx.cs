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
            //TotalControlLib.Admin.Aprendiz objInsertar = new TotalControlLib.Admin.Aprendiz();


            //string NomCom = txtNomAprendiz.Text;
            //int NumDoc = Convert.ToInt32(txtNumDoc.Text);

            //int TipoDoc = 0;

            //if (ddlTipoDocumento.Text.Equals("Tipo"))
            //{
            //    TipoDoc = 0;
            //}
            //else
            //{

            //    TipoDoc = Convert.ToInt32((ddlTipoDocumento.Text));
            //}

            //int NumFicha = 0;

            //if (ddlNumFicha.Text.Equals("NumFicha"))
            //{
            //    NumFicha = 0;
            //}
            //else
            //{
            //    NumFicha = Convert.ToInt32((ddlNumFicha.Text));
            //}

            //objInsertar.InsertarAprendizBll(NumDoc, NomCom, TipoDoc, NumFicha);

            //lblNomAprendiz.Text = "Carga Exitosa";
        }
    }
}