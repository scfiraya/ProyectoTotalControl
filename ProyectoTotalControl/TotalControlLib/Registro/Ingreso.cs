using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TotalControlDal;

namespace TotalControlLib.Registro
{
    public class Ingreso
    {
        public DataTable TipoDocBll()
        {
            TotalControlDal.Ingreso objTipoDoc = new TotalControlDal.Ingreso();
            DataTable dtTipoDoc = new DataTable();
            dtTipoDoc = objTipoDoc.TipoDocDal();
            return dtTipoDoc;
        }

        public DataTable TipoDisBll()
        {
            TotalControlDal.Ingreso objTipoDis = new TotalControlDal.Ingreso();
            DataTable dtTipoDis = new DataTable();
            dtTipoDis = objTipoDis.TipoDisDal();
            return dtTipoDis;
        }

        public void InsertarUsuarioBll(string NumeroIdentificacion, string Nombre, string Apellido, int TipoDoc, int Cargo)
        {
            TotalControlDal.Ingreso objInsertar = new TotalControlDal.Ingreso();
            objInsertar.InsertarUsuarioDal(NumeroIdentificacion, Nombre, Apellido, TipoDoc, Cargo);
        }

        public void InsertarDispositivoLib(string Serial, string Marca, int CargadorB, string Descripcion, int TipoDis)
        {
            TotalControlDal.Ingreso objInsertarDis = new TotalControlDal.Ingreso();
            objInsertarDis.InsertarDispositivoDal(Serial, Marca, CargadorB, Descripcion, TipoDis);
        }

        public DataTable TraerNumDocLib(string NumDoc)
        {
            TotalControlDal.Usuario objNumDoc = new TotalControlDal.Usuario();
            DataTable dtNumDoc = new DataTable();
            dtNumDoc = objNumDoc.TraerUsuarioDal(NumDoc);
            return dtNumDoc;
        }

        public DataTable TraerIngresoLib(string NumDoc)
        {
            TotalControlDal.Ingreso objIngreso = new TotalControlDal.Ingreso();
            DataTable dtIngreso = new DataTable();
            dtIngreso = objIngreso.TraerIngresoDal(NumDoc);
            return dtIngreso;
        }

        public DataTable SeccionLib()
        {
            TotalControlDal.Ingreso objSeccion = new TotalControlDal.Ingreso();
            DataTable dtSeccion = new DataTable();
            dtSeccion = objSeccion.SeccionDal();
            return dtSeccion;
        }
    }
}
