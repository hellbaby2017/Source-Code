using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costos.Entidades;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Collections;

namespace Costos.presentador
{
    public class PresentadorCostoxalt
    {
        IlistaCostoxalt IlistaTU;
        FuncionesCRUD CRUD = new FuncionesCRUD();
        public void add(IlistaCostoxalt IlistaITU)
        {
            IlistaTU = IlistaITU;
     
        }
        public void cargarxalt(string fechaini,string fechafin)
        {
            //            string queryString = @"select ct.cTiPNombre as tipo,tabla1.cAltClave,SUM(tabla1.Unidades)as unidades,SUM(tabla1.costo) as Costo from (SELECT     tabla.cAltClave, cmovimientosalmacen_2.cMoANombre, tabla.Unidades, tabla.Costo
            //FROM(SELECT     mmovimientos_1.cAltClave, cmovimientosalmacen_1.cMoAClave AS movimiento,
            //                                             SUM(CASE WHEN cmoatipomovto = 0 THEN unidades  ELSE unidades * -1 END) AS Unidades,
            //                                             SUM(CASE WHEN cmoatipomovto = 0 THEN unidades  ELSE unidades * -1 END * mmovimientos_1.Costo) AS Costo
            //                       FROM         mmovimientos AS mmovimientos_1 INNER JOIN
            //                                             cmovimientosalmacen AS cmovimientosalmacen_1 ON mmovimientos_1.cMoAClave = cmovimientosalmacen_1.cMoAClave
            //                       WHERE(mmovimientos_1.mMSIFecha >= @fechaini) AND(mmovimientos_1.mMSIFecha <= @fechafin) and mmovimientos_1.cMoAClave in(14,4)
            //                       GROUP BY mmovimientos_1.cAltClave, cmovimientosalmacen_1.cMoAClave) AS tabla INNER JOIN
            //                      cmovimientosalmacen AS cmovimientosalmacen_2 ON tabla.movimiento = cmovimientosalmacen_2.cMoAClave) as tabla1 inner join[192.168.1.149].MVI_IP.dbo.Mvi_cAlternativas as alt ON alt.cAltClave = tabla1.cAltClave inner join[192.168.1.149].MVI_IP.dbo.Mvi_cTiposProducto as ct ON ct.cTiPClave = alt.cTiPClave
            //GROUP BY tabla1.cAltClave,ct.cTiPNombre";
            //            var w=CRUD.EntidadAdminpaq.CreateQuery<CostoxAltT>(queryString,new ObjectParameter("fechaini",fechaini),new ObjectParameter("fechafin", fechafin));
            //    ObjectQuery<Contact> contactQuery =
            //context.CreateQuery<Contact>(queryString,
            //    new ObjectParameter("fn", "Frances"));
            CRUD.EntidadAdminpaq.CommandTimeout = 0;
            //var q = from costoxalt in CRUD.EntidadAdminpaq.CostoxAlt(fechaini, fechafin)
            //        select new CostoxAltT
            //        {
            //            cAltClave = costoxalt.cAltClave,
            //            Costo = costoxalt.Costo,
            //            tipo = costoxalt.tipo,
            //            unidades = costoxalt.unidades
            //        };

            //IlistaTU.ListaCostoxalt = q;
            
            //var w = CRUD.EntidadAdminpaq.CreateObjectSet< CostoxAlt_Result(fechaini, fechafin) > ().Select(p => new
            //{
            //    cAltClave = p.cAltClave,
            //    Costo = p.Costo,
            //    tipo = p.tipo,
            //    unidades = p.unidades
            //});
            //IlistaTU.ListaCostoxalt = CRUD.EntidadAdminpaq.CostoxAlt(fechaini, fechafin);
            //ObjectParameter fecha1 = new ObjectParameter("fechaini", fechaini);
            //ObjectParameter fecha2 = new ObjectParameter("fechafin", fechafin);
            string queryString = "SELECT tipo, cAltClave, unidades, Costo FROM FCOSTOSXALT('" + fechaini + "','" + fechafin + "')";
            var w = CRUD.EntidadAdminpaq.ExecuteStoreQuery<ECOSTOXALT>(queryString);
            IlistaTU.ListaCostoxalt = w.ToList();
            //IlistaTU.ListaCostoxalt=CRUD.EntidadAdminpaq.ExecuteFunction()
            //IlistaTU.ListaCostoxalt = CRUD.EntidadAdminpaq.ExecuteFunction("CostoxAlt",fecha1,fecha2);
        }

       


    }
}
