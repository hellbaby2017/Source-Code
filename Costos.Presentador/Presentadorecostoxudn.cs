using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costos.Entidades;
namespace Costos.presentador
{
    class Presentadorecostoxudn
    {
        IListCostosxudn IlistaTU;
        FuncionesCRUD CRUD = new FuncionesCRUD();
        public void add(IListCostosxudn IlistaITU)
        {
            IlistaTU = IlistaITU;
        }
        public void cargarlista(int mes, int aNO)
        {
            CRUD.EntidadAdminpaq.CommandTimeout = 0;
            string queryString = "EXEC INSCOSTOXALTERNATIVA " + mes + "," + aNO + " ";
            int x = CRUD.EntidadAdminpaq.ExecuteStoreCommand("EXEC INSCOSTOXALTERNATIVA " + mes + "," + aNO + " ");
            //var q = Convert.ToInt32(CRUD.EntidadAdminpaq.ExecuteStoreQuery(queryString));
            queryString = "select * from FCOSTOSXUDN(" + mes + "," + aNO + " )";
            var w = CRUD.EntidadAdminpaq.ExecuteStoreQuery<ECOSTOXUDN>(queryString);
            IlistaTU.Lista = w.ToList();
        }
    }
}
