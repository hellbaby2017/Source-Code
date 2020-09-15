using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costos.Entidades;
namespace Costos.presentador
{
    public class PresentadorKardex
    {
        IListaKardex IlistaTU;
        FuncionesCRUD CRUD = new FuncionesCRUD();
        public void add(IListaKardex IlistaITU)
        {
            IlistaTU = IlistaITU;
            CargarListaKardex();
        }
        private void CargarListaKardex()
        {
            IlistaTU.ListaAlternativa = CRUD.EntidadMVI.Mvi_cAlternativas;
        }
        public void CargarKardex(string inicio, string final, string alternativa)
        {
            ////fechaini = Convert.ToDateTime(inicio);
            //fechafin = Convert.ToDateTime(final);
            //string inicios;
            //string finals;
            //inicios=fechafin.Month.ToString & '-' 
            CRUD.EntidadAdminpaq.CommandTimeout = 0;

            string queryString = "SELECT *  FROM FKARDEX('" + inicio + "','" + final + "','" + alternativa + "') order by mMSIFecha";
            var w = CRUD.EntidadAdminpaq.ExecuteStoreQuery<EKARDEX>(queryString);
            IlistaTU.ListaKardex = w.ToList();
            //IlistaTU.ListaKardex = CRUD.EntidadAdminpaq.KARDEX(inicio, final, alternativa);
        }
    }
}
