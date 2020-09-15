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
using DevExpress.XtraEditors;

namespace SVP.presentador
{
    public partial class frmusuarioi : Form, IListaUsuario
    {
        Presentadorusuario Objpresentador = new Presentadorusuario();
        public IEnumerable<Cfg_AtiposUsuarios> ListaTusuario
        
        {
            get { return (IEnumerable<Cfg_AtiposUsuarios>)this.Cfg_AtiposUsuariosb.DataSource; }
            set { this.Cfg_AtiposUsuariosb.DataSource = value; }
        }

        public IEnumerable<Cfg_cUsuarios> Listausuario
        {
            get { return (IEnumerable<Cfg_cUsuarios>)this.Cfg_cUsuariosB.DataSource; }
            set { this.Cfg_cUsuariosB.DataSource = value; }
        }
        public frmusuarioi()
        {
            InitializeComponent();
            Objpresentador.add(this);
        }

      
      
        public void cambiarestado(bool estado)
        {

                txtnomusuario.Enabled = estado;
                cmbtipousuario.Enabled = estado;
                chkactivo.Enabled = estado;
 
        }



        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Cfg_cUsuariosB.AddNew();
            cambiarestado(true);
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            cambiarestado(true);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            grpcontraseña.Visible = false;
            if (Convert.ToInt32(txtnousuario.Text) == 0)
            {
                Cfg_cUsuariosB.EndEdit();
                Cfg_cUsuariosB.RemoveCurrent();
            }
            Objpresentador.Refrescar();
            cambiarestado(false);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Objpresentador.Eliminar(Convert.ToInt32(txtnousuario.Text));
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            Objpresentador.Guardar(Convert.ToInt32(txtnousuario.Text), txtnomusuario.Text, txtpassword.Text, Convert.ToInt32(cmbtipousuario.SelectedValue), Convert.ToBoolean(chkactivo.CheckState));
            cambiarestado(false);
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            grpcontraseña.Visible=true;
            txtanteriorc.Focus();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncamviar_Click(object sender, EventArgs e)
        {
            if (txtanteriorc.Text==txtpassword.Text)
            {
                Objpresentador.cambiarcontra(Convert.ToInt32(txtnousuario.Text), txtnuevac.Text);
                Objpresentador.Refrescar();
                txtnuevac.Text = "";
                txtanteriorc.Text = "";
                XtraMessageBox.Show("Contraseña cambiada", "Contraseña");
                grpcontraseña.Visible = false;
            }
            else
            {
                XtraMessageBox.Show("La contraseña anterior debe concordar", "Contraseña");
                txtnuevac.Text = "";
                txtanteriorc.Text = "";
                grpcontraseña.Visible = false;
            }
        }
    }
   
   
}
