using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TotalControlDal;
using Entidades;

namespace TotalControlLib
{
    public class Ficha
    {
        public DataTable TraerFichasBll(string consulta)
        {
            TotalControlDal.Ficha obDatos = new TotalControlDal.Ficha();
            DataTable dtFichas = new DataTable();
            dtFichas = obDatos.TraerFichasDal(consulta);
            return dtFichas;
        }

        public DataTable TraerDetalleFichaBll(String Detalle)
        {
            TotalControlDal.Ficha obDatos = new TotalControlDal.Ficha();
            DataTable dtFichas = new DataTable();
            dtFichas = obDatos.TraerDetalleFichaDal(Detalle);
            return dtFichas;
        }

        public DataTable TraerNumFichasBll(int NumFicha)
        {
            TotalControlDal.Ficha objDatos = new TotalControlDal.Ficha();
            DataTable dtFichas = new DataTable();
            dtFichas = objDatos.TraerNumFichasDal(NumFicha);
            return dtFichas;
        }

        public bool SubirArchivoBll(string Archivo)
        {
            TotalControlDal.Ficha objSubir = new TotalControlDal.Ficha();
            return objSubir.SubirArchivo(Archivo);
        }

        public ProgramaEntidad TraerNumFicha(int NumFicha)
        {
            TotalControlDal.Ficha objSubir = new TotalControlDal.Ficha();
            return objSubir.TraerNumFicha(NumFicha);
        }
        public UsuarioEntidad TraerDatosFichaBll(int NumFicha)
        {

            TotalControlDal.Ficha objDatos = new TotalControlDal.Ficha();
            return objDatos.TraerDatosFicha(NumFicha);
        }

        public DataTable TraerNombreFichaBll()
        {
            TotalControlDal.Ficha objNomFicha = new TotalControlDal.Ficha();
            DataTable dtNombreFicha = new DataTable();
            dtNombreFicha=objNomFicha.TraerNombreFichaDal();
            return dtNombreFicha;
        }

        public void CreacionFichaLib(int NumFicha, int Ambiente, int IdPrograma)
        {
            TotalControlDal.Ficha objInsertar = new TotalControlDal.Ficha();

            objInsertar.CreacionFichaDal(NumFicha, Ambiente, IdPrograma);
        }
    }
}

