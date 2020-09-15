using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costos.presentador
{
    public class PresentadorCambiarSemana
    {
        IlistaCalendario IlistaTU;
        FuncionesCRUD CRUD = new FuncionesCRUD();
        public void add(IlistaCalendario IlistaITU)
        {
            IlistaTU = IlistaITU;
            CargarListaUsuarios();
        }
        private void CargarListaUsuarios()
        {
            IlistaTU.ListaCalendario = CRUD.EntidadMVI.Mvi_cCalendario.OrderByDescending(x=>x.cCalClave);
        }
        public void csemana(int origen, int destino)
        {
            CRUD.Cambiarsemana(origen, destino);
        }
    }
}
