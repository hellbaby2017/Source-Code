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
    public partial class frmcostoxalt : Form,IlistaCostoxalt
    {
        PresentadorCostoxalt objmodulo = new PresentadorCostoxalt();
        public frmcostoxalt()
        {
            InitializeComponent();
            objmodulo.add(this);
        }



        List<ECOSTOXALT> IlistaCostoxalt.ListaCostoxalt
        {
            get { return (List<ECOSTOXALT>)this.costoxAltTBindingSource.DataSource; }
            set { this.costoxAltTBindingSource.DataSource = value; }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtainicio.Text) == false && string.IsNullOrEmpty(dtafinal.Text) == false)
            {
                Cursor.Current = Cursors.WaitCursor;
                objmodulo.cargarxalt(dtainicio.Text, dtafinal.Text);
                Cursor.Current = Cursors.Default;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
