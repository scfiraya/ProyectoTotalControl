using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebTotalControl.Views
{
    public partial class CreacionFichas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Se valida la seguridad de la pagina
            try
            {
                int SesionActiva = (int)Session["SesionActiva"];
                if (!IsPostBack)
                {
                    TotalControlLib.Ficha objMostrarNomFicha = new TotalControlLib.Ficha();

                    DataTable dtNomFicha = new DataTable();
                    dtNomFicha = objMostrarNomFicha.TraerNombreFichaBll();
                    ddlPrograma.DataSource = dtNomFicha;
                    ddlPrograma.DataTextField = "NombrePrograma";
                    ddlPrograma.DataValueField = "IdPrograma";
                    ddlPrograma.DataBind();

           }

                }

            
            catch (Exception ex)
            {
                Response.Redirect("~/views/Default.aspx");
            }
        }

       
        protected void btnSubir_Click(object sender, EventArgs e)
        {
            //Creeo una variable llamo el metodo
            string Archivo = PathDocument();
            if (Archivo != "")
            {
                TotalControlLib.Ficha objSubir = new TotalControlLib.Ficha();
                if (objSubir.SubirArchivoBll(Archivo))
                {
                    lblSuccess.Text = "La Carga Se realizo con exito";
                }
                else
                {
                    lblSuccess.Text = "Error al subir la base ";
                }
            }
        }


        public string PathDocument()
        {
            string Document = "";
            Boolean fileOK = false;
            //Ruta donde guardamos los archivos antes de Subirlos  
            String path = Server.MapPath("~/Views/SubirArchivo/");

            //Se valida si en la ruta se encuentra el archivo para subir 
            if (fuSubirArchivo.HasFile)
            {

                String fileExtension = System.IO.Path.GetExtension(fuSubirArchivo.FileName).ToLower();
                //Delimitacion de extenciones
                String[] allowedExtensions = { ".txt"};
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    //Recorre cada extencion 
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }

            if (fileOK)
            {
                try
                {
                    //Variable que guarda la ruta donde se encuentra el archivo
                    Document = path + fuSubirArchivo.FileName;
                    fuSubirArchivo.PostedFile.SaveAs(Document);
                    lblSuccess.Text = "Carga Exitosa!";
                }
                catch (Exception ex)
                {
                    lblSuccess.Text = "El archivo no se puede subir.";
                }
            }
            else
            {
                lblSuccess.Text = "No se aceptan archivos de este tipo.";
            }
            return Document;
        }

        protected void btncrearFicha_Click(object sender, EventArgs e)
        {
            try
            {
                TotalControlLib.Ficha objCrearFichaLib = new TotalControlLib.Ficha();

                int NumFicha = Convert.ToInt32(txtCodFicha.Text);
                int Ambiente = Convert.ToInt32(txtAmbiente.Text);

                int IdPrograma = 0;


                if (ddlPrograma.Text.Equals(""))
                {
                    IdPrograma = 0;
                }
                else
                {
                    IdPrograma = Convert.ToInt32(ddlPrograma.Text);
                }

                objCrearFichaLib.CreacionFichaLib(NumFicha, Ambiente, IdPrograma);
                lblSuccess.Text = "La Ficha se creo exitosamente.";

                txtAmbiente.Text = "";
                txtCodFicha.Text = "";

          
            }
            catch (Exception ex)
            {
                lblSuccess.Text = "Error al guardar el registro. Detalle del error: " + ex.Message.ToString();
            }

        }
    }
}