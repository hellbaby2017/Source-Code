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
    public partial class frmcapas1 : Form,iListmcapas1
    {
        Presentadormcapa objmodulo = new Presentadormcapa();
        public frmcapas1()
        {
            InitializeComponent();
            objmodulo.add(this);
        }

        public List<EMCAPAS> ListaKardex
        {
            get { return (List<EMCAPAS>)this.eMCAPASBindingSource.DataSource; }
            set { this.eMCAPASBindingSource.DataSource = value; }
        }
    }
}
