using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
   public  class UsuarioEntidad
    {

       private int _IdUsuario ;
       private int _NumeroIdentificacion;
       private string _Nombre;
       private string _Apellido;
       private int _IdTipoDocumento;
       private string _Cargo;
       private int _IdRol;
       private bool _Activo;
       private FichaEntidad _IdFicha;

     public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

     public int NumeroIdentificacion
     {
         get { return _NumeroIdentificacion; }
         set { _NumeroIdentificacion = value; }
     }
     public string Nombre
     {
         get { return _Nombre; }
         set { _Nombre = value; }
     }
     public string Apellido
     {
         get { return _Apellido; }
         set { _Apellido = value; }
     }
     public int IdTipoDocumento
     {
         get { return _IdTipoDocumento; }
         set { _IdTipoDocumento = value; }
     }
     public string Cargo
     {
         get { return _Cargo; }
         set { _Cargo = value; }
     }
     public int IdRol
     {
         get { return _IdRol; }
         set { _IdRol = value; }
     }
     public bool Activo
     {
         get { return _Activo; }
         set { _Activo = value; }
     }
     public FichaEntidad IdFicha
     {
         get { return _IdFicha; }
         set { _IdFicha = value; }
     }
    }
}
