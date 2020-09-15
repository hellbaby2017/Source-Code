using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transito.Presentador
{
    class PresentadorProyecto
    {
        ILProyecto IlistaTU;
        FuncionesCRUD objmodulo = new FuncionesCRUD();
        public void add(ILProyecto IlistaITU)
        {
            IlistaTU = IlistaITU;
            cargarlista();
        }
        private void  cargarlista()
        {
            IlistaTU.ListaProyectos = objmodulo.TransitoEntidad.Svp_cProyectos;
        }
        public void guardar(Int16 cProClave, DateTime cProFechade, DateTime cProFechaha, string cProNombre, string Observaciones)
        {
            if (string.IsNullOrEmpty(cProNombre) == false)
            {
                objmodulo.GuardarProyecto(cProClave, cProFechade, cProFechaha, cProNombre, Observaciones);
            }
        }
        public void Refrescar()
        {
            objmodulo.refrescar();
            cargarlista();
        }
        public void eliminar(Int16 id)
        {

            objmodulo.Eliminarproyecto(id);
        }
    }
}
