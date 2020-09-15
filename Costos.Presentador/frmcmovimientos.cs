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
    public partial class frmcmovimientos : Form,ListaIcMovimientos
    {
        Presentadorlcmovimientos objmodulo = new Presentadorlcmovimientos();
        public frmcmovimientos()
        {
            InitializeComponent();
            objmodulo.add(this);
        }

        public IEnumerable<cmovimientosalmacen> Lcmovimientos
        {
            get { return (IEnumerable<cmovimientosalmacen>)this.cmovimientosalmacenBindingSource.DataSource; }
            set { this.cmovimientosalmacenBindingSource.DataSource = value; }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
