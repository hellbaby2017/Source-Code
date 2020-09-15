using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transito.Entidades;
namespace Transito.Presentador
{
    public class PresentadorTransitoxalmacen
    {
        ILTransitosql IlistaTU;
        FuncionesCRUD objmodulo = new FuncionesCRUD();
        public void add(ILTransitosql IlistaITU)
        {
            IlistaTU = IlistaITU;
            cargarlista();
        }
        private void cargarlista()
        {
            IlistaTU.ListaTuTransito= objmodulo.TransitoEntidad.Svp_rTransitosxAlmacen;
        }
        public void guardar(Int32 id,Int16 cAlmClave, Int16 ctranclave, string rMxAPrefijoFehca, string rMxASQL, bool rMxUActivo)
        {

                objmodulo.GuardarTransitosxalmacen(id,cAlmClave, ctranclave, rMxAPrefijoFehca, rMxASQL, rMxUActivo);

        }
        public void eliminar(int cAlmClave,int cTranClave)
        {
            objmodulo.Eliminartransql(cAlmClave, cTranClave);
        }
        public void Refrescar()
        {
            objmodulo.refrescar();
            cargarlista();
        }
    }
}
