using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costos.Entidades;
namespace Costos.presentador
{
    public class Presentadorreproxfecha
    {
        FuncionesCRUD CRUD = new FuncionesCRUD();

        public void Reproceso(DateTime fecha)
        {
            CRUD.EntidadAdminpaq.CommandTimeout = 0;
            string queryString = "exec ReprocesarFecha'" + fecha + "'";
            var w = CRUD.EntidadAdminpaq.ExecuteStoreQuery<cMovReproceso2>(queryString);

            //var list = (from qq in CRUD.EntidadAdminpaq.ReprocesarFecha (fecha)
            //            select qq).ToList();
            DataTable dt = CRUD.ToDataTable<cMovReproceso2>(w.ToList());
            CRUD.importarTabla(dt);
        }
    }

}
