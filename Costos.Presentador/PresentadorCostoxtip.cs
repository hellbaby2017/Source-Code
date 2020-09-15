using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costos.Entidades;
namespace Costos.presentador
{
    public class PresentadorCostoxtip
    {
        IListaCostoxtip IlistaTU;
        FuncionesCRUD CRUD = new FuncionesCRUD();
        public void add(IListaCostoxtip IlistaITU)
        {
            IlistaTU = IlistaITU;
        }
        public void cargarxtipo(string fechaini, string fechafin)
        {
            CRUD.EntidadAdminpaq.CommandTimeout = 0;
            string queryString = "SELECT tipo,unidades, Costo FROM FCOSTOXTIP('" + fechaini + "','" + fechafin + "')";
            var w = CRUD.EntidadAdminpaq.ExecuteStoreQuery<ECOSTOXTIP>(queryString);
            var datos = w.ToList();
            IlistaTU.ListaCostoxtip = datos;
        }
    }
}
