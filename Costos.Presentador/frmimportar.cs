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
using DevExpress.XtraEditors;

namespace Costos.presentador
{
    public partial class frmimportar : Form ,IListaimportacion
    {
        PresentadorImportacion Objmodulo = new PresentadorImportacion();
        FuncionesCRUD objreg = new FuncionesCRUD();
        public frmimportar()
        {
            InitializeComponent();
            Objmodulo.add(this);
        }

     
        public IEnumerable<ECALENDARIO> ListaCalendario
        {
            get { return (IEnumerable<ECALENDARIO>)this.mvicCalendarioBindingSource.DataSource; }
            set { this.mvicCalendarioBindingSource.DataSource = value; }
        }

      

        public string cantidad
        {
            get
            {
                return label2.Text;
            }

            set
            {
                label2.Text=value;
            }
        }

        public string total
        {
            get
            {
                return label4.Text;
            }

            set
            {
                label4.Text = value;
            }
        }

        public IList<amovimientos> Listaresultado
        {
            get { return (IList<amovimientos>)this.amovimientosBindingSource.DataSource; }
            set { this.amovimientosBindingSource.DataSource = value; }
        }



        IEnumerable<amovimientos> IListaimportacion.Listaresultado
        {
            get { return (IQueryable<amovimientos>)this.amovimientosBindingSource.DataSource; }
            set { this.amovimientosBindingSource.DataSource = value; }
        }

        List<EACMOVEXPORTAR> IListaimportacion.Listaimportar
        {
            get { return (List<EACMOVEXPORTAR>)this.aCmovExportarTBindingSource.DataSource; }
            set { this.aCmovExportarTBindingSource.DataSource = value; }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbnoseamana.Text) == false)
            {
                
                Cursor.Current = Cursors.WaitCursor;
                Objmodulo.CargarInformación(Convert.ToInt32(cmbnoseamana.EditValue.ToString()));
                Cursor.Current = Cursors.Default;
                cmbnoseamana.Enabled = false;
               
                
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int exportar = 1;
            if (Objmodulo.existesemana(Convert.ToInt32(cmbnoseamana.EditValue.ToString())) > 0)
            {
                var respuesta = XtraMessageBox.Show("El calendario ya esta importado ¿lo quiere importar nuevamente? ","Importar Calendario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No)
                {
                    exportar = 0;
                }
            }

            if (exportar == 1)
            {
                if (aCmovExportarTBindingSource.List.Count > 0)
                {
                    timer1.Enabled = true;
                    marqueeProgressBarControl1.Visible = true;
                    if (backgroundWorker1.IsBusy != true)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
            }
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            Objmodulo.ImportarMVI(Convert.ToInt32(cmbnoseamana.EditValue.ToString()));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Objmodulo.llamarconta();
   

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer1.Enabled = false;
            marqueeProgressBarControl1.Visible = false;
            Cursor.Current = Cursors.WaitCursor;
            Objmodulo.listarresultado(Convert.ToInt32(cmbnoseamana.EditValue.ToString()));
            objreg.Registrarlog("Importar", cmbnoseamana.EditValue.ToString(), "Importación Correcta", lblusuario.Text);
            Cursor.Current = Cursors.Default;
            cmbnoseamana.Enabled = true;

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void cmbalternativa_EditValueChanged(object sender, EventArgs e)
        {
          
            this.mvicalendario2.DataSource=Objmodulo.tsemana(Convert.ToInt32(cmbnoseamana.EditValue));
        }
    }
}
