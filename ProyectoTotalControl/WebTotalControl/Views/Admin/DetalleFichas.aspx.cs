using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using TotalControlLib;
using Entidades;

namespace WebTotalControl.Views
{
    public partial class DetalleFichas : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        
            TotalControlLib.Ficha objDetalleBll = new TotalControlLib.Ficha();
            DataTable dtFichas = new DataTable();

            int TraerFicha = (int)Session["consulta"];
            string Detalle = Convert.ToString(TraerFicha);

               //Se crea un data table que muestra los usuarios correspondientes a la ficha 
            dtFichas = objDetalleBll.TraerDetalleFichaBll(Detalle);
            gvDetalle.DataSource = dtFichas;
            gvDetalle.DataBind();

            TotalControlLib.Ficha objFichaBll = new TotalControlLib.Ficha();

            int NumFicha = TraerFicha;
            ProgramaEntidad ProgramaE = objFichaBll.TraerNumFicha(NumFicha);
            UsuarioEntidad Usuario=objFichaBll.TraerDatosFichaBll(NumFicha);

            lblPrograma.Text = ProgramaE.NombrePrograma;
            lblNombre.Text =Usuario.Nombre+ Usuario.Apellido;
 
        }

        protected void Regresar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ListadoFichas.aspx", false);
        }
    }
}