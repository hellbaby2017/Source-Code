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
    public partial class frmkardexL : Form,IListKARDEXL
    {
        PresentadorKardexXL objmodulo = new PresentadorKardexXL();
        public frmkardexL()
        {
            InitializeComponent();
            objmodulo.add(this);
        }

        List<EKARDEXL> IListKARDEXL.ListaKardex
        {
            get { return (List<EKARDEXL>)this.kARDEXLTBindingSource.DataSource; }
            set { this.kARDEXLTBindingSource.DataSource = value; }
        }


        //public List<KARDEXLT> ListaKardex
        //{
        //    get { return (List<KARDEXLT>)this.kARDEXLTBindingSource.DataSource; }
        //    set { this.kARDEXLTBindingSource.DataSource = value; }
        //}

       

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            objmodulo.cargarkardexl(dtainicio.Text, dtafinal.Text);
            Cursor.Current = Cursors.Default;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgguardar = new SaveFileDialog();
            dlgguardar.Filter = "Ficheros Excel (*.xls)|*.xls|Todos (*.*)|*.*";
            dlgguardar.FilterIndex = 1;
            dlgguardar.RestoreDirectory = true;
            if (dlgguardar.ShowDialog() == DialogResult.OK)
                pivotGridControl1.ExportToXlsx(dlgguardar.FileName);
            }
    }
}
