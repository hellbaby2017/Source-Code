using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costos.Entidades;
using System.Data;
using System.Data.Objects;

namespace Costos.presentador
{
    class PresentadorImportacion
    {
        IListaimportacion IlistaTU;
        FuncionesCRUD CRUD = new FuncionesCRUD();
        public void add(IListaimportacion IlistaITU)
        {
            IlistaTU = IlistaITU;
            CargarListaCalendario();
        }
        private void CargarListaCalendario()
        {
            string queryString = "select * from CALMVI() order by ccalclave DESC";
            var w = CRUD.EntidadAdminpaq.ExecuteStoreQuery<ECALENDARIO>(queryString);
            IlistaTU.ListaCalendario = w.ToList();
   

        }
        public void CargarInformación(int semana)
        {
            CRUD.EntidadAdminpaq.CommandTimeout = 0;
            string queryString = "SELECT *  FROM FACMOVEXPORTAR(" + semana + ") order by cMoANombre ";
            var w = CRUD.EntidadAdminpaq.ExecuteStoreQuery<EACMOVEXPORTAR>(queryString);
            IlistaTU.Listaimportar = w.ToList();
            //ObjectParameter parametro = new ObjectParameter("CLAVE",semana);


            //IlistaTU.Listaimportar = CRUD.EntidadAdminpaq.ACMOVEXPORTAR(semana);
        }
        public void ImportarMVI(int semana)
        {
            CRUD.Importarmvi(semana);
        }
        public void llamarconta()
        {
            IlistaTU.cantidad = CRUD.llamar();
            IlistaTU.total = CRUD.llamar2();
        }
        public void listarresultado(int NoSemana)
        {

            //var q = from m in CRUD.EntidadAdminpaq.amovimientos
            //        where m.cCalClave == NoSemana
            //        select new  { cMoAClave=1,cMoANombre = m.cMoANombre, Unidades = Convert.ToInt32(m.Suma) };
            IlistaTU.Listaresultado = CRUD.EntidadAdminpaq.amovimientos.Where(x => x.cCalClave == NoSemana).OrderBy(y=> y.cMoANombre);
        }
        public IEnumerable<Mvi_cCalendario> tsemana(int semana)
            {
            string querystring = "select * from Mvi_cCalendario where cCalClave =" + semana;
            var q = CRUD.EntidadMVI.ExecuteStoreQuery<Mvi_cCalendario>(querystring);
            return q;
        }

        public int existesemana(int semana)
        {
            int total;
            var q = from m in CRUD.EntidadAdminpaq.vagrupadosemanas where m.cCalClave == semana select m;
            total = q.ToList().Count;
            return total;    
        }
    }
}
