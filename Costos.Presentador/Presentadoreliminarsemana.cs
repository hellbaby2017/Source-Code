using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costos.presentador
{
    public class Presentadoreliminarsemana
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
            IlistaTU.ListaCalendario = CRUD.EntidadMVI.Mvi_cCalendario.OrderByDescending(x=>x.cCalClave);


        }
        public void eliminarsemana(int semana)
        {
            CRUD.BorrarSemana(semana);
           }
    }

}
