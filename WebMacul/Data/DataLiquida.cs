using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using System.Web;
using System.Linq;
using System.Text;
using WebMacul.Negocio;
using WebMacul.Comun;
using System.Web.UI.WebControls;
using WebMacul.Account;
using WebMacul.Data;

namespace WebMacul.Data
{
    public class DataLiquida
    {
        public DataSet BuscaLiquida(WebMacul.Comun.Liquidacion objliqui)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            try
            {
                cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "select_liquidacion";
                cmd.Parameters.Add("@Tipo_liq", SqlDbType.VarChar, 20).Value = objliqui.Tipo;
                cmd.Parameters.Add("@Ano_liq", SqlDbType.VarChar, 20).Value = objliqui.Ano;
                cmd.Parameters.Add("@Mes_liq", SqlDbType.VarChar).Value = objliqui.Mes;
                cmd.Parameters.Add("@Rut_liq", SqlDbType.VarChar, 20).Value = objliqui.Rut;
                cmd.Parameters.Add("@DV_liq", SqlDbType.VarChar).Value = objliqui.Dv; 
                cmd.Connection.Open();
                cmd.ExecuteNonQuery(); sda.Fill(ds);

                cmd.Connection.Close();
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepcion Capturada:{0}", ex.Message.ToString());
                ds = null;
            }
            return ds;
        }
    }
}