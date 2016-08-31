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
    public partial class DetalleVisitante1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int SesionActiva = (int)Session["SesionActiva1"];

                if (!IsPostBack)
                {
                    TotalControlLib.Registro.Ingreso objMostrarTipoDoc = new TotalControlLib.Registro.Ingreso();

                    DataTable dtTipoDoc = new DataTable();
                    dtTipoDoc = objMostrarTipoDoc.TipoDocBll();
                    ddlTipoDoc.DataSource = dtTipoDoc;
                    ddlTipoDoc.DataTextField = "Tipo";
                    ddlTipoDoc.DataValueField = "IdTipoDocumento";
                    ddlTipoDoc.DataBind();
                }
                if (!IsPostBack)
                {

                    TotalControlLib.Admin.Usuario objMostrarCargo = new TotalControlLib.Admin.Usuario();

                    DataTable dtCargo = new DataTable();
                    dtCargo = objMostrarCargo.Cargo();
                    ddlCargo.DataSource = dtCargo;
                    ddlCargo.DataTextField = "Cargo";
                    ddlCargo.DataValueField = "IdTipoCargo";
                    ddlCargo.DataBind();
                }

            }
            catch (Exception)
            {
                Response.Redirect("~/Views/Default.aspx");
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                TotalControlLib.Registro.Ingreso objInsertarLib = new TotalControlLib.Registro.Ingreso();

                int TipoDoc = Convert.ToInt32(ddlTipoDoc.Text);
                string NumeroIdentificacion = txtNumDoc.Text;
                string Nombre = txtNombre.Text;
                string Apellido = txtApellido.Text;
                int Cargo = Convert.ToInt32(ddlCargo.Text);

                objInsertarLib.InsertarUsuarioBll(NumeroIdentificacion, Nombre, Apellido, TipoDoc, Cargo);
                lblValidacion.Text = "El registro se ingreso exitosamente.";
            }
            catch (Exception ex)
            {
                lblValidacion.Text = "Error al guardar el registro. Detalle del error: " + ex.Message.ToString();
            }
        }

        protected void btnRegisNewDis_Click(object sender, EventArgs e)
        {
            Response.Redirect("DetalleDispositivo.aspx", false);
        }
    }
}