using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Costos.Entidades
{
    public class CENTIDADcs
    {
    }
    public class cmovrep : IEnumerable<cmovrepL>
    {
        public List<cmovrepL> cmovrepList { get; set; }

        public IEnumerator<cmovrepL> GetEnumerator()
        {
            return cmovrepList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return cmovrepList.GetEnumerator();
        }
        public Byte CMoAClave { get; set; }
        public string cPrvClaveFab { get; set; }
        public string mMSIRemision { get; set; }
        public string mMSIFactura { get; set; }
        public string mMSILote { get; set; }
        public Int32 cCalClave { get; set; }
        public DateTime mMSIFecha { get; set; }
        public DateTime mMSIFechaFactura { get; set; }
        public string mMSIPedimento { get; set; }
        public Int64 Unidades { get; set; }
        public decimal Costo { get; set; }
        public Int32 mMSIFolio { get; set; }
        public decimal CostoP { get; set; }
        public string Detalle { get; set; }
        public string cAltClave { get; set; }
        public string cAlmClave { get; set; }
        public Boolean cMoATipoMovto { get; set; }
        public Int32 cCalAnio { get; set; }
        public Int32 cCalNoSemana { get; set; }

        public Boolean cMoAIntegrado { get; set; }

    }

    public class cmovrepL
    {
        public Byte CMoAClave { get; set; }
        public string cPrvClaveFab { get; set; }
        public string mMSIRemision { get; set; }
        public string mMSIFactura { get; set; }
        public string mMSILote { get; set; }
        public Int32 cCalClave { get; set; }
        public DateTime mMSIFecha { get; set; }
        public DateTime mMSIFechaFactura { get; set; }
        public string mMSIPedimento { get; set; }
        public Int64 Unidades { get; set; }
        public decimal Costo { get; set; }
        public Int32 mMSIFolio { get; set; }
        public decimal CostoP { get; set; }
        public string Detalle { get; set; }
        public string cAltClave { get; set; }
        public string cAlmClave { get; set; }
        public Boolean cMoATipoMovto { get; set; }
        public Int32 cCalAnio { get; set; }
        public Int32 cCalNoSemana { get; set; }

        public Boolean cMoAIntegrado { get; set; }
    }
    public class EKARDEXL : IEnumerable<LKARDEXL>
    {
        public List<LKARDEXL> LKARDEXList { get; set; }

        public IEnumerator<LKARDEXL> GetEnumerator()
        {
            return LKARDEXList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return LKARDEXList.GetEnumerator();
        }
        public string cAltClave { get; set; }
        public string cMoANombre { get; set; }
        public Int64 Unidades { get; set; }
        public decimal Costo { get; set; }
    }

    public class LKARDEXL
    {
         public string cAltClave { get; set; }
        public string cMoANombre { get; set; }
        public Int64 Unidades { get; set; }
        public decimal Costo { get; set; }
    }
    public class ECALENDARIO : IEnumerable<LCALENDARIO>
    {
        public List<LCALENDARIO> LCALENDARIOList { get; set; }

        public IEnumerator<LCALENDARIO> GetEnumerator()
        {
            return LCALENDARIOList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return LCALENDARIOList.GetEnumerator();
        }
        public Int32 cCalClave { get; set; }
        public string cCalNoSemana { get; set; }
       
    }

    public class LCALENDARIO
    {
        public Int32 cCalClave { get; set; }
        public string cCalNoSemana { get; set; }
    }
    public class ECOSTOXALT : IEnumerable<LCOSTOXALT>
    {
        public List<LCOSTOXALT> ECOSTOXALTLlist { get; set; }

        public IEnumerator<LCOSTOXALT> GetEnumerator()
        {
            return ECOSTOXALTLlist.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ECOSTOXALTLlist.GetEnumerator();
        }
        public string tipo { get; set; }
        public string cAltClave { get; set; }
        public Int64 Unidades { get; set; }
        public decimal Costo { get; set; }
    }

    public class LCOSTOXALT
    {
        public string cAltClave { get; set; }
        public string cMoANombre { get; set; }
        public Int64 Unidades { get; set; }
        public decimal Costo { get; set; }
    }
    public class EKARDEX : IEnumerable<LKARDEX>
    {
        public List<LKARDEX> LKARDEXLlist { get; set; }

        public IEnumerator<LKARDEX> GetEnumerator()
        {
            return LKARDEXLlist.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return LKARDEXLlist.GetEnumerator();
        }
        public Int64 Numero { get; set; }
        public DateTime mMSIFecha { get; set; }
        public string cAltClave { get; set; }
        public byte cMoAclave { get; set; }
        public string cMoANombre { get; set; }
        public Int64 unidades { get; set; }
        public Int64 totalacumulado { get; set; }
        public decimal Costo { get; set; }
        public decimal importe { get; set; }
        public decimal totalimporte { get; set; }


    }

    public class LKARDEX
    {
        public Int64 Numero { get; set; }
        public DateTime mMSIFecha { get; set; }
        public string cAltClave { get; set; }
        public bool cMoAclave { get; set; }
        public string cMoANombre { get; set; }
        public Int64 unidades { get; set; }
        public Int64 totalacumulado { get; set; }
        public decimal Costo { get; set; }
        public decimal importe { get; set; }
        public decimal totalimporte { get; set; }
    }
    public class EACMOVEXPORTAR : IEnumerable<ACMOVEXPORTARL>
    {
        public List<ACMOVEXPORTARL> ACMOVEXPORTARLlist { get; set; }

        public IEnumerator<ACMOVEXPORTARL> GetEnumerator()
        {
            return ACMOVEXPORTARLlist.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ACMOVEXPORTARLlist.GetEnumerator();
        }
        public byte cMoAClave { get; set; }
        public string cMoANombre { get; set; }
        public int unidades { get; set; }
       

    }

    public class ACMOVEXPORTARL
    {
        public byte cMoAClave { get; set; }
        public string cMoANombre { get; set; }
        public int unidades { get; set; }
    }
    public class ECOSTOXTIP : IEnumerable<COSTOXTIPL>
    {
        public List<COSTOXTIPL> COSTOXTIPLlist { get; set; }

        public IEnumerator<COSTOXTIPL> GetEnumerator()
        {
            return COSTOXTIPLlist.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return COSTOXTIPLlist.GetEnumerator();
        }
        public String tipo { get; set; }
        public Int64 unidades { get; set; }
        public decimal  Costo { get; set; }


    }

    public class COSTOXTIPL
    {
        public String tipo { get; set; }
        public Int64 unidades { get; set; }
        public decimal Costo { get; set; }
    }
    public class EMCAPAS : IEnumerable<MCAPASL>
    {
        public List<MCAPASL> MCAPASLlist { get; set; }

        public IEnumerator<MCAPASL> GetEnumerator()
        {
            return MCAPASLlist.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return MCAPASLlist.GetEnumerator();
        }
        public String cAltClave { get; set; }
        public String cTiPNombre { get; set; }
        public Int64 unidades { get; set; }
        public decimal Costo { get; set; }
        public decimal importe { get; set; }


    }

    public class MCAPASL
    {
        public String cAltClave { get; set; }
        public String cTiPNombre { get; set; }
        public Int64 unidades { get; set; }
        public decimal Costo { get; set; }
        public decimal importe { get; set; }
    }

    public class ECOSTOXUDN: IEnumerable<COSTOXUDNL>
    {
        public List<COSTOXUDNL> costoxudnLlist { get; set; }

        public IEnumerator<COSTOXUDNL> GetEnumerator()
        {
            return costoxudnLlist.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return costoxudnLlist.GetEnumerator();
        }
        public Int16 mes { get; set; }
        public Int32 ano { get; set; }
        public Int32 CLAVE { get; set; }
        public string NOMBRE { get; set; }
        public string cTiPNombre { get; set; }
        public Int32 unidades { get; set; }
        public decimal COSTOEST { get; set; }
        public decimal COSTOP { get; set; }
        public decimal AJUSTE { get; set; }


    }

    public class COSTOXUDNL
    {
        public Int16 mes { get; set; }
        public Int32 ano { get; set; }
        public Int32 CLAVE { get; set; }
        public string NOMBRE { get; set; }
        public string cTiPNombre { get; set; }
        public Int32 unidades { get; set; }
        public decimal COSTOEST { get; set; }
        public decimal COSTOP { get; set; }
        public decimal AJUSTE { get; set; }
    }
    public class cMovReproceso2 : IEnumerable<cMovReproceso2L>
    {
        public List<cMovReproceso2L> cMovReproceso2Llist { get; set; }

        public IEnumerator<cMovReproceso2L> GetEnumerator()
        {
            return cMovReproceso2Llist.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return cMovReproceso2Llist.GetEnumerator();
        }
        public Byte CMoAClave { get; set; }
        public string cPrvClaveFab { get; set; }
        public string mMSIRemision { get; set; }
        public string mMSIFactura { get; set; }
        public string mMSILote { get; set; }
        public Int32 cCalClave { get; set; }
        public DateTime? mMSIFecha { get; set; }
        public DateTime? mMSIFechaFactura { get; set; }
        public string mMSIPedimento { get; set; }
        public Int64 Unidades { get; set; }
        public decimal Costo { get; set; }
        public Int64 mMSIFolio { get; set; }
        public decimal CostoP { get; set; }
        public string Detalle { get; set; }
        public string cAltClave { get; set; }
        public string cAlmClave { get; set; }
        public Boolean cMoATipoMovto { get; set; }
        public Int32 cCalAnio { get; set; }
        public Int32 cCalNoSemana { get; set; }
        public Boolean cMoAIntegrado { get; set; }
       
   }

    public class cMovReproceso2L
    {
        public Byte CMoAClave { get; set; }
        public string cPrvClaveFab { get; set; }
        public string mMSIRemision { get; set; }
        public string mMSIFactura { get; set; }
        public string mMSILote { get; set; }
        public Int32 cCalClave { get; set; }
        public DateTime? mMSIFecha { get; set; }
        public DateTime? mMSIFechaFactura { get; set; }
        public string mMSIPedimento { get; set; }
        public Int64 Unidades { get; set; }
        public decimal Costo { get; set; }
        public Int64 mMSIFolio { get; set; }
        public decimal CostoP { get; set; }
        public string Detalle { get; set; }
        public string cAltClave { get; set; }
        public string cAlmClave { get; set; }
        public Boolean cMoATipoMovto { get; set; }
        public Int32 cCalAnio { get; set; }
        public Int32 cCalNoSemana { get; set; }
        public Boolean cMoAIntegrado { get; set; }
    }
    public class cMovReproceso : IEnumerable<cMovReprocesoL>
    {
        public List<cMovReprocesoL> cMovReprocesoLlist { get; set; }

        public IEnumerator<cMovReprocesoL> GetEnumerator()
        {
            return cMovReprocesoLlist.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return cMovReprocesoLlist.GetEnumerator();
        }
        public Byte? CMoAClave { get; set; }
        public string cPrvClaveFab { get; set; }
        public string mMSIRemision { get; set; }
        public string mMSIFactura { get; set; }
        public string mMSILote { get; set; }
        public Int32 cCalClave { get; set; }
        public DateTime? mMSIFecha { get; set; }
        public DateTime? mMSIFechaFactura { get; set; }
        public string mMSIPedimento { get; set; }
        public Int64 Unidades { get; set; }
        public decimal Costo { get; set; }
        public Int64 mMSIFolio { get; set; }
        public decimal CostoP { get; set; }
        public string Detalle { get; set; }
        public string cAltClave { get; set; }
        public string cAlmClave { get; set; }
        public Boolean cMoATipoMovto { get; set; }
        public Int32 cCalAnio { get; set; }
        public Int32 cCalNoSemana { get; set; }
        public Boolean cMoAIntegrado { get; set; }

    }

    public class cMovReprocesoL
    {
        public Byte? CMoAClave { get; set; }
        public string cPrvClaveFab { get; set; }
        public string mMSIRemision { get; set; }
        public string mMSIFactura { get; set; }
        public string mMSILote { get; set; }
        public Int32 cCalClave { get; set; }
        public DateTime? mMSIFecha { get; set; }
        public DateTime? mMSIFechaFactura { get; set; }
        public string mMSIPedimento { get; set; }
        public Int64 Unidades { get; set; }
        public decimal Costo { get; set; }
        public Int64 mMSIFolio { get; set; }
        public decimal CostoP { get; set; }
        public string Detalle { get; set; }
        public string cAltClave { get; set; }
        public string cAlmClave { get; set; }
        public Boolean cMoATipoMovto { get; set; }
        public Int32 cCalAnio { get; set; }
        public Int32 cCalNoSemana { get; set; }
        public Boolean cMoAIntegrado { get; set; }
    }
    public class cMovCalc: IEnumerable<cMovCalcL>
    {
        public List<cMovCalcL> cMovCalcLlist { get; set; }

        public IEnumerator<cMovCalcL> GetEnumerator()
        {
            return cMovCalcLlist.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return cMovCalcLlist.GetEnumerator();
        }
       
        public string semana { get; set; }
     

    }

    public class cMovCalcL
    {
        public string semana { get; set; }
    }
}
