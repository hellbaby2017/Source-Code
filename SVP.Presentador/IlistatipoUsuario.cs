using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVP.Entidades;
namespace SVP.presentador
{
    public interface IlistatipoUsuario
    {
            
        //IList<Cfg_cModulos> ListaTusuario { get; set; }
        IEnumerable<Cfg_AtiposUsuarios> ListaTusuario { get; set; }
        IEnumerable<Cfg_cModulos> ListaModulo { get; set; }
        IEnumerable<Cfg_Programa> ListaPrograma { get; set; }



    }
}

