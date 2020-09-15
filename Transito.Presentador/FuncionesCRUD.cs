using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transito.Entidades;
namespace Transito.Presentador
{
    public class FuncionesCRUD
    {
        public TransitosEntities TransitoEntidad = new TransitosEntities();
        public void refrescar()
        {
            var refreshableObjects = (from entry in TransitoEntidad.ObjectStateManager.GetObjectStateEntries(EntityState.Deleted
                                               | EntityState.Modified
                                               | EntityState.Unchanged)
                                      where entry.EntityKey != null
                                      select entry.Entity);
            TransitoEntidad.Refresh(RefreshMode.StoreWins, refreshableObjects);
        }
        public void EliminarAlmacen(int id)
        {
            DialogResult respuesta;
            respuesta = XtraMessageBox.Show("¿Realmente quiere borrar el Registro actual?", "Seleccione una opcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                var Emodulo = from p in TransitoEntidad.Svp_cAlmacenes where p.CAlmClave == id select p;
                TransitoEntidad.DeleteObject(Emodulo.Single());
                TransitoEntidad.SaveChanges();
            }
            else
                XtraMessageBox.Show("La operación se cancelo", "Operación cancelada");
        }
        public void Eliminartransito(int id)
        {
            DialogResult respuesta;
            respuesta = XtraMessageBox.Show("¿Realmente quiere borrar el Registro actual?", "Seleccione una opcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                var Emodulo = from p in TransitoEntidad.Svp_CTransito where p.cTranClave == id select p;
                TransitoEntidad.DeleteObject(Emodulo.Single());
                TransitoEntidad.SaveChanges();
            }
            else
                XtraMessageBox.Show("La operación se cancelo", "Operación cancelada");
        }
        public void Eliminarproyecto(int id)
        {
            DialogResult respuesta;
            respuesta = XtraMessageBox.Show("¿Realmente quiere borrar el Registro actual?", "Seleccione una opcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                var Emodulo = from p in TransitoEntidad.Svp_cProyectos where p.cProClave == id select p;
                TransitoEntidad.DeleteObject(Emodulo.Single());
                TransitoEntidad.SaveChanges();
            }
            else
                MessageBox.Show("La operación se cancelo", "Operación cancelada");
        }
        public void Eliminartransql(int cAlmClave, int cTranClave)
        {
            DialogResult respuesta;
            respuesta = XtraMessageBox.Show("¿Realmente quiere borrar el Registro actual?", "Seleccione una opcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                var Emodulo = from p in TransitoEntidad.Svp_rTransitosxAlmacen where p.cAlmClave == cAlmClave && p.cTranClave == cTranClave select p;
                TransitoEntidad.DeleteObject(Emodulo.Single());
                TransitoEntidad.SaveChanges();
            }
            else
                MessageBox.Show("La operación se cancelo", "Operación cancelada");
        }
        public void GuardarAlmacen(bool nuevo,Int16 cAlmClave, bool cAlmActivo, string cAlmIPServidor, string CAlmNombre, string cAlmPrefijoSIA, string CUdNContabilidad, bool cUniversal)
        {
            try

            {
                if (nuevo == true)
                {
                    //var tipousuario = new Cfg_AtiposUsuarios { causutipo=Convert.ToInt16(nousutipo), Nombre=Nombre};


                    var nuevomodulo = new Svp_cAlmacenes
                    {
                        CAlmClave=cAlmClave,
                        cAlmActivo = cAlmActivo,
                        cAlmPrefijoSIA = cAlmPrefijoSIA,
                        CUdNContabilidad = CUdNContabilidad,
                        cAlmIPServidor=cAlmIPServidor,
                        CAlmNombre=CAlmNombre,
                        cUniversal = cUniversal

                    };
                    TransitoEntidad.AddToSvp_cAlmacenes(nuevomodulo);

                }
                TransitoEntidad.SaveChanges();
                XtraMessageBox.Show("Registro guardado", "Registro");

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
        public void GuardarCTransito(bool cTranActivo,int cTranClave,string cTranNombre,bool cTranTipo)
        {
            try

            {
                if (cTranClave == 0)
                {
                    var nuevomodulo = new Svp_CTransito
                    {
                      CTranActivo=cTranActivo,
                      cTranNombre=cTranNombre,
                      cTranTipo=cTranTipo
                    };
                    TransitoEntidad.AddToSvp_CTransito(nuevomodulo);

                }
                TransitoEntidad.SaveChanges();
                XtraMessageBox.Show("Registro Guardado", "Registros");

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

        public void GuardarProyecto(Int16 cProClave,DateTime cProFechade,DateTime cProFechaha,string cProNombre, string Observaciones)
        {
            try

            {
                if (cProClave == 0)
                {
                    var nuevomodulo = new Svp_cProyectos
                    {
                        cProFechade=cProFechade,
                        cProFechaha=cProFechaha,
                        cProNombre=cProNombre,
                        Observaciones=Observaciones
                        
                    };
                    TransitoEntidad.AddToSvp_cProyectos(nuevomodulo);

                }
                TransitoEntidad.SaveChanges();
                XtraMessageBox.Show("Registro Guardado", "Registros");

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

        public void GuardarTransitosxalmacen(Int32 id,Int16 cAlmClave, Int16 ctranclave, string rMxAPrefijoFehca,string rMxASQL,bool rMxUActivo)
        {
            try

            {
                if (id == 0)
                {
                    var nuevomodulo = new Svp_rTransitosxAlmacen
                    {
                        cAlmClave=cAlmClave,
                        cTranClave=ctranclave,
                        rMxAPrefijoFehca=rMxAPrefijoFehca,
                        rMxASQL=rMxASQL,
                        rMxUActivo=rMxUActivo

                    };
                    TransitoEntidad.AddToSvp_rTransitosxAlmacen(nuevomodulo);

                }
                TransitoEntidad.SaveChanges();
                XtraMessageBox.Show("Registro Guardado", "Registros");

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
