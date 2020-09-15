using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costos.Entidades;
namespace Costos.presentador
{
    public class Presentadormcapa
    {
        iListmcapas1 IlistaTU;
        FuncionesCRUD CRUD = new FuncionesCRUD();
        public void add(iListmcapas1 IlistaITU)
        {
            IlistaTU = IlistaITU;
            Cargarmcapas();
            
        }
        private void Cargarmcapas()
        {
            CRUD.EntidadAdminpaq.CommandTimeout = 0;
            string queryString = "SELECT * FROM FMCAPAS1() order by cAltClave";
            var w = CRUD.EntidadAdminpaq.ExecuteStoreQuery<EMCAPAS>(queryString);
            IlistaTU.ListaKardex = w.ToList();
            //IlistaTU.ListaKardex = CRUD.EntidadAdminpaq.KARDEX(inicio, final, alternativa);
        }
    }
}
