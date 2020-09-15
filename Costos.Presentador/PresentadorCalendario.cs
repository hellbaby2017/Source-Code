using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costos.presentador
{
    class PresentadorCalendario
    {
        IlistaCalendario IlistaTU;
        FuncionesCRUD CRUD = new FuncionesCRUD();
        public void add(IlistaCalendario IlistaITU)
        {
            IlistaTU = IlistaITU;
            CargarListaCalendario();
        }
        private void CargarListaCalendario()
        {
            IlistaTU.ListaCalendario = CRUD.EntidadMVI.Mvi_cCalendario;
       

        }
        
    }
}
