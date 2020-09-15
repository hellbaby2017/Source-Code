using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVP.Entidades;
using System.Data;
using System.Data.Objects;

namespace SVP.presentador
{
    class Presentadorusuario
    {

        public UsuariosEntities Entidad = new UsuariosEntities(VarGlobales.Variables.conexionusuarios);
        IListaUsuario IlistaTU;
        FuncionesCRUD CRUD = new FuncionesCRUD();
        public void add(IListaUsuario IlistaITU)
        {
            IlistaTU = IlistaITU;
            CargarListaUsuarios();
        }
        private void CargarListaUsuarios()
        {
            IlistaTU.ListaTusuario = Entidad.Cfg_AtiposUsuarios.Include("Cfg_cProgramaxTipoUsuario");
            IlistaTU.Listausuario = Entidad.Cfg_cUsuarios;
        
           }
        public void Eliminar(int idMov)
        {
            CRUD.EliminarUsuario(idMov);
            CargarListaUsuarios();
        }
        public void Refrescar()
        {
            var refreshableObjects = (from entry in Entidad.ObjectStateManager.GetObjectStateEntries(EntityState.Deleted
                                                | EntityState.Modified
                                                | EntityState.Unchanged)
                                      where entry.EntityKey != null
                                      select entry.Entity);
            Entidad.Refresh(RefreshMode.StoreWins, refreshableObjects);
            CargarListaUsuarios();
        }
        public void cambiarcontra(int id,string contra)
        {
            CRUD.cambiarcontra(id, contra);
        }
        public void Guardar(int id,string nombre,string password,int tipo,bool activo)
        {
            if (string.IsNullOrEmpty(nombre) == false)
            {
                CRUD.GuardarUsuario(id, nombre, password, tipo, activo);
                CargarListaUsuarios();
            }
        }

    }
}
