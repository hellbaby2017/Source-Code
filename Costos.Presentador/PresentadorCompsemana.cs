using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costos.presentador
{
    class PresentadorCompsemana
    {
        IListaComparación IlistaTU;
        FuncionesCRUD CRUD = new FuncionesCRUD();
        public void add(IListaComparación IlistaITU)
        {
            IlistaTU = IlistaITU;
            cargarcalendario();

        }
        private void cargarcalendario()
        {
            IlistaTU.ListaCalendario = CRUD.EntidadMVI.Mvi_cCalendario.OrderByDescending(x=> x.cCalClave);
        }
        public void cargarcomp(int calendario)
        {
            CRUD.EntidadAdminpaq.CommandTimeout = 0;
            IlistaTU.Listacomparacion = CRUD.EntidadAdminpaq.amovimientosmvi(calendario);
        }

    }
}
