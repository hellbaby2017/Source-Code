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
    public partial class Frmrinventario : Form,iListaInventario
    {
        PresentadorInventario objmodulo = new PresentadorInventario();
        public Frmrinventario()
        {
            InitializeComponent();
            objmodulo.add(this);
        }

        public IEnumerable<mcapas> ListaAlternativa
        {
            get { return (IEnumerable<mcapas>)this.mcapasBindingSource.DataSource; }
            set { this.mcapasBindingSource.DataSource = value; }
        }

        private void Frmrinventario_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
