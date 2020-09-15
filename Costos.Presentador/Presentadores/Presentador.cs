using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Costos.presentador
{
    public abstract class Presentador
    {
        /// <remarks>Indica la validación de Exportar</remarks>
        public abstract string UltimoMensaje { get; }
        protected abstract void ActualizarVista();
        protected void New()
        {
           
        }

    }
}