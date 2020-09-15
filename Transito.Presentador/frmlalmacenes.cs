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
    public partial class frmlalmacenes : Form,IAlmacenes
    {
        PresentadorAlmacenes objmodulo = new PresentadorAlmacenes();
        bool nuevo = false;
        public frmlalmacenes()
        {
            InitializeComponent();
            objmodulo.add(this);
        }

        public IEnumerable<Svp_cAlmacenes> ListaTusuario
        {
            get { return (IEnumerable<Svp_cAlmacenes>)this.svp_cAlmacenesBindingSource.DataSource; }
            set { this.svp_cAlmacenesBindingSource.DataSource = value; }
        }
        public void cambiarestado(bool estado)
        {
            txtnomalmacen.Enabled = estado;
            txtceco.Enabled = estado;
            txtipservidor.Enabled = estado;
            txtnomalmacen.Enabled = estado;
            txtprefijosia.Enabled = estado;
            chkuniversal.Enabled = estado;
            chkactivo.Enabled = estado;
            textnoalmacen.Enabled = estado;
        }

       

        private void simpleButton5_Click(object sender, EventArgs e)
        {
     
            this.svp_cAlmacenesBindingSource.AddNew();
            nuevo = true;
            cambiarestado(true);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            nuevo = false;
            cambiarestado(true);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textnoalmacen.Text) == 0)
            {
                svp_cAlmacenesBindingSource.EndEdit();
                svp_cAlmacenesBindingSource.RemoveCurrent();
            }
            objmodulo.Refrescar();
            cambiarestado(false);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            objmodulo.guardar(nuevo,Convert.ToInt16( textnoalmacen.Text), chkactivo.Checked, txtipservidor.Text, txtnomalmacen.Text,txtprefijosia.Text,txtceco.Text,chkuniversal.Checked);
            nuevo = false;
            cambiarestado(false);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            objmodulo.eliminar(Convert.ToInt16( textnoalmacen.Text));
            cambiarestado(false);
        }
    }
}
