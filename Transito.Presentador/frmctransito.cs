using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Transito.Entidades;

namespace Transito.Presentador
{
    public partial class frmctransito : Form,Ilttransito
    {
        presentadorctransito objmodulo = new presentadorctransito();
        public frmctransito()
        {
            InitializeComponent();
            objmodulo.add(this);
        }
        public void cambiarestado(bool estado)
        {
            txtid.Enabled= estado;
            chktipo.Enabled = estado;
            txtnombre.Enabled = estado;
            chkactivo.Enabled = estado;
        }

        public IEnumerable<Svp_CTransito> ListaTuTransito
        {
            get { return (IEnumerable<Svp_CTransito>)this.svp_CTransitoBindingSource.DataSource; }
            set { this.svp_CTransitoBindingSource.DataSource = value; }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            objmodulo.eliminar(Convert.ToInt16(txtid.Text));
            cambiarestado(false);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.svp_CTransitoBindingSource.AddNew();
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
                svp_CTransitoBindingSource.EndEdit();
                svp_CTransitoBindingSource.RemoveCurrent();
            }
            objmodulo.Refrescar();
            cambiarestado(false);
        }

        private void cmdguardar_Click(object sender, EventArgs e)
        {
            objmodulo.guardar(chkactivo.Checked, Convert.ToInt32(txtid.Text), txtnombre.Text, chktipo.Checked);
            objmodulo.Refrescar();
            cambiarestado(false);
        }
    }
}
