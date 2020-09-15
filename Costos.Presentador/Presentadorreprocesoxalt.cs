using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costos.Entidades;
using System.Data;

namespace Costos.presentador
{
    public class Presentadorreprocesoxalt
    {
       
        IListaReprocesoxalt IlistaTU;
        FuncionesCRUD CRUD = new FuncionesCRUD();
        public void add(IListaReprocesoxalt IlistaITU)
        {
            IlistaTU = IlistaITU;
            CargarListaCalendario();
        }
        private void CargarListaCalendario()
        {
            IlistaTU.ListaAlternativa = CRUD.EntidadMVI.Mvi_cAlternativas;
         }
        public void Reproceso(string alternativa)
        {
            CRUD.EntidadAdminpaq.CommandTimeout = 0;
            string queryString = "exec ReprocesarAlt'" + alternativa + "'";
            var w = CRUD.EntidadAdminpaq.ExecuteStoreQuery<cMovReproceso2>(queryString);
            DataTable dt = CRUD.ToDataTable<cMovReproceso2>(w.ToList());
            CRUD.importarTabla(dt);
            //IlistaTU.ListaKardex = w.ToList();
            //var list = (from qq in CRUD.EntidadAdminpaq.ReprocesarAlt(alternativa)
            //select qq).ToList();
            //DataTable dt = CRUD.ToDataTable<cMovReproceso2>(list);
            //CRUD.importarTabla(dt); 
        }
    }
}
