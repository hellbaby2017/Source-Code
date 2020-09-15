using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transito.Entidades;

namespace Transito.Presentador
{
    public partial class frmtransitxalmacen : Form,ILTransitosql,IAlmacenes,Ilttransito
    {
        presentadorctransito objctransito = new presentadorctransito();
        PresentadorAlmacenes objAlmacenes = new PresentadorAlmacenes();
        PresentadorTransitoxalmacen objmodulo = new PresentadorTransitoxalmacen();
        public IEnumerable<Svp_rTransitosxAlmacen> ListaTuTransito
        {
            get { return (IEnumerable<Svp_rTransitosxAlmacen>)this.svp_rTransitosxAlmacenBindingSource.DataSource; }
            set { this.svp_rTransitosxAlmacenBindingSource.DataSource = value; }
        }

        public IEnumerable<Svp_cAlmacenes> ListaTusuario
        {
            get { return (IEnumerable<Svp_cAlmacenes>)this.svpcAlmacenesBindingSource.DataSource; }
            set { this.svpcAlmacenesBindingSource.DataSource = value; }
        }

        IEnumerable<Svp_CTransito> Ilttransito.ListaTuTransito
        {
            get { return (IEnumerable<Svp_CTransito>)this.svpCTransitoBindingSource.DataSource; }
            set { this.svpCTransitoBindingSource.DataSource = value; }
        }

        public void cambiarestado(bool estado)
        {
            cmbalmacen.Enabled = estado;
            cmbtran.Enabled = estado;
            txtprefijofecha.Enabled = estado;
            txtsql.Enabled = estado;
            chkactivo.Enabled = estado;
        }
        public frmtransitxalmacen()
        {
            InitializeComponent();
            objAlmacenes.add(this);
            objctransito.add(this);
            objmodulo.add(this);
        }

        private void cmdnuevo_Click(object sender, EventArgs e)
        {
            this.svp_rTransitosxAlmacenBindingSource.AddNew();
            cambiarestado(true);
        }

        private void cmdeditar_Click(object sender, EventArgs e)
        {
            cambiarestado(true);
        }

        private void cmdcancelar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) == 0)
            {
                svp_rTransitosxAlmacenBindingSource.EndEdit();
                svp_rTransitosxAlmacenBindingSource.RemoveCurrent();
            }

            objmodulo.Refrescar();
            cambiarestado(false);
        }

        private void cmdguardar_Click(object sender, EventArgs e)
        {
            objmodulo.guardar(Convert.ToInt32(txtid.Text),Convert.ToInt16(cmbalmacen.EditValue), Convert.ToInt16(cmbtran.EditValue), txtprefijofecha.Text, txtsql.Text, chkactivo.Checked);
            cambiarestado(false);
        }

        private void cmdeliminar_Click(object sender, EventArgs e)
        {
            objmodulo.eliminar(Convert.ToInt16(cmbalmacen.EditValue), Convert.ToInt16(cmbtran.EditValue));
        }
    }
}
