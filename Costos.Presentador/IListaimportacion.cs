using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costos.Entidades;
namespace Costos.presentador
{
    public interface IListaimportacion
    {
        IEnumerable<ECALENDARIO> ListaCalendario { get; set; }
        List<EACMOVEXPORTAR> Listaimportar { get; set; }
        string cantidad { get; set; }
        string total { get; set; }
        IEnumerable<amovimientos> Listaresultado { get; set; }
    }
}
