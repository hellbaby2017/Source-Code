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
    public partial class FrmRInvetarioxfecha : Form,IListaInventarioxFecha
    {
        PresentadosInventarioxfecha Objmodulo = new PresentadosInventarioxfecha();
        public IEnumerable<EMCAPAS> ListaAlternativa
        {
            get { return (IEnumerable<EMCAPAS>)this.EMCAPASBindingSource.DataSource; }
            set { this.EMCAPASBindingSource.DataSource = value; }
        }

        public FrmRInvetarioxfecha()
        {
            InitializeComponent();
            Objmodulo.add(this);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtainicio.Text) == false )
            {
                Cursor.Current = Cursors.WaitCursor;
                Objmodulo.CargarKardex(dtainicio.Text);
                Cursor.Current = Cursors.Default;
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
