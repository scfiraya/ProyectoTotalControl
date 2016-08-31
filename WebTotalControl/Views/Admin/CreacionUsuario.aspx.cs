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
                    //Carga de DropDownList's del panel de aprendiz

                    TotalControlLib.Admin.Usuario objMostrarTipoDoc = new TotalControlLib.Admin.Usuario();

                    DataTable dtTipoDoc = new DataTable();
                    dtTipoDoc = objMostrarTipoDoc.TipoDocBll();
                    ddlTipoDoc.DataSource = dtTipoDoc;
                    ddlTipoDoc.DataTextField = "Tipo";
                    ddlTipoDoc.DataValueField = "IdTipoDocumento";
                    ddlTipoDoc.DataBind();
                    
                    //ListItem lst = new ListItem("Seleccionar...", "0");
                    //ddlPrograma.Items.Add(lst);
                    //ddlPrograma.Items.Insert(ddlPrograma.Items.Count - (ddlPrograma.Items.Count), lst); 
  
                    TotalControlLib.Admin.Usuario objMostrarRol = new TotalControlLib.Admin.Usuario();

                    DataTable dtRol = new DataTable();
                    dtRol = objMostrarRol.Rol();
                    ddlRol.DataSource = dtRol;
                    ddlRol.DataTextField = "NombreRol";
                    ddlRol.DataValueField = "IdRol";
                    ddlRol.DataBind();

                    TotalControlLib.Admin.Usuario objFichaPrograma = new TotalControlLib.Admin.Usuario();

                    DataTable dtFichaPrograma = new DataTable();
                    dtFichaPrograma = objFichaPrograma.FichaProgramaBLL();
                    ddlFichaPrograma.DataSource = dtFichaPrograma;
                    ddlFichaPrograma.DataTextField = "FichaPrograma";
                    ddlFichaPrograma.DataValueField = "IdFicha";
                    ddlFichaPrograma.DataBind();

                }

            }
            catch (Exception ex)
            {
                Response.Redirect("~/Views/Default.aspx");
            }
        }

        protected void ddlCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

            int cargo = Convert.ToInt32(ddlCargo.SelectedValue);

            switch (cargo)
            {

                case 0:
                    {
                        pnlDatos.Visible = false;
                        break;
                    }

                case 200:
                    {
                        LimpiarCampos(this);
                        pnlDatos.Visible = true;

                        lblFichaPrograma.Visible = true;
                        ddlFichaPrograma.Visible = true;

                        lblFichaPrograma.Visible = true;
                        ddlFichaPrograma.Visible = true;

                        lblLogin.Visible = false;
                        txtLogin.Visible = false;

                        lblContrasena.Visible = false;
                        txtContrasena.Visible = false;

                        lblRcontrasena.Visible = false;
                        txtRcontrasena.Visible = false;

                        break;
                    }

                case 201:
                    {
                        LimpiarCampos(this);
                        pnlDatos.Visible = true;

                        lblFichaPrograma.Visible = true;
                        ddlFichaPrograma.Visible = true;

                        lblLogin.Visible = true;
                        txtLogin.Visible = true;

                        lblContrasena.Visible = true;
                        txtContrasena.Visible = true;

                        lblRcontrasena.Visible = true;
                        txtRcontrasena.Visible = true;

                        break;
                    }

                case 202:
                    {
                        LimpiarCampos(this);
                        pnlDatos.Visible = true;

                        lblFichaPrograma.Visible = false;
                        ddlFichaPrograma.Visible = false;

                        lblLogin.Visible = true;
                        txtLogin.Visible = true;

                        lblContrasena.Visible = true;
                        txtContrasena.Visible = true;

                        lblRcontrasena.Visible = true;
                        txtRcontrasena.Visible = true;


                        break;
                    }
            }
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                TotalControlLib.Admin.Usuario objInsertarLib = new TotalControlLib.Admin.Usuario();

                string NumDoc = txtNumDoc.Text;
                string NomCom = txtNombre.Text;
                string Apellido = txtApellido.Text;
                int TipoDoc = Convert.ToInt32(ddlTipoDoc.SelectedValue);
                int Cargo = Convert.ToInt32(ddlCargo.SelectedValue);                
                int Rol = Convert.ToInt32(ddlRol.SelectedValue);
                int FichaPrograma = Convert.ToInt32(ddlFichaPrograma.SelectedValue);     
                string Login = txtLogin.Text;
                string Contrasena = txtContrasena.Text;
                string Rcontrasena = txtRcontrasena.Text;                                          

                if (Contrasena == Rcontrasena)
                {
                    string Contra = txtContrasena.Text;

                    objInsertarLib.InsertarUsuarioLib(NumDoc, NomCom, Apellido, TipoDoc, Cargo, Rol, Login, Contra, FichaPrograma);

                    lblValidacion.CssClass = "label label-success";

                    lblValidacion.Text = "El registro se guardó exitosamente.";

                    //Limpiar TextBox y CheckBox del formulario.
                    LimpiarCampos(this);
                }
                else
                {
                    lblValidacion.CssClass = "label label-danger";

                    lblValidacion.Text = "Las contraseñas ingresadas no coinciden.";
                } 

            }
            catch (Exception ex)
            {
                lblValidacion.CssClass = "label label-danger form-group label-control";

                lblValidacion.Text = "Error al ingresar el registro. Detalle del error: " + ex.Message.ToString();
            }
        }


        private void LimpiarCampos(Control CreacionUsuario)
        {
            foreach (Control oControls in CreacionUsuario.Controls)
            {
                if (oControls is TextBox)
                {
                    ((TextBox)oControls).Text = "";
                }

                if (oControls is CheckBox)
                {
                    ((CheckBox)oControls).Checked = false;
                }
                
                if (oControls.Controls.Count > 0)
                {
                    LimpiarCampos(oControls);
                }

            }

        }

        protected void lbtIniciaSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Default.aspx");
        }
    
    }
}