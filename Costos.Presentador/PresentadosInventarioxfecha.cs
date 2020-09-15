using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costos.Entidades;
namespace Costos.presentador
{
    public class PresentadosInventarioxfecha
    {
        IListaInventarioxFecha IlistaTU;
        FuncionesCRUD CRUD = new FuncionesCRUD();
        public void add(IListaInventarioxFecha IlistaITU)
        {
            IlistaTU = IlistaITU;
         }
        public void CargarKardex(string inicio)
        {
            CRUD.EntidadAdminpaq.CommandTimeout = 0;
            string queryString = "exec AInventarioF '" + inicio + "'";
            var w = CRUD.EntidadAdminpaq.ExecuteStoreQuery<EMCAPAS>(queryString);
            IlistaTU.ListaAlternativa = w.ToList();
            //IlistaTU.ListaKardex = CRUD.EntidadAdminpaq.KARDEX(inicio, final, alternativa);
        }
    }
}
