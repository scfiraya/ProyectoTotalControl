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
        private string _Ambiente;
        private int _IdPrograma;
        // encapsulamiento de Datos
        public int IdFicha
        {
            get { return _IdFicha; }
            set { _IdFicha = value; }
        }
        public int NumeroFicha
        {
            get { return _NumeroFicha; }
            set { _NumeroFicha = value; }
        }

        public string Ambiente
        { 
            get { return _Ambiente; }
            set { _Ambiente = value; }
        }

        public int IdPrograma
        {
            get { return _IdPrograma; }
            set { _IdPrograma = value; }
        }   

    }
}
