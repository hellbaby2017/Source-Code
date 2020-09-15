using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costos.Entidades;
using System.Data;

namespace Costos.presentador
{
    public class PresentadorMovimientos
    {
        IListaMovimientos IlistaTU;
        FuncionesCRUD CRUD = new FuncionesCRUD();
        DateTime fechainic, fechafina;
        public void add(IListaMovimientos IlistaITU)
        {
            IlistaTU = IlistaITU;
           CargarListas();
        }
        private void CargarListas()
        {
           IlistaTU.ListaAlternativas = CRUD.EntidadMVI.Mvi_cAlternativas;
            IlistaTU.ListaCalendario = CRUD.EntidadMVI.Mvi_cCalendario;
            IlistaTU.ListaCMovimientos = CRUD.EntidadAdminpaq.cmovimientosalmacen;
            fechainic = DateTime.Today;
            fechafina = DateTime.Today;
        }
        public void Cargarmovimientos(DateTime fechaini,DateTime fechafin)
        {
            CRUD.EntidadAdminpaq.CommandTimeout = 0;
            fechainic = fechaini;
            fechafina = fechafin;
            IlistaTU.ListaMovimientos = CRUD.EntidadAdminpaq.mmovimientos.Where(b => b.mMSIFecha >= fechaini).Where(b => b.mMSIFecha <= fechafin);
        }
        public int EliminarMov(int id)
        {

            return CRUD.eliminarmovimiento(id);
        }
 
        public void refrescar(IListaMovimientos IlistaITU)
        {

            //CRUD.EntidadAdminpaq.CommandTimeout = 0;

            CRUD.Refrescar();
            IlistaTU = IlistaITU;
            //Cargarmovimientos(fechainic, fechafina);
        }
        public void nosemana(DateTime fecha,mmovimientos entidad)
        {
            CRUD.nosemana(fecha,entidad);
        }
        public void guardar(int id, string almacen, int cCalClave, Decimal costo, string alternativa, int mov, string clavefab, string detalle, string factura, DateTime fecham, DateTime fechaf, int folio, string lote, string pedimento, string remision, int unidades)
        {
            
            CRUD.GuardarMovimiento(id, almacen, cCalClave, costo, alternativa, mov, clavefab, detalle, factura, fecham, fechaf, folio, lote, pedimento, remision, unidades);

             
            //recalcularinv();
            //CRUD.Refrescar();

        }
        public mmovimientos nuevomov()
        {
            return CRUD.nuevomovimiento();
        }

        public void recalcularinv()
        {
            CRUD.RecalcularInv();
        }
        public void scosto(string alternativa,mmovimientos entidad )
        {
             CRUD.scosto(alternativa,entidad);
        }
        
    }

}
