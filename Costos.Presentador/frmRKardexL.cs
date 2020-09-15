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
    public partial class frmRKardexL : Form,IListKARDEXL
    {
        PresentadorKardexXL objmodulo = new PresentadorKardexXL();
        public frmRKardexL()
        {
            InitializeComponent();
            objmodulo.add(this);
        }

        public List<EKARDEXL> ListaKardex
        {
            get { return (List<EKARDEXL>)this.KARDEXLTBindingSource.DataSource; }
            set { this.KARDEXLTBindingSource.DataSource = value; }
        }

        //public IEnumerable<KARDEXLT> ListaKardex
        //{
        //    get { return (IEnumerable<KARDEXLT>)this.KARDEXLTBindingSource.DataSource; }
        //    set { this.KARDEXLTBindingSource.DataSource = value; }
        //}

        

        private void frmRKardexL_Load(object sender, EventArgs e)
        {

           
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            objmodulo.cargarkardexl(dtainicio.Text, dtafinal.Text);
            this.reportViewer1.RefreshReport();
            Cursor.Current = Cursors.Default;

        }
    }
}
