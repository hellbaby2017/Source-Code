using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costo.report
{
    public partial class frmrkardexcs : Form
    {
        Costos.Entidades.adminpaqEntities entidades;
        Costos.Entidades.MVI_IPEntities entidadmvi;
        public frmrkardexcs()
        {
            entidadmvi = new Costos.Entidades.MVI_IPEntities();
            InitializeComponent();
            var q =
              from p in entidadmvi.Mvi_cAlternativas
              orderby p.cAltClave
              select new { p.cAltClave };
            mvi_cAlternativasBindingSource.DataSource = q.ToList();

        }

        private void frmrkardexcs_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DateTime inicio = Convert.ToDateTime(dtainicio.Text);
            DateTime fin = Convert.ToDateTime(dtafinal.Text);
            string alternativa = gridLookUpEdit1.Text;
            entidades = new Costos.Entidades.adminpaqEntities();
            var q = entidades.KARDEX(inicio, fin, alternativa);
            KARDEX_ResultBindingSource.DataSource = q.ToList();
            Cursor.Current = Cursors.Default;
            this.reportViewer1.RefreshReport();
        }
    }
}
