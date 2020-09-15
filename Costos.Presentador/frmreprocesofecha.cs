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
using Costos.Funciones;
using System.Reflection;

namespace Costos.presentador
{
    public partial class frmreprocesofecha : Form
    {

        Presentadorreproxfecha Objmodulo = new Presentadorreproxfecha();

        public frmreprocesofecha()
        {
            InitializeComponent();
        }

    
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Objmodulo.Reproceso(Convert.ToDateTime(datefecha.Text));
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
          

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            Cursor.Current = Cursors.Default;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
