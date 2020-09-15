using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transito.Presentador
{
    class PresentadorAlmacenes
    {
        IAlmacenes IlistaTU;
        FuncionesCRUD objmodulo = new FuncionesCRUD();
        public void add(IAlmacenes IlistaITU)
        {
            IlistaTU = IlistaITU;
            cargaralmacenes();
        }
        private void cargaralmacenes()
        {
            //staTU.ListaTusuario = Entidad.Cfg_AtiposUsuarios.Include("Cfg_cProgramaxTipoUsuario");
            IlistaTU.ListaTusuario = objmodulo.TransitoEntidad.Svp_cAlmacenes;
        }
        public void guardar(bool nuevo,Int16 cAlmClave, bool cAlmActivo, string cAlmIPServidor, string CAlmNombre, string cAlmPrefijoSIA, string CUdNContabilidad, bool cUniversal)
        {
            if (string.IsNullOrEmpty(CAlmNombre) == false && string.IsNullOrEmpty(cAlmIPServidor)==false)
            {
                objmodulo.GuardarAlmacen(nuevo,cAlmClave, cAlmActivo, cAlmIPServidor, CAlmNombre, cAlmPrefijoSIA, CUdNContabilidad, cUniversal);
                cargaralmacenes();
            }
        }
        public void Refrescar()
        {
            objmodulo.refrescar();
            cargaralmacenes();
        }
        public void eliminar(Int16 id)
        {

            objmodulo.EliminarAlmacen(id);
        }
    }

}
