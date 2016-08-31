using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace TotalControlDal
{
    public class Ingreso
    {
        public DataTable TipoDocDal()
        {
            string sql = "";
            sql = "select IdTipoDocumento, Tipo from TipoDocumento";

            DataTable dtTipoDoc = new DataTable();
            DataSet dsTipoDoc = new DataSet();
            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sql;
            SqlDataAdapter Adaptador = new SqlDataAdapter((SqlCommand)Comando);
            Adaptador.Fill(dsTipoDoc);
            Connection.Close();
            dtTipoDoc = dsTipoDoc.Tables[0];
            return dtTipoDoc;
        }

        public DataTable TipoDisDal()
        {
            string sql = "";
            sql = "select IdTipoDispositivo, Nombre from TipoDispositivo";

            DataTable dtTipoDis = new DataTable();
            DataSet dsTipoDis = new DataSet();
            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sql;
            SqlDataAdapter Adaptador = new SqlDataAdapter((SqlCommand)Comando);
            Adaptador.Fill(dsTipoDis);
            Connection.Close();
            dtTipoDis = dsTipoDis.Tables[0];
            return dtTipoDis;
        }

        public void InsertarUsuarioDal(string NumeroIdentificacion, string Nombre, string Apellido, int TipoDoc, int Cargo)
        {
            string sql = "";
            sql = "insert into Usuario (NumeroIdentificacion, Nombre, Apellido, IdTipoDocumento, IdCargo) values (' " + NumeroIdentificacion + " ', ' " + Nombre + " ', ' " + Apellido + " ', " + TipoDoc + ", " + Cargo + " )";

            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sql;
            Comando.ExecuteNonQuery();
            Connection.Close();
        }

        public void InsertarDispositivoDal(string Serial, string Marca, int CargadorB, string Descripcion, int TipoDis)
        {
            string sql = "";
            sql = "insert into Dispositivos (Serial, Marca, Cargador, Descripcion, IdUsuaio, IdTipoDispositivo) values (' " + Serial + " ', ' " + Marca + " ', " + CargadorB + ", ' " + Descripcion + " ' , 1457 ," + TipoDis + ")";

            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sql;
            Comando.ExecuteNonQuery();
            Connection.Close();
        }

        public DataTable TraerNumDocDal(string NumDoc)
        {
            string sql = "";
            sql = "select NumeroIdentificacion from Usuario where NumeroIdentificacion = '" + NumDoc + "' ";

            DataTable dtNumDoc = new DataTable();
            DataSet dsNumDoc = new DataSet();
            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandText = sql;
            SqlDataAdapter Adaptador = new SqlDataAdapter((SqlCommand)Comando);
            Adaptador.Fill(dsNumDoc);
            Connection.Close();
            dtNumDoc = dsNumDoc.Tables[0];
            return dtNumDoc;
        }

        public DataTable TraerIngresoDal(string NumDoc)
        {
            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "SPIngreso";
            Comando.Parameters.Add(new SqlParameter("@NumDoc", NumDoc));
            DataTable dtIngreso = new DataTable();
            DataSet dsIngreso = new DataSet();
            Comando.ExecuteNonQuery();
            SqlDataAdapter Adaptador = new SqlDataAdapter((SqlCommand)Comando);
            Adaptador.Fill(dsIngreso);
            dtIngreso = dsIngreso.Tables[0];
            Connection.Close();
            return dtIngreso;
        }

        public DataTable SeccionDal()
        {
            string sql = "";
            sql = "select IdSeccion, Nombre from Seccion";

            DataTable dtSeccion = new DataTable();
            DataSet dsSeccion = new DataSet();
            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sql;
            SqlDataAdapter Adaptador = new SqlDataAdapter((SqlCommand)Comando);
            Adaptador.Fill(dsSeccion);
            Connection.Close();
            dtSeccion = dsSeccion.Tables[0];
            return dtSeccion;
        }
    }
}
