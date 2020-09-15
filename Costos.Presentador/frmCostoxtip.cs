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
    public partial class frmCostoxtip : Form,IListaCostoxtip
    {
        PresentadorCostoxtip objmodulo = new PresentadorCostoxtip();
        public frmCostoxtip()
        {
            InitializeComponent();
            objmodulo.add(this);
        }

        public List<ECOSTOXTIP> ListaCostoxtip
        {
            get { return (List<ECOSTOXTIP>)this.eCOSTOXTIPBindingSource.DataSource; }
            set { this.eCOSTOXTIPBindingSource.DataSource = value; }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtainicio.Text) == false && string.IsNullOrEmpty(dtafinal.Text) == false)
            {
                objmodulo.cargarxtipo(dtainicio.Text, dtafinal.Text);
            }
        }
    }
}
