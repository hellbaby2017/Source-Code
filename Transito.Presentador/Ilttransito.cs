using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transito.Entidades;
namespace Transito.Presentador
{
    public interface Ilttransito
    {
        IEnumerable<Svp_CTransito> ListaTuTransito { get; set; }
        
    }
}
