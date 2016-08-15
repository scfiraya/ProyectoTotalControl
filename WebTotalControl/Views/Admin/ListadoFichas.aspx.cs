using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using TotalControlLib;

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
                TotalControlLib.Ficha objconsulta = new TotalControlLib.Ficha();
                DataTable dtLisFichas = new DataTable();
                string consulta = "";

                dtLisFichas = objconsulta.TraerFichasBll(consulta);
                gvListas.DataSource = dtLisFichas;
                gvListas.DataBind();
                


            }
            catch (Exception ex)
            {
                Response.Redirect("~/views/Default.aspx");
            }
            
        }

        protected void gvListas_Click(object sender, EventArgs e)
        {

            ImageButton FilaEditar = sender as ImageButton;
            TableCell celda = (TableCell)FilaEditar.Parent;
            GridViewRow filaEditar = (GridViewRow)celda.Parent;
            string Resultado= "";
            lblPrueba.Text =Resultado;
            Resultado =gvListas.DataKeys[filaEditar.RowIndex]["IdFicha"].ToString();
           
            int  TraerNumFicha= Convert.ToInt32(Resultado);
            if (TraerNumFicha != 0)
            {
   
                Session["consulta"] = TraerNumFicha;
            }
            //lblNombre.Text = gvListas.DataKeys[filaEditar.RowIndex]["Nombre"].ToString();
            //lblAmbiente.Text = gvListas.DataKeys[filaEditar.RowIndex]["Ambiente"].ToString();
           

        }
    }

}