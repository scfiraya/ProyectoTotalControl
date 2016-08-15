using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class FichaEntidad
    {
        private int _IdFicha;
        private int _NumeroFicha;
        private string _Nombre;
        // encapsulamiento de Datos
        public string Nombre
        { 
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public int NumeroFicha
        {
            get { return _NumeroFicha; }
            set { _NumeroFicha = value; }
        }

        public int IdFicha
        {
            get { return _IdFicha; }
            set { _IdFicha = value; }
        }        

    }
}
