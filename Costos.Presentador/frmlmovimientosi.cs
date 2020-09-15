using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Costos.Entidades;
using DevExpress.Utils;

namespace Costos.presentador
{
    public partial class frmlmovimientosi : Form,IListaMovimientos
    {
        PresentadorMovimientos Objmodulo = new PresentadorMovimientos();
      

        public IEnumerable<mmovimientos> ListaMovimientos
        {
            get { return (IEnumerable<mmovimientos>)this.mmovimientosBindingSource.DataSource; }
            set { this.mmovimientosBindingSource.DataSource = value; }
        }

        IEnumerable<Mvi_cCalendario> IListaMovimientos.ListaCalendario
        {
            get { return (IEnumerable<Mvi_cCalendario>)this.mvicCalendarioBindingSource.DataSource; }
            set { this.mvicCalendarioBindingSource.DataSource = value; }
        }

        IEnumerable<Mvi_cAlternativas> IListaMovimientos.ListaAlternativas
        {
            get { return (IEnumerable<Mvi_cAlternativas>)this.mvicAlternativasBindingSource.DataSource; }
            set { this.mvicAlternativasBindingSource.DataSource = value; }
        }

        IEnumerable<cmovimientosalmacen> IListaMovimientos.ListaCMovimientos
        {
            get { return (IEnumerable<cmovimientosalmacen>)this.cmovimientosalmacenBindingSource.DataSource; }
            set { this.cmovimientosalmacenBindingSource.DataSource = value; }
        }

        IEnumerable<mmovimientos> IListaMovimientos.ListaMovimientos
        {
            get { return (IEnumerable<mmovimientos>)this.mmovimientosBindingSource.DataSource; }
            set { this.mmovimientosBindingSource.DataSource = value; }
        }

        public frmlmovimientosi()
        {
            InitializeComponent();
            Objmodulo.add(this);

        }

          
        private void btguardar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Objmodulo.guardar(Convert.ToInt32(txtno.Text), txtalmacen.Text, Convert.ToInt32(cmbcalendario.EditValue), Convert.ToDecimal(txtcostou.Text), Convert.ToString(cmbalternativa.EditValue), Convert.ToInt32(cmbmovimiento.EditValue), txtclavefab.Text, txtdetalle.Text, txtnofactura.Text, Convert.ToDateTime(datefecha.EditValue), Convert.ToDateTime(datefechafac.EditValue), Convert.ToInt32(txtfolioalmacen.Text), txtnolote.Text, txtnopedimento.Text, txtnoremision.Text, Convert.ToInt32(txtunidades.Text));
            Objmodulo.Cargarmovimientos(Convert.ToDateTime(datefecha.Text), Convert.ToDateTime(dtafinal.Text));
            cambiarestado(false);
            Cursor.Current = Cursors.Default;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Objmodulo.Cargarmovimientos(Convert.ToDateTime(dtainicio.Text), Convert.ToDateTime(dtafinal.Text));
            Cursor.Current = Cursors.Default;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            cambiarestado(true);

        }
        private void cambiarestado(Boolean Estado)
        {
            txtno.Enabled = Estado;
            txtalmacen.Enabled = Estado;
            txtclavefab.Enabled = Estado;
            txtcostou.Enabled = Estado;
            txtdetalle.Enabled = Estado;
            txtfolioalmacen.Enabled = Estado;
            txtnofactura.Enabled = Estado;
            txtnolote.Enabled = Estado;
            txtnopedimento.Enabled = Estado;
            txtnoremision.Enabled = Estado;
            txtunidades.Enabled = Estado;
            cmbalternativa.Enabled = Estado;
            cmbcalendario.Enabled = Estado;
            cmbmovimiento.Enabled = Estado;
            datefecha.Enabled = Estado;
            datefechafac.Enabled = Estado;
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            if  (Objmodulo.EliminarMov(Convert.ToInt32(this.txtno.Text)) == 1)
                {
                Objmodulo.refrescar(this);
                cambiarestado(false);
            }

        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            mmovimientosBindingSource.CancelEdit();
            mmovimientosBindingSource.ResetCurrentItem();
            mmovimientosBindingSource.ResetBindings(false);
            if (txtno.Text=="0")
            {
                mmovimientosBindingSource.RemoveCurrent();
            }
            Objmodulo.refrescar(this);
                cambiarestado(false);
            Cursor.Current = Cursors.Default;
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            cambiarestado(true);
            mmovimientosBindingSource.Add(Objmodulo.nuevomov());
            mmovimientosBindingSource.MoveLast();
            mmovimientosBindingSource.EndEdit();

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Exportar.exportarexcel(this.gridControl1);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Exportar.exportarpdf(this.gridControl1);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Exportar.exportarhtml(this.gridControl1);
        }

        private void cmbalternativa_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbalternativa.Enabled==true)
            {
            //    mmovimientosBindingSource.ResetCurrentItem();
            //    //mmovimientos movimiento = (mmovimientos)mmovimientosBindingSource.Current;
                Objmodulo.scosto(Convert.ToString(cmbalternativa.Text), (mmovimientos)mmovimientosBindingSource.Current);
                mmovimientosBindingSource.ResetCurrentItem();
                //    //mmovimientosBindingSource.Current
            }
        }

        private void cmbalternativa_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (cmbalternativa.Enabled == true)
            {
                Objmodulo.scosto(Convert.ToString(cmbalternativa.Text), (mmovimientos)mmovimientosBindingSource.Current);
            }
        }

        private void datefecha_EditValueChanged(object sender, EventArgs e)
        {
            if (datefecha.Enabled == true)
            {
                Objmodulo.nosemana(Convert.ToDateTime(datefecha.Text), (mmovimientos)mmovimientosBindingSource.Current);
            }

        }
    }
    
}
