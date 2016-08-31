using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebTotalControl.Views
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {

            try
            {
                
                TotalControlLib.Admin.Usuario objconsulta = new TotalControlLib.Admin.Usuario();
                DataTable dtUsuario = new DataTable();
                string NombreUsuario = "";
                string Contrasena = "";
                string Rol;
                           
                NombreUsuario = txtUsuario.Text;
                Contrasena = txtContraseña.Text;
                dtUsuario = objconsulta.TraerIngresoUsuarioBll(NombreUsuario,Contrasena);

                Rol=dtUsuario.Rows[0][0].ToString();

                if (Rol=="Administrador")
                {
                   
                    Response.Redirect("Admin/Default.aspx", false);

                    Session["SesionActiva"] = 1;
                }
                else {
                    if (Rol=="Registrador" )
                    {
                        Response.Redirect("Registro/Default.aspx", false);
                        Session["SesionRegis"] = 1;
                    }
                }
            }
            catch (Exception )
                {
                  
                    lblError.Text = "Datos incorrectos";
                    
                }
        }

        protected void lbtOlvido_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Recuperacion/CambioClave.aspx");
        }
    }
}