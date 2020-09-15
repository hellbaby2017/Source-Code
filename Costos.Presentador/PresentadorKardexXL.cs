using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costos.Entidades;
namespace Costos.presentador
{
    public class PresentadorKardexXL
    {
        IListKARDEXL IlistaTU;
        FuncionesCRUD CRUD = new FuncionesCRUD();
        public void add(IListKARDEXL IlistaITU)
        {
            IlistaTU = IlistaITU;
        }
        public void cargarkardexl(string fechaini,string fechafin)
        {
            CRUD.EntidadAdminpaq.CommandTimeout = 0; 
            string queryString = "SELECT * FROM FKARDEXL('" + fechaini + "','" + fechafin + "') order by cAltClave";
            var w = CRUD.EntidadAdminpaq.ExecuteStoreQuery<EKARDEXL>(queryString);
            IlistaTU.ListaKardex = w.ToList();
        }
    }
}
