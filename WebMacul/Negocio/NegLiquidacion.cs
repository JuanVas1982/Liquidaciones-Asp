using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using WebMacul.Data;
using WebMacul.Comun;

namespace WebMacul.Negocio
{
    public class NegLiquidacion
    {
        public DataSet ListaLiquidacion(WebMacul.Comun.Liquidacion ObjLiquida)
        {
            DataSet ds = new DataSet();
            WebMacul.Data.DataLiquida ObjLiquidacionData = new WebMacul.Data.DataLiquida();
            ds = ObjLiquidacionData.BuscaLiquida(ObjLiquida);
            return ds;

        }
    }
}