using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using WebMacul.Data;
using WebMacul.Comun;

namespace WebMacul.Negocio
{
    public class NegFuncionario
    {
        public DataSet ListarFuncionario(WebMacul.Comun.Funcionario ObjFuncionario)
        {
            DataSet ds = new DataSet();
            WebMacul.Data.DataFuncionario ObjFuncioData = new WebMacul.Data.DataFuncionario();
            ds = ObjFuncioData.BuscaFuncionario(ObjFuncionario);
            return ds;

        }
     
    }
}