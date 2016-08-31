using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTotalControl.Recuperacion
{
    public partial class CambioClave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCedula.Focus();
            txtNueva.Focus();
        }
         
        protected void btnValidar_Click(object sender, EventArgs e)
        {            
            try
            {

                string cedula = txtCedula.Text.Trim();

                TotalControlLib.Admin.Usuario objValidaCedula = new TotalControlLib.Admin.Usuario();

                string Valida = objValidaCedula.ValidaCedulaBLL(cedula);

                if (Valida == cedula)
                {
                    pnlValidacion.Visible = false;

                    pnlCambio.Visible = true;
                }

                else
                {
                    lblError.Text = "Lo sentimos. El número de cédula ingresado no existe.";                    
                }

            }

            catch (Exception error)
            {

                lblError.Text = "Lo sentimos. Ha ocurrido un error. Código del error: "+error.ToString();

            }

        }

        protected void btnCambiar_Click(object sender, EventArgs e)
        {

            try {

                string Contra = txtNueva.Text;
                string ConfContra = txtConfirma.Text;

                if (Contra == ConfContra)
                {

                    string cedula = txtCedula.Text.Trim();

                    string password = txtConfirma.Text;

                    TotalControlLib.Admin.Usuario objCambiaPassword = new TotalControlLib.Admin.Usuario();

                    objCambiaPassword.CambiaPasswordBLL(cedula, password);

                    lblNovedad.CssClass = "label label-success";

                    lblNovedad.Text = "La contraseña ha sido modificada exitosamente.";

                    txtNueva.Text = "";
                    
                    txtConfirma.Text = "";

                    lbtIniciarSesion.Visible = true;                 

                }
                     
                else
                {

                    lblNovedad.CssClass = "label label-warning";

                    lblNovedad.Text = "Las contraseñas no coinciden. Intenta de nuevo.";

                }

            }

            catch (Exception error)
            {
                lblNovedad.Text = "Lo sentimos, ha ocurrido un error. Código del error: " + error.ToString();
            }
        }

        protected void lbtIniciarSesion_Click(object sender, EventArgs e)
        {

            Response.Redirect("../Views/Default.aspx");

        }
    }
}