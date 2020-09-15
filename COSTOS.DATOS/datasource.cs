using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Costos.Entidades;

using System.Data.Entity;
using System.Data.Objects;

namespace COSTOS.DATOS
{
    public partial class datasource : BindingSource
    {
      
        public datasource()
        {
            InitializeComponent();
        }
        public void RecalcularInv()
        {
            adminpaqEntities Entidadadmin;
            Entidadadmin = new adminpaqEntities();
            var q = Entidadadmin.ExecuteFunction("AInventarioI");

   MessageBox.Show("Recalculo de Inventario Exitoso", "Inventario");
        }
        public void Registrarlog(string modulo,string control,string descripcion,string usuario)
        {
            using (var context =new adminpaqEntities())
            {
                var log = new LOGG
                {
                    Fecha = DateTime.Today,
                    hora= DateTime.Now.TimeOfDay,
                    Mensaje=descripcion,
                    Modulo=modulo,
                    Usuario=usuario,
                    Valor=control
                };
                context.AddToLOGG(log);
                context.SaveChanges();
            }

        }
        public void refrescar(ObjectContext entidad)
        {
            var refreshableObjects = (from entry in entidad.ObjectStateManager.GetObjectStateEntries(EntityState.Deleted
                                                | EntityState.Modified
                                                | EntityState.Unchanged)
                                      where entry.EntityKey != null
                                      select entry.Entity);
            entidad.Refresh(RefreshMode.StoreWins, refreshableObjects);
        }
        public void Guardar(ObjectContext entidad)
        {
            entidad.SaveChanges();
            var refreshableObjects = (from entry in entidad.ObjectStateManager.GetObjectStateEntries(EntityState.Deleted
                                                | EntityState.Modified
                                                | EntityState.Unchanged)
                                      where entry.EntityKey != null
                                      select entry.Entity);
            entidad.Refresh(RefreshMode.StoreWins, refreshableObjects);
            MessageBox.Show("Registro Guardado Correctamente", "Registro");
        }
        public void eliminar(ObjectContext entidad)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Realmente quiere borrar el Registro actual?", "Seleccione una opcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.RemoveCurrent();
                entidad.SaveChanges();
                this.refrescar(entidad);
                //cfg_AtiposUsuariosBindingSource.RemoveCurrent();
                //entityDataSource1.SaveChanges();
                //entityDataSource1.Refresh();
            }
            else
                MessageBox.Show("La operación se cancelo", "Operación cancelada");

        }

    }
}
