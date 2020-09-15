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
using System.Data.Objects;

namespace SVP.presentador
{
    public partial class frmmodulo : Form,IListasInterface
    {
        PresentadorListas Objmodulo = new PresentadorListas();
        public IList<Cfg_cModulos> ListaModulo
        {
            get { return (IList<Cfg_cModulos>)this.bindingModulo.DataSource; }
            set { this.bindingModulo.DataSource = value; }
        }
       //public IEnumerable<Cfg_cModulos> ListaModulo2
       // {
       //     get;set;       
       //}

        public frmmodulo()
        {
        
            InitializeComponent();

            Objmodulo.add(this);
     
        }

       
  

       




        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtnombre.ReadOnly = false;
 
        }

        private void btnuevo_Click_1(object sender, EventArgs e)
        {
            
            bindingModulo.AddNew();
            txtnombre.ReadOnly = false;
            txtnomodulo.ReadOnly = false;
        }

        private void btcancelar_Click_1(object sender, EventArgs e)
        {
            Objmodulo.Refrescar();
        }

        private void btguardar_Click_1(object sender, EventArgs e)
        {
            bindingModulo.EndEdit();
            Objmodulo.Guardar(txtnombre.Text,Convert.ToInt32( txtnomodulo.Text));
            txtnombre.ReadOnly = true;
            txtnomodulo.ReadOnly = true;
            MessageBox.Show("Registro Guardado", "Registro");
        }

        private void bteliminar_Click_1(object sender, EventArgs e)
        {
            bindingModulo.EndEdit();
            Objmodulo.Eliminar(Convert.ToInt32(this.txtnomodulo.Text));

        }
    }
}
