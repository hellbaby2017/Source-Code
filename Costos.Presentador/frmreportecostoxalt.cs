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
    public partial class frmreportecostoxalt : Form,IlistaCostoxalt
    {PresentadorCostoxalt objmodulo=new  PresentadorCostoxalt();
        public frmreportecostoxalt()
        {
            InitializeComponent();
            objmodulo.add(this);
        }



        List<ECOSTOXALT> IlistaCostoxalt.ListaCostoxalt
        {
            get { return (List<ECOSTOXALT>)this.CostoxAltTBindingSource.DataSource; }
            set { this.CostoxAltTBindingSource.DataSource = value; }
        }

        private void frmreportecostoxalt_Load(object sender, EventArgs e)
        {

      
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            objmodulo.cargarxalt(dtainicio.Text,dtafinal.Text);
            this.reportViewer1.RefreshReport();
            Cursor.Current = Cursors.Default;
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
