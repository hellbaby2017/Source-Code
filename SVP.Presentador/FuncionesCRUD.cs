using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVP.Entidades;
using System.Data.Entity.Validation;
using DevExpress.XtraEditors;

namespace SVP.presentador
{
    public class FuncionesCRUD
    {
        UsuariosEntities entidad = new UsuariosEntities(VarGlobales.Variables.conexionusuarios);
        public void cambiarcontra(int id,string contra)
        {
            int x = entidad.ExecuteStoreCommand("EXEC CambiarContraseña " + id + "," + contra + " ");
        }
        public void Refrescar(ObjectContext entidad)
        {
            var refreshableObjects = (from entry in entidad.ObjectStateManager.GetObjectStateEntries(EntityState.Deleted
                                                | EntityState.Modified
                                                | EntityState.Unchanged)
                                      where entry.EntityKey != null
                                      select entry.Entity);
            entidad.Refresh(RefreshMode.StoreWins, refreshableObjects);
        }
        public void EliminarUsuario(int id)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Realmente quiere borrar el Registro actual?", "Seleccione una opcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                var Emodulo = from p in entidad.Cfg_cUsuarios where p.cUsuClave == id select p;
                entidad.DeleteObject(Emodulo.Single());
                entidad.SaveChanges();
            }
            else
                MessageBox.Show("La operación se cancelo", "Operación cancelada");
        }
        public void GuardarUsuario(int id, string nombre, string password, int tipo, bool activo)
        {
            try

            {
                if (id == 0)
                {
                    //var tipousuario = new Cfg_AtiposUsuarios { causutipo=Convert.ToInt16(nousutipo), Nombre=Nombre};


                    var nuevomodulo = new Cfg_cUsuarios
                    {
                        cUsuNombre=nombre,
                        cUsucontrasena=password,
                        cUsuActivo=activo,
                        causutipo=Convert.ToInt16(tipo)
                    };
                    entidad.AddToCfg_cUsuarios(nuevomodulo);
                }
                entidad.SaveChanges();
                XtraMessageBox.Show("Usuario Guardado", "Usuarios");

            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " La Validación del error : ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }
    }
}
