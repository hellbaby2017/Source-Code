using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costos.Entidades;
namespace Costos.presentador
{
    public interface IListaMovimientos
    {
        IEnumerable<Mvi_cCalendario> ListaCalendario { get; set; }
        IEnumerable<Mvi_cAlternativas> ListaAlternativas { get; set; }
        IEnumerable<cmovimientosalmacen> ListaCMovimientos  { get; set; }
        IEnumerable<mmovimientos> ListaMovimientos { get; set; }

    }
}
