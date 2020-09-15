using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transito.Presentador
{
    class presentadorctransito
    {
        Ilttransito IlistaTU;
        FuncionesCRUD objmodulo = new FuncionesCRUD();
        public void add(Ilttransito IlistaITU)
        {
            IlistaTU = IlistaITU;
            cargarregistro();
        }
        private void cargarregistro()
        {
            IlistaTU.ListaTuTransito = objmodulo.TransitoEntidad.Svp_CTransito;
        }
        public void Refrescar()
        {
            objmodulo.refrescar();
            cargarregistro();
        }
        public void eliminar(Int16 id)
        {

            objmodulo.Eliminartransito(id);
        }
        public void guardar(bool cTranActivo, int cTranClave, string cTranNombre, bool cTranTipo)
        {
            if (string.IsNullOrEmpty(cTranNombre) == false)
            {
                objmodulo.GuardarCTransito(cTranActivo, cTranClave, cTranNombre, cTranTipo);
                cargarregistro();
            }
           

        }
       
    }
}
