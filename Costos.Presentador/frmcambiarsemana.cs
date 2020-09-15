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
    public partial class frmcambiarsemana : Form,IlistaCalendario
    {
        PresentadorCambiarSemana Objmodulo = new PresentadorCambiarSemana();
        FuncionesCRUD regmodulo = new FuncionesCRUD();
        public frmcambiarsemana()
        {
            InitializeComponent();
            Objmodulo.add(this);
        }

        public IEnumerable<Mvi_cCalendario> ListaCalendario
        {
            get { return (IEnumerable<Mvi_cCalendario>)this.bindingMvi_cCalendario.DataSource; }
            set { this.bindingMvi_cCalendario.DataSource = value; }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.GrOrigensemana.EditValue.ToString()) == false && string.IsNullOrEmpty(this.GrFinalSemana.EditValue.ToString()) == false)
            {
                Objmodulo.csemana(Convert.ToInt32(this.GrOrigensemana.EditValue.ToString()), Convert.ToInt32(this.GrFinalSemana.EditValue.ToString()));
                regmodulo.Registrarlog("CambiarSemana", GrOrigensemana.EditValue.ToString(), "de" + GrOrigensemana.EditValue.ToString()+ " a " + GrFinalSemana.EditValue.ToString(), lblusuario.Text);
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmcambiarsemana_Load(object sender, EventArgs e)
        {

        }
    }
}
