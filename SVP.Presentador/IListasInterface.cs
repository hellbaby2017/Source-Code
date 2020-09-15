using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVP.Entidades;
namespace SVP.presentador
{
    public interface IListasInterface
    {
        IList<Cfg_cModulos> ListaModulo { get; set; }
        //IEnumerable<Cfg_cModulos> ListaModulo { get; set; }
    }
}
