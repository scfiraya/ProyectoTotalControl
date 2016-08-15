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
    public class Usuario
    {
        public DataTable TraerIngresoUsuarioDal(string Usuario, string Contrasena)
        {
            string sql = "";


            sql = "select n.NombreRol from Rol n inner join Usuario u on n.IdRol=u.IdRol inner join Login l on u.IdUsuaio=l.IdUsuario where l.Usuario ='" + Usuario + "' and l.contrasena='" + Contrasena + "'";
            
            DataTable dtUsuario = new DataTable();
            DataSet dsUsuario = new DataSet();
            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandText = sql;
            SqlDataAdapter Adaptador = new SqlDataAdapter((SqlCommand)Comando);
            Adaptador.Fill(dsUsuario);
            Connection.Close();
            dtUsuario = dsUsuario.Tables[0];
            return dtUsuario;
                   }


        public DataTable TraerUsuarioDal(string Documento)
        {
            string sql = "";


            sql = "Select Concat(u.Nombre,u.Apellido) as NombreUsuario ,u.NumeroIdentificacion,u.Cargo,n.NumeroFicha from Usuario u inner join Ficha n on u.IdFicha=n.IdFicha where NumeroIdentificacion=" + Documento;

            DataTable dtUsuario = new DataTable();
            DataSet dsUsuario = new DataSet();
            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandText = sql;
            SqlDataAdapter Adaptador = new SqlDataAdapter((SqlCommand)Comando);
            Adaptador.Fill(dsUsuario);
            Connection.Close();
            dtUsuario = dsUsuario.Tables[0];
            return dtUsuario;
        }

        public void ModificarUsuarioDal(string NomCom, int NumDoc)
        {
            string sql = "";
            sql = "update Usuario set Nombre = '"+ NomCom + " ' where NumeroIdentificacion = (select NumeroIdentificacion from Usuario where NumeroIdentificacion = ' " + NumDoc +" ')";

            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();

            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sql;
            Comando.ExecuteNonQuery();
            Connection.Close();
        }

        public void EliminarUsuarioDal(int NumDoc)
        {
            string sql = "";
            sql = "delete from Usuario where NumeroIdentificacion = "+ NumDoc ;

            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();

            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sql;
            Comando.ExecuteNonQuery();
            Connection.Close();
        }

        public void InsertarUsuarioDal(string NomCom, string Apellido, int NumDoc, string Login, string Contrasena, string Rcontrasena, bool Activo, string TipoDoc, string Rol, string Cargo)
        {
            string sql= "";

            sql = "insert into Usuario values (" + NumDoc + NomCom + Apellido + TipoDoc + "'Aprendiz'" + Rol + ")" + "insert into Login Values ((select IdUsuaio from Usuario where NumeroIdentificacion=" + NumDoc + ")" + Login + Cargo + Activo + ")";

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
