using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;

namespace TotalControlDal
{
    public class Ficha
    {

        public DataTable TraerFichasDal(string consulta)
        {
           
            string sql = "";

            sql = "select f.IdFicha,f.NumeroFicha,f.Ambiente,p.NombrePrograma from Ficha f inner join Programa p on f.IdPrograma=p.IdPrograma";


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

            sql = "select u.Nombre, u.Apellido,u.NumeroIdentificacion  from Usuario u inner join Ficha f on u.IdFicha= f.IdFicha where f.IdFicha=" + Detalle + "and u.IdCargo=200";


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

        //public List<FichaEntidad> TraerNumFichaMul(int NumFicha)
        //{
        //    List<FichaEntidad> Ficha = new List<FichaEntidad>();
        //    string sql = "";
        //    sql = "select u.Nombre,u.Apellido,f.Nombre from Usuario u inner join ficha f on u.IdFicha=f." + NumFicha;
        //    SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        //    Connection.Open();
        //    SqlCommand Comando = Connection.CreateCommand();
        //    Comando.CommandText = sql;

        //    SqlDataReader reader = Comando.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        FichaEntidad FichaE = new FichaEntidad();
        //        FichaE.IdFicha = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
        //        FichaE.Nombre = reader.GetString(1) == null ? string.Empty : reader.GetString(1);
        //        FichaE.IdFicha = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
        //        Ficha.Add(FichaE);
        //    }
        //    return Ficha;
        //}

        public ProgramaEntidad TraerNumFicha(int NumFicha)
        {            
            string sql = "";
            sql = "select f.IdPrograma, p.NombrePrograma from Ficha f inner join Programa p on IdFicha="+NumFicha+" and f.IdPrograma=p.IdPrograma";
            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();
            SqlCommand Comando = Connection.CreateCommand();
            Comando.CommandText = sql;

            SqlDataReader reader = Comando.ExecuteReader();
            ProgramaEntidad ProgramaE = new ProgramaEntidad();
            while (reader.Read())
            {               
              
                ProgramaE.NombrePrograma = reader.GetString(1) == null ? string.Empty : reader.GetString(1);

            }
            return ProgramaE;
        }

        public UsuarioEntidad TraerDatosFicha(int NumFicha)
        {
            string sql = "";
            sql = "select  u.Nombre,u.Apellido from Usuario u where IdCargo=201 and IdFicha="+NumFicha;
            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();
            SqlCommand Comando = Connection.CreateCommand();
            Comando.CommandText = sql;

            SqlDataReader reader = Comando.ExecuteReader();
            UsuarioEntidad Usuario = new UsuarioEntidad();
            while (reader.Read())
            {
                Usuario.Nombre = reader.GetString(0) == null ? string.Empty : reader.GetString(0);
                Usuario.Apellido = reader.GetString(1) == null ? string.Empty : reader.GetString(1);
            }
            return Usuario;
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

        public DataTable TraerNombreFichaDal()
        {
            string sql = "";
            sql = "Select IdPrograma,NombrePrograma From Programa";

            DataTable dtNombreFicha = new DataTable();
            DataSet dsNombreFicha = new DataSet();
            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandText = sql;
            SqlDataAdapter Adaptador = new SqlDataAdapter((SqlCommand)Comando);
            Adaptador.Fill(dsNombreFicha);
            Connection.Close();
            dtNombreFicha = dsNombreFicha.Tables[0];
            return dtNombreFicha;
        }

        public void CreacionFichaDal(int NumFicha, int Ambiente, int IdPrograma)
        {
            string sql = "";
            sql = "insert into Ficha (NumeroFicha,Ambiente,IdPrograma) values("+NumFicha+","+Ambiente+","+IdPrograma+")";

            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();

            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sql;
            Comando.ExecuteNonQuery();
            Connection.Close();
        }



    }
}
