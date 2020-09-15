using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costos.Entidades;
namespace Costos.presentador
{
    public interface IListaKardex
    {
        IEnumerable<Mvi_cAlternativas> ListaAlternativa { get; set; }
        List<EKARDEX> ListaKardex { get; set; }
    }
}
