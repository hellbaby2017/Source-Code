using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVP.Entidades;
using System.Data;
using System.Data.Objects;
using System.Windows.Forms;
using System.Data.Entity.Validation;

namespace SVP.presentador
{
    public class PresentadorListas
    {
        public UsuariosEntities Entidad = new UsuariosEntities(VarGlobales.Variables.conexionusuarios);
        IListasInterface Ilista;

        public void add(IListasInterface IlistaI)
        {
            Ilista = IlistaI;
            CargarListaModulos();

        }


        private void CargarListaModulos()
        {


            var ListaModulos = from MOdulo in Entidad.Cfg_cModulos select MOdulo;
          //  int selectmodulo = Ilista.SelectModulo >= 0 ? Ilista.SelectModulo : 0;
  
            Ilista.ListaModulo = ListaModulos.ToList();
            //Ilista.ListaModulo2 = Entidad.Cfg_cModulos;
          //  Ilista.SelectModulo = selectmodulo;
            // _view.SelectedCustomer = selectedCustomer;
        }
        public void Eliminar(int idMov)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Realmente quiere borrar el Registro actual?", "Seleccione una opcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                var Emodulo = from p in Entidad.Cfg_cModulos where p.cModulo == idMov select p;
                Entidad.DeleteObject(Emodulo.Single());
                Entidad.SaveChanges();
                CargarListaModulos();
            }
            else
                MessageBox.Show("La operación se cancelo", "Operación cancelada");
        }
        public void Refrescar()
        {
            var refreshableObjects = (from entry in Entidad.ObjectStateManager.GetObjectStateEntries(EntityState.Deleted
                                                | EntityState.Modified
                                                | EntityState.Unchanged)
                                      where entry.EntityKey != null
                                      select entry.Entity);
            Entidad.Refresh(RefreshMode.StoreWins, refreshableObjects);
            CargarListaModulos();
        }
        public void Guardar(string nommodulo,int idmodulo)
        {
            try

            {
                if (idmodulo == 0)
                {
                    var modulo = new Cfg_cModulos
                    {
                        Nombre = nommodulo
                        
                    };
                    Entidad.AddToCfg_cModulos(modulo);
                }
                
                Entidad.SaveChanges();
                Refrescar();
            
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
        public void Nuevo()
        {
            
        }
    }
}
