using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TotalControlDal
{
    public class Ficha
    {

        public DataTable TraerFichasDal(string consulta)
        {
            string sql = "";

            sql = "select * from Ficha";


            DataTable dtFichas = new DataTable();
            DataSet dsFichas = new DataSet();
            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandText = sql;
            SqlDataAdapter Adaptador = new SqlDataAdapter((SqlCommand)Comando);
            Adaptador.Fill(dsFichas);
            Connection.Close();
            dtFichas = dsFichas.Tables[0];
            return dtFichas;
        }

        public DataTable TraerDetalleFichaDal(string Detalle)
        {
            string sql = "";

            sql = "select u.Nombre, u.Apellido  from Usuario u inner join UsuarioFicha f on u.IdUsuaio= f.IdUsuario where IdFicha=101";


            DataTable dtFichas = new DataTable();
            DataSet dsFichas = new DataSet();
            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandText = sql;
            SqlDataAdapter Adaptador = new SqlDataAdapter((SqlCommand)Comando);
            Adaptador.Fill(dsFichas);
            Connection.Close();
            dtFichas = dsFichas.Tables[0];
            return dtFichas;
        }

        public DataTable TraerNumFichasDal(int NumFicha)
        {
            string sql = "";

            sql = "select * from Ficha where NumeroFicha=" + NumFicha;


            DataTable dtFichas = new DataTable();
            DataSet dsFichas = new DataSet();
            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandText = sql;
            SqlDataAdapter Adaptador = new SqlDataAdapter((SqlCommand)Comando);
            Adaptador.Fill(dsFichas);
            Connection.Close();
            dtFichas = dsFichas.Tables[0];
            return dtFichas;
        }

        public bool SubirArchivo(string Archivo)
        {
            string sql = "";
            sql = "BULK INSERT Usuario FROM '" + Archivo + "'WITH( FIELDTERMINATOR = ',',ROWTERMINATOR = ';' ) ";

            //DataTable dtArchivo = new DataTable();
            //DataSet dsArchivo = new DataSet();
            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sql;
            //retorna un valor, devuelve el numero de filas afectadas
            return Comando.ExecuteNonQuery() >= 0;
        }
    }
}
