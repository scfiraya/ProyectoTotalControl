using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebTotalControl.Views.Registro
{
    public partial class DetalleDispositivo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int SesionActiva = (int)Session["SesionActiva1"];

                if (!IsPostBack)
                {
                    TotalControlLib.Registro.Ingreso objMostrarTipoDis = new TotalControlLib.Registro.Ingreso();

                    DataTable dtTipoDis = new DataTable();
                    dtTipoDis = objMostrarTipoDis.TipoDisBll();
                    ddlTipoDis.DataSource = dtTipoDis;
                    ddlTipoDis.DataTextField = "Nombre";
                    ddlTipoDis.DataValueField = "IdTipoDispositivo";
                    ddlTipoDis.DataBind();
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Views/Default.aspx");
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                TotalControlLib.Registro.Ingreso objInsertarDis = new TotalControlLib.Registro.Ingreso();


                int TipoDis = Convert.ToInt32(ddlTipoDis.Text);
                string Serial = txtSerial.Text;
                string Marca = txtMarca.Text;
                string Descripcion = txtDescripcion.Text;
                int CargadorB = 0;

                bool Cargador = cbCargador.Visible;

                if (cbCargador.Checked == true)
                {
                    Cargador = true;
                    CargadorB = 1;
                }
                else
                {
                    Cargador = false;
                    CargadorB = 0;
                }

                objInsertarDis.InsertarDispositivoLib(Serial, Marca, CargadorB, Descripcion, TipoDis);

                lblValidacion.Text = "El registro se guardo exitosamente";
            }
            catch (Exception ex)
            {
                lblValidacion.Text = "Error al guardar. Detalledel error: " + ex.Message.ToString();
            }

            txtSerial.Text = " ";
            txtMarca.Text = " ";
            txtDescripcion.Text = " ";
        }
    }
}