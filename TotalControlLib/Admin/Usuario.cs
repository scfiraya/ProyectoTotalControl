using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TotalControlDal;

using System.Security.Cryptography;
using System.IO;


namespace TotalControlLib.Admin
{
    public class Usuario
    {
        public DataTable TraerIngresoUsuarioBll(string Usuario,string passwd)
        {
            TotalControlDal.Usuario objRol = new TotalControlDal.Usuario();
            DataTable dtUsuario = new DataTable();

            SHA512 objEncriptacion = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(passwd);
            byte[] hash = objEncriptacion.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            string Contrasena = sb.ToString();           
            
            dtUsuario = objRol.TraerIngresoUsuarioDal(Usuario,Contrasena);
            return dtUsuario;
        }

        public DataTable TraerUsuarioBll(string Documento)
        {
            TotalControlDal.Usuario objBuscar = new TotalControlDal.Usuario();
            DataTable dtUsuario = new DataTable();
            dtUsuario = objBuscar.TraerUsuarioDal(Documento);
            return dtUsuario;
        }

        public void InsertarUsuarioLib(string NumDoc, string NomCom, string Apellido, int TipoDoc, int Cargo, int Rol, string Login, string Contra, int NFicha)
        {
            TotalControlDal.Usuario objInsertar = new TotalControlDal.Usuario();

            SHA512 objEncriptacion = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(Contra);
            byte[] hash = objEncriptacion.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            string Contrasena = sb.ToString();

            objInsertar.InsertarUsuarioDal(NumDoc, NomCom, Apellido, TipoDoc, Cargo, Rol, Login, Contrasena, NFicha);
        }

        public void ModificarUsuarioLib(string NomCom, int NumDoc)
        {
            TotalControlDal.Usuario objModificar = new TotalControlDal.Usuario();

            objModificar.ModificarUsuarioDal(NomCom, NumDoc);
        }

        public void EliminarUsuarioLib(int NumDoc)
        {
            TotalControlDal.Usuario objEliminar = new TotalControlDal.Usuario();

            objEliminar.EliminarUsuarioDal(NumDoc);
        }

        public DataTable TipoDocBll()
        {
            TotalControlDal.Usuario objTipoDoc = new TotalControlDal.Usuario();
            DataTable dtTipoDoc = new DataTable();
            dtTipoDoc = objTipoDoc.TipoDocDal();
            return dtTipoDoc;
        }

        public DataTable Cargo()
        {
            TotalControlDal.Usuario objCargo = new TotalControlDal.Usuario();
            DataTable dtCargo = new DataTable();
            dtCargo = objCargo.NombreCargo();
            return dtCargo;
        }

        public DataTable Rol()
        {
            TotalControlDal.Usuario objRol = new TotalControlDal.Usuario();
            DataTable dtRol = new DataTable();
            dtRol = objRol.NombreRol();
            return dtRol;
        }

        public DataTable FichaProgramaBLL()
        {
            TotalControlDal.Usuario objFichaPrograma = new TotalControlDal.Usuario();
            DataTable dtFichaPrograma = new DataTable();
            dtFichaPrograma = objFichaPrograma.FichaPrograma();
            return dtFichaPrograma;
        }
        
        public string ValidaCedulaBLL(string cedula)
        {
            TotalControlDal.Usuario objValida = new TotalControlDal.Usuario();
            string Valida =Convert.ToString(objValida.ValidaCedulaDal(cedula));

            return Valida;
        }

        public void CambiaPasswordBLL(string cedula, string contrasena)
        {

            TotalControlDal.Usuario objCambiaPassword = new TotalControlDal.Usuario();

            SHA512 objEncriptacion = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(contrasena);
            byte[] hash = objEncriptacion.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            string password = sb.ToString();

            objCambiaPassword.CambioPasswordDal(cedula, password);

        }        
    }
}
