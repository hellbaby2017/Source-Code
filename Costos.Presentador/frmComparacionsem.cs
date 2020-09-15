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

namespace Costos.presentador
{
    public partial class frmComparacionsem : Form,IListaComparación
    {
         PresentadorCompsemana Objmodulo = new  PresentadorCompsemana();
        public frmComparacionsem()
        {
            InitializeComponent();
            Objmodulo.add(this);
        }

        public IEnumerable<Mvi_cCalendario> ListaCalendario
        {
            get { return (IEnumerable<Mvi_cCalendario>)this.mvicCalendarioBindingSource.DataSource; }
            set { this.mvicCalendarioBindingSource.DataSource = value; }
        }
  

        public IEnumerable<amovimientosmviT> Listacomparacion
        {
            get { return (IEnumerable<amovimientosmviT>)this.amovimientosmviTBindingSource.DataSource; }
            set { this.amovimientosmviTBindingSource.DataSource = value; }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Objmodulo.cargarcomp(Convert.ToInt32(cmbalternativa.EditValue.ToString()));
            Cursor.Current = Cursors.Default;
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
