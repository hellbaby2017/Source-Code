using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costos.Entidades;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data;
using System.Data.Entity;
using System.Reflection;
using System.Data.Entity.Validation;
using DevExpress.XtraEditors;
namespace Costos.presentador
{
    public class FuncionesCRUD
    {
        public MVI_IPEntities EntidadMVI = new MVI_IPEntities(VarGlobales.Variables.conexionMVI);
        public adminpaqEntities EntidadAdminpaq = new adminpaqEntities(VarGlobales.Variables.conexionAdminpaq);
        DataTable dt = new DataTable();
        Costos.Funciones.FUNCIONES objfuncion = new Costos.Funciones.FUNCIONES();
        public void Registrarlog(string modulo, string control, string descripcion, string usuario)
        {
            using (var context = new adminpaqEntities(VarGlobales.Variables.conexionAdminpaq))
            {
                var log = new LOGG
                {
                    Fecha = DateTime.Today,
                    hora = DateTime.Now.TimeOfDay,
                    Mensaje = descripcion,
                    Modulo = modulo,
                    Usuario = usuario,
                    Valor = control
                };
                context.AddToLOGG(log);
                context.SaveChanges();
            }

        }
        public void Importarmvi(int semana)
        {

            try
            {

                EntidadAdminpaq.CommandTimeout = 0;
                string queryString;
                queryString = "exec CMOVEXPORTAR " + semana;
                var list = EntidadAdminpaq.ExecuteStoreQuery<cMovReproceso>(queryString).ToList();
                //var list = EntidadAdminpaq.CMOVEXPORTAR(semana).ToList();
                dt = ToDataTable<cMovReproceso>(list);
                objfuncion.exportación(dt);
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
        public void importarTabla(DataTable tabla)
        {
            objfuncion.exportación(tabla);
        }
        public string llamar()
        {
            return Convert.ToString(objfuncion.contador);
        }
        public string llamar2()
        {
            return Convert.ToString(objfuncion.total);
        }

        public void Cambiarsemana(int origen, int destino)
        {
            int cantidad;
            DialogResult respuesta;
            string mensaje;
            var q = from p in EntidadAdminpaq.mmovimientos where p.cCalClave == origen select p;
            q.ToList().ForEach(x => x.cCalClave = destino);
            cantidad = q.Count();
            mensaje = "Realmente quieres cambiar " + Convert.ToString(cantidad) + " Registros";
            Cursor.Current = Cursors.Default;
            respuesta = XtraMessageBox.Show(mensaje, "Cambiar Semana", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                EntidadAdminpaq.SaveChanges();
                XtraMessageBox.Show("Semana Cambiada", "Semanas");
                Cursor.Current = Cursors.Default;
            }
            else
                XtraMessageBox.Show("Cancelado", "Semanas");
        }
 
        public int eliminarmovimiento(int id)
        {
            DialogResult respuesta;
            respuesta = XtraMessageBox.Show("¿Realmente quiere borrar el Registro actual? Se recomienda recostear despues de borrar el Registro", "Seleccione una opcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                var Emodulo = from p in EntidadAdminpaq.mmovimientos where p.idMMovimientos == id select p;
                EntidadAdminpaq.DeleteObject(Emodulo.Single());
                EntidadAdminpaq.SaveChanges();
                var q = EntidadAdminpaq.ExecuteFunction("AInventarioI");
                return 1;
            }
            else
            {
                XtraMessageBox.Show("La operación se cancelo", "Operación cancelada");
                return 0;
            }

        }
        public  DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (System.Reflection.PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
        public void Refrescar()
        {
            var refreshableObjects = (from entry in EntidadAdminpaq.ObjectStateManager.GetObjectStateEntries(EntityState.Deleted
                                                | EntityState.Modified
                                                | EntityState.Unchanged)
                                      where entry.EntityKey != null
                                      select entry.Entity);
            EntidadAdminpaq.Refresh(RefreshMode.StoreWins, refreshableObjects);

        }
      public string ultmsemana()
        {

            string sqlQuery = "SELECT * from  CALMVIU()";
            var list=EntidadAdminpaq.ExecuteStoreQuery<cMovCalc>(sqlQuery).ToList();
            return list.FirstOrDefault().semana.ToString();
        }
        public mmovimientos nuevomovimiento()
        {
            var nuevomov = new mmovimientos
            {
                cAlmClave = "111",
                cCalClave = 1,
                mMSIFecha = DateTime.Today,
                mMSIFechaFactura = DateTime.Today,
                Unidades = 0
            };
            return nuevomov;
        }

        public void RecalcularInv()
        {

            var q = EntidadAdminpaq.ExecuteFunction("AInventarioI");

            XtraMessageBox.Show("Recalculo de Inventario Exitoso", "Inventario");
        }
      
        public void BorrarSemana(int semana)
        {
            //ObjectParameter calendario = new ObjectParameter("Semana", semana);
            //var q = EntidadAdminpaq.ExecuteFunction("BorrarSemana",calendario);

            string sqlQuery = "EXEC BorrarSemana " +  Convert.ToString(semana) ;
            var list = EntidadAdminpaq.ExecuteStoreQuery<List<string>>(sqlQuery);
            
            //var Emodulo = from p in EntidadAdminpaq.mmovimientos where p.cCalClave == semana select p;
            //foreach (mmovimientos f in EntidadAdminpaq.mmovimientos.Where (f=>f.cCalClave==semana))
            //{

            //    //EntidadAdminpaq.Attach(f);
            //    EntidadAdminpaq.DeleteObject(f);
            //}

            //EntidadAdminpaq.SaveChanges();
            XtraMessageBox.Show("Semana borrada exitosamente", "Inventario");
        }
        public void GuardarMovimiento(int id, string almacen,int cCalClave,Decimal costo,string alternativa,int mov,string clavefab,string detalle,string factura,DateTime fecham,DateTime fechaf,int folio,string lote,string pedimento,string remision,int unidades)
        {
            
            try
                 
            {

                if (id == 0)
                {
                    //var tipousuario = new Cfg_AtiposUsuarios { causutipo=Convert.ToInt16(nousutipo), Nombre=Nombre};


                    var nuevomodulo = new mmovimientos
                    {
                        cAlmClave = almacen,
                        cCalClave= cCalClave,
                        Costo=costo,
                        cAltClave=alternativa,
                        cMoAClave=mov,
                        cPrvClaveFab=clavefab,
                        Detalle=detalle,
                        mMSICostoP=costo,
                        mMSIFactura=factura,
                        mMSIFecha=fecham,
                        mMSIFechaFactura=fechaf,
                        mMSIFolio=folio,
                        mMSILote=lote,
                        mMSIPedimento=pedimento,
                        mMSIRemision=remision,
                        Unidades=unidades
    
                    };
                    EntidadAdminpaq.AddTommovimientos(nuevomodulo);
                }
                EntidadAdminpaq.SaveChanges();
                Refrescar();
                string queryString;
                string mes;
                string dia;
                dia = fecham.Day.ToString();
                mes = fecham.Month.ToString();
                if (mes.Length == 1)
                    {
                    mes = '0' + mes;
                }
                if (dia.Length == 1)
                {
                    dia = '0' + dia;
                }
                queryString = "exec ReprocesarAltxfecha '" + alternativa +"','"+ fecham.Year + mes + dia +"'";
                //var list = (from qq in EntidadAdminpaq.ReprocesarAlt(alternativa)
                //            select qq).ToList();
                var list = EntidadAdminpaq.ExecuteStoreQuery<cMovReproceso>(queryString).ToList();
                DataTable dt = ToDataTable<cMovReproceso>(list);
                importarTabla(dt);


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
        public void scosto(string alternativa,mmovimientos entidad )
        {
            var q = from p in EntidadAdminpaq.mcapas where p.cAltClave == alternativa select p.Costo;
            List<decimal> item = q.ToList();

            if (item.Count==0)
            {
                var w = from p in EntidadMVI.Mvi_cAlternativas where p.cAltClave == alternativa select p.cAltPrecioCompra;
                List<decimal> item2 = q.ToList();
                if (item2.Count > 0)
                {
                    entidad.Costo= item2[0];
                    entidad.cAltClave = alternativa;
                }
                else
                {
                    entidad.Costo= 0;
                    entidad.cAltClave = alternativa;
                }
            }
            else
            {
                entidad.Costo= item[0];
                entidad.cAltClave = alternativa;

            }
          
            
        }
        public void nosemana(DateTime fecha,mmovimientos entidad)
        {
            var q = from p in EntidadMVI.Mvi_cCalendario where p.cCalFechaInicio <= fecha && p.cCalFechaFinal >= fecha select p.cCalClave;
            List<int> item = q.ToList();
            if (item.Count > 0)
            {
                entidad.cCalClave = item[0];
                entidad.mMSIFecha = fecha;
            }
            else
            {
                XtraMessageBox.Show("La fecha no tiene un calendario asignado", "Fecha");
                entidad.cCalClave = 0;
                entidad.mMSIFecha = fecha;
            }
        }
        public void importarInf(int semana)
        {

        }
    }
}

