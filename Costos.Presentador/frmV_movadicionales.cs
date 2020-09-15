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
    public partial class frmV_movadicionales : Form, Ivmovadicionalescs
    {
        Presentadorv_madicionalescs objmodulo = new Presentadorv_madicionalescs();
        public frmV_movadicionales()
        {
            InitializeComponent();
            objmodulo.add(this);
        }

        public IEnumerable<V_MOVADICIONALES> ListaAlternativa
        {
            get { return (IEnumerable<V_MOVADICIONALES>)this.v_MOVADICIONALESBindingSource.DataSource; }
            set { this.v_MOVADICIONALESBindingSource.DataSource = value; }
        }
    }
}
