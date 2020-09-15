using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVP.Entidades;
namespace SVP.presentador
{
    interface IListaUsuario
    {
        IEnumerable<Cfg_cUsuarios> Listausuario { get; set; }
        IEnumerable<Cfg_AtiposUsuarios> ListaTusuario { get; set; }
    }
}
