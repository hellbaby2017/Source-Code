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
    public partial class frmKardexi : Form,IListaKardex
    {
        PresentadorKardex Objmodulo = new PresentadorKardex();
        public frmKardexi()
        {
            InitializeComponent();
            Objmodulo.add(this);
        }

        public IEnumerable<Mvi_cAlternativas> ListaAlternativa
        {
            get { return (IEnumerable<Mvi_cAlternativas>)this.mvi_cAlternativasBindingSource.DataSource; }
            set { this.mvi_cAlternativasBindingSource.DataSource = value; }
        }



        List<EKARDEX> IListaKardex.ListaKardex
        {
            get { return (List<EKARDEX>)this.kARDEX_ResultBindingSource.DataSource; }
            set { this.kARDEX_ResultBindingSource.DataSource = value; }
        }

        private void PAN1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtainicio.Text) == false && string.IsNullOrEmpty(dtafinal.Text) == false && string.IsNullOrEmpty(gralternativa.Text) == false)
            {
                Cursor.Current = Cursors.WaitCursor;
                Objmodulo.CargarKardex(dtainicio.Text, dtafinal.Text, gralternativa.Text);
                Cursor.Current = Cursors.Default;
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Exportar.exportarexcel(this.gridControl1);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Exportar.exportarpdf(this.gridControl1);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Exportar.exportarhtml(this.gridControl1);
        }
    }
}
