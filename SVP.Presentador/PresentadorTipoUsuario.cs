using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVP.Entidades;
using System.Data;
using System.Data.Objects;
using System.Windows.Forms;
using System.Xml;
using System.Data.Entity.Validation;
using DevExpress.XtraEditors;

namespace SVP.presentador
{
    public class PresentadorTipoUsuario
    {
        public UsuariosEntities Entidad = new UsuariosEntities(VarGlobales.Variables.conexionusuarios);
        IlistatipoUsuario IlistaTU;
        public void add(IlistatipoUsuario IlistaITU)
        {
            IlistaTU = IlistaITU;
            CargarListaTipoUsuarios();
        }
        private void CargarListaTipoUsuarios()
        {
            IlistaTU.ListaTusuario = Entidad.Cfg_AtiposUsuarios.Include("Cfg_cProgramaxTipoUsuario")
            .Include("Cfg_cModuloxUsuario");
            IlistaTU.ListaPrograma = Entidad.Cfg_Programa;
            IlistaTU.ListaModulo = Entidad.Cfg_cModulos;

        }
        public void EliminarTP(int idMov)
        {
            DialogResult respuesta;
            respuesta = XtraMessageBox.Show("¿Realmente quiere borrar el Registro actual?", "Seleccione una opcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                var Emodulo = from p in Entidad.Cfg_AtiposUsuarios where p.causutipo == idMov select p;
                Entidad.DeleteObject(Emodulo.Single());
                Entidad.SaveChanges();
                CargarListaTipoUsuarios();
            }
            else
                XtraMessageBox.Show("La operación se cancelo", "Operación cancelada");
        }
        public void EliminarMT(int idMov)
        {
            DialogResult respuesta;
            respuesta = XtraMessageBox.Show("¿Realmente quiere borrar el Registro actual?", "Seleccione una opcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                var Emodulo = from p in Entidad.Cfg_cModuloxUsuario where p.IdModxusu == idMov select p;
                Entidad.DeleteObject(Emodulo.Single());
                Entidad.SaveChanges();
                CargarListaTipoUsuarios();
            }
            else
                XtraMessageBox.Show("La operación se cancelo", "Operación cancelada");
        }
        public void EliminarPT(int idMov)
        {
            DialogResult respuesta;
            respuesta = XtraMessageBox.Show("¿Realmente quiere borrar el Registro actual?", "Seleccione una opcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                var Emodulo = from p in Entidad.Cfg_cProgramaxTipoUsuario where p.ctipoxprogramaclave == idMov select p;
                Entidad.DeleteObject(Emodulo.Single());
                Entidad.SaveChanges();
                CargarListaTipoUsuarios();
            }
            else
                XtraMessageBox.Show("La operación se cancelo", "Operación cancelada");
        }
        public void GuardarPU(int nousutipo, int nommodulo, int idmodulo, string Nombre)
        {
            try

            {
                if (nommodulo == 0)
                {
                    //var tipousuario = new Cfg_AtiposUsuarios { causutipo=Convert.ToInt16(nousutipo), Nombre=Nombre};
                
                    var tipousuario = Entidad.Cfg_AtiposUsuarios.Include("Cfg_cProgramaxTipoUsuario").Where(b => b.causutipo == nousutipo).FirstOrDefault();
                    var nuevomodulo = new Cfg_cProgramaxTipoUsuario
                    {
                        cPrograma = Convert.ToInt16(idmodulo)
                 

                    };
                    tipousuario.Cfg_cProgramaxTipoUsuario.Add(nuevomodulo);
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
        public void GuardarMU(int nousutipo,int nommodulo, int idmodulo,string Nombre)
        {
            try

            {
                if (nommodulo == 0)
                {
                    //var tipousuario = new Cfg_AtiposUsuarios { causutipo=Convert.ToInt16(nousutipo), Nombre=Nombre};

                    var tipousuario = Entidad.Cfg_AtiposUsuarios.Include("Cfg_cModuloxUsuario").Where(b => b.causutipo == nousutipo).FirstOrDefault();
                    var nuevomodulo = new Cfg_cModuloxUsuario
                    {
                                  
                        cModulo = Convert.ToInt16(idmodulo),

                    };
                    tipousuario.Cfg_cModuloxUsuario.Add(nuevomodulo);
    

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
    
        public void Refrescar()
        {
            var refreshableObjects = (from entry in Entidad.ObjectStateManager.GetObjectStateEntries(EntityState.Deleted
                                                | EntityState.Modified
                                                | EntityState.Unchanged)
                                      where entry.EntityKey != null
                                      select entry.Entity);
            Entidad.Refresh(RefreshMode.StoreWins, refreshableObjects);
            CargarListaTipoUsuarios();
        }
      
        public void GuardarTP(string nommodulo, int idmodulo)
        {
            try

            {
                if (idmodulo == 0)
                {
                    var modulo = new Cfg_AtiposUsuarios
                    {
                        Nombre = nommodulo

                    };
                    Entidad.AddToCfg_AtiposUsuarios(modulo);
                }

                Entidad.SaveChanges();
                Refrescar();
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
