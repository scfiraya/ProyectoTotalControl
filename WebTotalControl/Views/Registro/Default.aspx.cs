using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebTotalControl.Views.Registro
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btbIngeso_Click(object sender, EventArgs e)
        {

         try
            {

                TotalControlLib.Admin.Usuario objconsulta = new TotalControlLib.Admin.Usuario();
                DataTable dtUsuario = new DataTable();
                string Documento = "";
                
                string Consulta;
                Documento=txtDocumento.Text;

            
                dtUsuario = objconsulta.TraerUsuarioBll(Documento);

                Consulta=dtUsuario.Rows[0][0].ToString();
                Response.Redirect("DetalleIngreso.aspx", false);
                
                
            }
            catch (Exception )
                {
                  
                    lblMensaje.Text="Usuario No registrado";
                    
                }
        
        }
    }
}