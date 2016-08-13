using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TotalControlDal;

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

        public DataTable TraerDetalleFichaBll(string Detalle)
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
    }
}
