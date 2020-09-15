using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costos.Entidades;
namespace Costos.presentador
{
    class Presentadorlcmovimientos
    {
        ListaIcMovimientos IlistaTU;
        FuncionesCRUD CRUD = new FuncionesCRUD();
        public void add(ListaIcMovimientos IlistaITU)
        {
            IlistaTU = IlistaITU;
            Cargarcmovimientos();

        }
        private void Cargarcmovimientos()
        {
            CRUD.EntidadAdminpaq.CommandTimeout = 0;
            string queryString = "SELECT * FROM cmovimientosalmacen";
            var w = CRUD.EntidadAdminpaq.ExecuteStoreQuery<cmovimientosalmacen>(queryString);
            IlistaTU.Lcmovimientos = w.ToList();
            //IlistaTU.ListaKardex = CRUD.EntidadAdminpaq.KARDEX(inicio, final, alternativa);
        }
    }
}
