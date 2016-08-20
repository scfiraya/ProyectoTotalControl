using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebTotalControl.Views.Admin
{
    public partial class CreacionUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
            //Se valida la seguridad de la pagina
            try
            {
                int SesionActiva = (int)Session["SesionActiva"];

                if (!IsPostBack)
                {
                    TotalControlLib.Admin.Usuario objMostrarTipoDoc = new TotalControlLib.Admin.Usuario();

                    DataTable dtTipoDoc = new DataTable();
                    dtTipoDoc = objMostrarTipoDoc.TipoDocBll();
                    ddlTipoDoc.DataSource = dtTipoDoc;
                    ddlTipoDoc.DataTextField = "Tipo";
                    ddlTipoDoc.DataValueField = "IdTipoDocumento";
                    ddlTipoDoc.DataBind();

                    TotalControlLib.Admin.Usuario objMostrarCargo = new TotalControlLib.Admin.Usuario();

                    DataTable dtCargo = new DataTable();
                    dtTipoDoc = objMostrarCargo.Cargo();
                    ddlCargo.DataSource = dtTipoDoc;
                    ddlCargo.DataTextField = "Cargo";
                    ddlCargo.DataValueField = "IdTipoCargo";
                    ddlCargo.DataBind();


                    TotalControlLib.Admin.Usuario objMostrarRol = new TotalControlLib.Admin.Usuario();

                    DataTable dtRol = new DataTable();
                    dtRol = objMostrarRol.Rol();
                    ddlRol.DataSource = dtRol;
                    ddlRol.DataTextField = "NombreRol";
                    ddlRol.DataValueField = "IdRol";
                    ddlRol.DataBind();

                }

            }
            catch (Exception ex)
            {
                Response.Redirect("~/views/Default.aspx");
            }
        }        

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                //TotalControlLib.Admin.Usuario objInsertarLib = new TotalControlLib.Admin.Usuario();

                //string NomCom = txtNombre.Text;
                //string Apellido = txtApellido.Text;
                //int NumDoc = Convert.ToInt32(txtNumDoc.Text);
                //string Login = txtLogin.Text;
                //string Contrasena = txtContrasena.Text;
                //string Rcontrasena = txtRcontrasena.Text;

                //string TipoDoc = "";

                //if (ddlTipoDoc.Text.Equals(""))
                //{
                //    TipoDoc = "";
                //}
                //else
                //{
                //    TipoDoc = (ddlTipoDoc.Text);
                //}

                //string Rol = "";

                //if (ddlRol.Text.Equals(""))
                //{
                //    Rol = "";
                //}
                //else
                //{
                //    Rol = (ddlRol.Text);
                //}

                //bool Activo = cbEstado.Visible;

                //if (cbEstado.Checked == true)
                //{
                //    Activo = true;
                //}
                //else
                //{
                //    Activo = false;
                //}

                //string c1, c2;
                //c1 = txtContrasena.Text;
                //c2 = txtRcontrasena.Text;

                //if (c1 == c2)
                //{
                //    string Contra = txtContrasena.Text;

                //    objInsertarLib.InsertarUsuarioLib(NomCom, Apellido, NumDoc, Login, Contra, Activo, TipoDoc, Rol);

                //    lblValidacion.Text = "El registro se ingreso exitosamente.";
                //}
                //else
                //{
                //    lblValidacion.Text = "Las contraseñas no coinciden.";
                //}


            }
            catch (Exception ex)
            {
                lblValidacion.Text = "Error al ingresar el registro. Detalle del error: " + ex.Message.ToString();
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                TotalControlLib.Admin.Usuario objModificarLib = new TotalControlLib.Admin.Usuario();

                string NomCom = txtNombre.Text;
                int NumDoc = Convert.ToInt32(txtNumDoc.Text);

                objModificarLib.ModificarUsuarioLib(NomCom, NumDoc);
                lblValidacion.Text = "El registro se actualizo exitosamente.";
            }
            catch(Exception ex) 
            {
                lblValidacion.Text = "Error al guardar el registro. Detalle del error: " + ex.Message.ToString();
            }

        }

        //protected void btnEliminar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        TotalControlLib.Admin.Usuario objEliminarLib = new TotalControlLib.Admin.Usuario();

        //        int NumDoc = Convert.ToInt32(txtNumDoc.Text);

        //        objEliminarLib.EliminarUsuarioLib(NumDoc);
        //        lblValidacion.Text = "El registro se elimino exitosamente.";
        //    }
        //    catch (Exception ex)
        //    {
        //        lblValidacion.Text = "Error al eliminar el registro. Detalle del error: " + ex.Message.ToString();
        ////    }
        //}
    }
}