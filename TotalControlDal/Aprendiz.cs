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
   public class Aprendiz
    {
       public void InsertarAprendizDal( int NumDoc,string NomCom, int TipoDoc, int NumFicha)
       {
           string sql = "";

           sql = "insert into Usuario(NumeroIdentificacion,Nombre,IdTipoDocumento,IdFicha) values (" + NumDoc + NomCom + TipoDoc + NumFicha+ ")";
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
