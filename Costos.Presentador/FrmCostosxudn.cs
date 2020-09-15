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
    public partial class FrmCostosxudn : Form,IListCostosxudn
    {
        Presentadorecostoxudn objmodulo = new Presentadorecostoxudn();
        public FrmCostosxudn()
        {
            InitializeComponent();
            objmodulo.add(this);
        }

        public List<ECOSTOXUDN> Lista
        {
            get { return (List<ECOSTOXUDN>)this.eCOSTOXUDNBindingSource.DataSource; }
            set { this.eCOSTOXUDNBindingSource.DataSource = value; }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            objmodulo.cargarlista(Convert.ToInt16(txtmes.Text), Convert.ToInt32(txtaño.Text));
            Cursor.Current = Cursors.Default;
        }
    }
}
