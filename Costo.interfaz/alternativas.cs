using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Costos.Entidades;
namespace Costo.interfaz
{
    public class alternativas
    {
        
        public static void Cargar()
        {
            Mvi_cAlternativas EntidadAlternativas;
            EntidadAlternativas = new Mvi_cAlternativas();
        }
    }
}
