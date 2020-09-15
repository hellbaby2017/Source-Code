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
    public partial class frmproyecto : Form,ILProyecto
    {
        PresentadorProyecto objmodulo = new PresentadorProyecto();
        public IEnumerable<Svp_cProyectos> ListaProyectos
        {
            get { return (IEnumerable<Svp_cProyectos>)this.svp_cProyectosBindingSource.DataSource; }
            set { this.svp_cProyectosBindingSource.DataSource = value; }
        }
        public void cambiarestado(bool estado)
        {
            txtnoproyecto.Enabled = estado;
            txtnombreproyecto.Enabled = estado;
            txtobservacion.Enabled = estado;
            datefecha.Enabled = estado;
            datefechaa.Enabled = estado;
        }
        public frmproyecto()
        {
            InitializeComponent();
            objmodulo.add(this);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.svp_cProyectosBindingSource.AddNew();
            cambiarestado(true);
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            cambiarestado(true);
        }

        private void cmdcancelar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtnoproyecto.Text) == 0)
            {
                svp_cProyectosBindingSource.EndEdit();
                svp_cProyectosBindingSource.RemoveCurrent();
            }
            objmodulo.Refrescar();
            cambiarestado(false);
        }

        private void cmdeliminar_Click(object sender, EventArgs e)
        {
            objmodulo.eliminar(Convert.ToInt16(txtnoproyecto.Text));
        }

        private void cmdguardar_Click(object sender, EventArgs e)
        {
            objmodulo.guardar(Convert.ToInt16(txtnoproyecto.Text),Convert.ToDateTime(datefecha.Text),Convert.ToDateTime(datefechaa.Text),txtnombreproyecto.Text,txtobservacion.Text);
            cambiarestado(false);
        }
    }
}
