using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebTotalControl.Views.Admin
{
    public partial class ListadoUsuarios : System.Web.UI.Page
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

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            TotalControlLib.Admin.Usuario objBuscar = new TotalControlLib.Admin.Usuario();
            DataTable dtUsuario = new DataTable();
            string Documento = txtNumDoc.Text;

            dtUsuario = objBuscar.TraerUsuarioBll(Documento);
            
            gvBuscarUsuario.DataSource = dtUsuario;
            gvBuscarUsuario.DataBind();
        }
    }
}