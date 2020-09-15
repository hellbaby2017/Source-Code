using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Costos.Reportes
{
    public partial class frmrkardex : Form
    {
        public frmrkardex()
        {
            InitializeComponent();
        }

        private void frmrkardex_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
