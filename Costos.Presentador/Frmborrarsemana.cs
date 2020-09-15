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
    public partial class Frmborrarsemana : Form, IlistaCalendario
    {
        Presentadoreliminarsemana objmodulo = new Presentadoreliminarsemana();
        FuncionesCRUD regmodulo = new FuncionesCRUD();
        public Frmborrarsemana()
        {
            InitializeComponent();
            objmodulo.add(this);
        }

        public IEnumerable<Mvi_cCalendario> ListaCalendario
        {
            get { return (IEnumerable<Mvi_cCalendario>)this.mvicCalendarioBindingSource.DataSource; }
            set { this.mvicCalendarioBindingSource.DataSource = value; }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbcalendario.EditValue.ToString()) ==false)
            {
                objmodulo.eliminarsemana(Convert.ToInt32(cmbcalendario.EditValue.ToString()));
                regmodulo.Registrarlog("BorrarSemana", cmbcalendario.Text, "Se borro la semana", lblusuario.Text);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
