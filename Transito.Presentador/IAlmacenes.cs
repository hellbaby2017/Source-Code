﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transito.Entidades;
namespace Transito.Presentador
{
public interface IAlmacenes
    {
        IEnumerable<Svp_cAlmacenes> ListaTusuario { get; set; }
    
    }
}
