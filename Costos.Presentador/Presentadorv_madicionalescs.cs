using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costos.Entidades;
namespace Costos.presentador
{
    public  class Presentadorv_madicionalescs
    {
        Ivmovadicionalescs IlistaTU;
        FuncionesCRUD CRUD = new FuncionesCRUD();
        public void add(Ivmovadicionalescs IlistaITU)
        {
            IlistaTU = IlistaITU;
            CargarInventario();

        }
        private void CargarInventario()
        {
            var q = CRUD.EntidadAdminpaq.V_MOVADICIONALES.OrderBy(x => x.mMSIFecha);
            IlistaTU.ListaAlternativa = q;
        }
    }
}
