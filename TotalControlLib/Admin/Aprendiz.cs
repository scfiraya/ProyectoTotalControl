using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalControlDal;


namespace TotalControlLib.Admin
{
    public class Aprendiz
    {
        public void InsertarAprendizBll(int NumDoc, string NomCom, int TipoDoc, int NumFicha)
        {
            TotalControlDal.Aprendiz objInsertar = new TotalControlDal.Aprendiz();

            objInsertar.InsertarAprendizDal(NumDoc,NomCom,  TipoDoc,  NumFicha);
        }
        
    }
}
