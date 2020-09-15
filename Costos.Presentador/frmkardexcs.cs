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
    public partial class frmkardexcs : Form, IListaKardex
    {
        PresentadorKardex Objmodulo = new PresentadorKardex();
        public IEnumerable<Mvi_cAlternativas> ListaAlternativa
        {
            get { return (IEnumerable<Mvi_cAlternativas>)this.mvi_cAlternativasBindingSource.DataSource; }
            set { this.mvi_cAlternativasBindingSource.DataSource = value; }
        }

        public List<EKARDEX> ListaKardex
        {
               
                get { return (List<EKARDEX>)this.EKARDEXBindingSource.DataSource; }
                set { this.EKARDEXBindingSource.DataSource = value; }
            }

        public frmkardexcs()
        {
            InitializeComponent();
            Objmodulo.add(this);
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmkardexcs_Load(object sender, EventArgs e)
        {

            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtainicio.Text) == false && string.IsNullOrEmpty(dtafinal.Text) == false && string.IsNullOrEmpty(gralternativa.Text) == false)
            {
                Cursor.Current = Cursors.WaitCursor;
                Objmodulo.CargarKardex(dtainicio.Text, dtafinal.Text, gralternativa.Text);
                Cursor.Current = Cursors.Default;
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
