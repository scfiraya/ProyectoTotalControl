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
   public class Aprendiz
    {
       public void InsertarAprendizDal( string NumDoc,string Nombre,string Apellido, int TipoDoc, int NumFicha)
       {
           string sql = "";

           sql = "insert into Usuario(NumeroIdentificacion,Nombre,Apellido,IdTipoDocumento,IdFicha) values (" + NumDoc +",'"+Nombre+"','"+Apellido+"',"+ TipoDoc+"," +NumFicha+ ")";
           SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
           Connection.Open();

           IDbCommand Comando = Connection.CreateCommand();
           Comando.CommandType = CommandType.Text;
           Comando.CommandText = sql;
           Comando.ExecuteNonQuery();
           Connection.Close();
       }

       public FichaEntidad TraerIdFichaDal(int IdFicha)
       {
           string sql = "";
           sql = "select IdFicha from  Ficha  where NumeroFicha=" + IdFicha;
           SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
           Connection.Open();
           SqlCommand Comando = Connection.CreateCommand();
           Comando.CommandText = sql;

           SqlDataReader reader = Comando.ExecuteReader();
           FichaEntidad IdFichaE = new FichaEntidad();
           while (reader.Read())
           {

               IdFichaE.IdFicha = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
               
            

           }
           return IdFichaE;

       }

    }
}
