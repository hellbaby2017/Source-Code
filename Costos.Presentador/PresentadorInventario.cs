using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costos.presentador
{
    public class PresentadorInventario
    {
        iListaInventario IlistaTU;
        FuncionesCRUD CRUD = new FuncionesCRUD();
        public void add(iListaInventario IlistaITU)
        {
            IlistaTU = IlistaITU;
            CargarInventario();

        }
        private void CargarInventario()
        {
            var q = CRUD.EntidadAdminpaq.mcapas.OrderBy(x => x.cAltClave);
            IlistaTU.ListaAlternativa = q;
        }
    }
}
