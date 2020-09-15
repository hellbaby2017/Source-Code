using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVP.Entidades;

namespace SVP.presentador
{
    public partial class FrmTipodUsuario : Form,IlistatipoUsuario
    {
        PresentadorTipoUsuario Objtusuario = new PresentadorTipoUsuario();
        public FrmTipodUsuario()
        {
            InitializeComponent();
            Objtusuario.add(this);
         }

        public IEnumerable<Cfg_cModulos> ListaModulo
        {
            get { return (IEnumerable<Cfg_cModulos>)this.cfg_cModulosBindingSource.DataSource; }
            set { this.cfg_cModulosBindingSource.DataSource = value; }
        }


        public IEnumerable<Cfg_Programa> ListaPrograma
        {
            get { return (IEnumerable<Cfg_Programa>)this.cfg_ProgramaBindingSource.DataSource; }
            set { this.cfg_ProgramaBindingSource.DataSource = value; }
        }

        public IEnumerable<Cfg_AtiposUsuarios> ListaTusuario
        {
            get { return (IEnumerable<Cfg_AtiposUsuarios>)this.cfg_AtiposUsuariosBindingSource.DataSource; }
            set { this.cfg_AtiposUsuariosBindingSource.DataSource = value; }
        }

      
        private void btnuevo_Click(object sender, EventArgs e)
        {
            cfg_AtiposUsuariosBindingSource.AddNew();
            txtnombre.ReadOnly = false;
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            Objtusuario.GuardarTP(this.txtnombre.Text,Convert.ToInt32(this.txtno.Text));
            txtnombre.ReadOnly = true;
            txtno.ReadOnly = true;
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            Objtusuario.EliminarTP(Convert.ToInt32(this.txtno.Text));
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtno.Text) == 0)
            {

                MessageBox.Show("Guarde el tipo de usuario antes de asignarle Modulos", "Guardar");
            }
            else
            {
                Objtusuario.GuardarMU(Convert.ToInt32(txtno.Text), Convert.ToInt32(txtnomodulo.Text), Convert.ToInt32(comboBox1.SelectedValue), txtnombre.Text);
                comboBox1.Enabled = false;
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            cfg_cModuloxUsuarioBindingSource.AddNew();
            comboBox1.Enabled = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Objtusuario.EliminarMT(Convert.ToInt32(this.txtnomodulo.Text));
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            Objtusuario.Refrescar();
        }


        private void simpleButton10_Click_1(object sender, EventArgs e)
        {
            cfg_cProgramaxTipoUsuarioBindingSource.AddNew();
            comboBox2.Enabled = true;
        
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.comboBox1.Enabled = true;

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;

        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txtno.Text) == 0)
            {

                MessageBox.Show("Guarde el tipo de usuario antes de asignarle Programas", "Guardar");
            }
            else
            {
                Objtusuario.GuardarPU(Convert.ToInt32(txtno.Text), Convert.ToInt32(txtnoprograma.Text), Convert.ToInt32(comboBox2.SelectedValue), txtnombre.Text);
                comboBox2.Enabled = true;
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtnombre.ReadOnly = false;
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            Objtusuario.Refrescar();
            txtnombre.ReadOnly = true;
        }
    }
}
