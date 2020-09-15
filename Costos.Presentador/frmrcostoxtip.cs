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
    public partial class frmrcostoxtip : Form,IListaCostoxtip
    {
        PresentadorCostoxtip objmodulo = new PresentadorCostoxtip();
        public frmrcostoxtip()
        {
            InitializeComponent();
            objmodulo.add(this);
        }

        public List<ECOSTOXTIP> ListaCostoxtip
        {
            get { return (List<ECOSTOXTIP>)this.ECOSTOXTIPBindingSource.DataSource; }
            set { this.ECOSTOXTIPBindingSource.DataSource = value; }
        }

        private void frmrcostoxtip_Load(object sender, EventArgs e)
        {

           
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {


            objmodulo.cargarxtipo(dtainicio.Text, dtafinal.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
