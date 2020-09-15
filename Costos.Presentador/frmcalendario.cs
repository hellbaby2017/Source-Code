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

    public partial class frmcalendario : Form,IlistaCalendario
    {
        PresentadorCalendario Objmodulo = new PresentadorCalendario();
        public frmcalendario()
        {
            InitializeComponent();
            Objmodulo.add(this);
            
        }

        public IEnumerable<Mvi_cCalendario> ListaCalendario
        {
            get { return (IEnumerable<Mvi_cCalendario>)this.mvi_cCalendarioBindingSource.DataSource; }
            set { this.mvi_cCalendarioBindingSource.DataSource = value; }
        }
    }
}
