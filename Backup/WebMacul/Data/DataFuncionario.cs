using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using System.Web;
using System.Linq;
using System.Text;
using System.Net;
using WebMacul.Negocio;
using WebMacul.Comun;
using System.Web.Security;

namespace WebMacul.Data
{
    public class DataFuncionario
    {
        public DataSet BuscaFuncionario(WebMacul.Comun.Funcionario ObjBuscaFuncionario)
        {
            // SqlConnection Conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            try
            {
                // ds = null;
                cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "select_funcionario";
                if (ObjBuscaFuncionario.NombreFunci != " ")
                {
                    cmd.Parameters.Add("@Rut", SqlDbType.VarChar, 20).Value = ObjBuscaFuncionario.RUtFunci;
                    cmd.Parameters.Add("@Dv", SqlDbType.VarChar).Value = ObjBuscaFuncionario.DvFunci;
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar, 20).Value = "Test";
                    cmd.Parameters.Add("@Sw", SqlDbType.VarChar).Value = 1;
                }
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