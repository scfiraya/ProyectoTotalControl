using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TotalControlDal;

namespace TotalControlLib.Admin
{
    public class Usuario
    {
        public DataTable TraerIngresoUsuarioBll(string Usuario,string Contrasena)
        {
            TotalControlDal.Usuario objRol = new TotalControlDal.Usuario();
            DataTable dtUsuario = new DataTable();
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

        public void InsertarUsuarioLib(string NomCom, int NumDoc, string Apellido, string Login, string Contrasena, string Rcontrasena, bool Activo, string TipoDoc, string Rol)
        {
            TotalControlDal.Usuario objInsertar = new TotalControlDal.Usuario();

            //objInsertar.InsertarUsuarioDal(NomCom, Apellido, NumDoc, Login, Contrasena, Rcontrasena, Activo, TipoDoc, Rol);
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

    }
}
