using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
   public  class ProgramaEntidad
    {


        private int _IdPrograma;
        private string _NombrePrograma;
       
        // encapsulamiento de Datos
        public int IdPrograma
        {
            get { return _IdPrograma; }
            set { _IdPrograma = value; }
        }

        public string NombrePrograma
        {
            get { return _NombrePrograma; }
            set { _NombrePrograma = value; }
        }

    }
}
