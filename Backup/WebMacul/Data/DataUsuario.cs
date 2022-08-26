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
    public class DataUsuario
    {
        public DataSet  BuscaUsuario(Usuario ObjBuscaUsuario)
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
                cmd.CommandText = "select_all_usuario";
                cmd.Parameters.Add("@usuario1", SqlDbType.VarChar, 20).Value = ObjBuscaUsuario.NomUsuario;
                cmd.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = ObjBuscaUsuario.PassWord;
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
       public Boolean  CambioClave(Usuario ObjBuscaUsuario)
        {
            Boolean exito = false;
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            try
            {
                cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "cambio_clave";
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 20).Value = ObjBuscaUsuario.NomUsuario;
                cmd.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = ObjBuscaUsuario.PassWord;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();// sda.Fill(ds);

                cmd.Connection.Close();
                exito = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepcion Capturada:{0}", ex.Message.ToString());
                exito = false;
            }
            return exito;
        }

       public Boolean Graba_Log_usuario(Usuario ObjBuscaUsuario)
       {
           Boolean exito = false;
           SqlCommand cmd = new SqlCommand();
           SqlDataAdapter sda = new SqlDataAdapter(cmd);
           try
           {
               cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "Graba_Log_usuario";
               cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 20).Value = ObjBuscaUsuario.NomUsuario;
               cmd.Parameters.Add("@Rut", SqlDbType.VarChar,10).Value = ObjBuscaUsuario.Rut +"-"+ ObjBuscaUsuario.DV;
               cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255).Value = ObjBuscaUsuario.EstadoE;
               cmd.Parameters.Add("@Modulo", SqlDbType.VarChar, 25).Value = "Cambio de Contraseña";
               cmd.Connection.Open();
               cmd.ExecuteNonQuery();// sda.Fill(ds);

               cmd.Connection.Close();
               exito = true;
           }
           catch (Exception ex)
           {
               Console.WriteLine("Excepcion Capturada:{0}", ex.Message.ToString());
               exito = false;
           }
           return exito;
       }
       public Boolean Registra_usuario(Usuario ObjBuscaUsuario)
       {
           Boolean exito = false;
           SqlCommand cmd = new SqlCommand();
           SqlDataAdapter sda = new SqlDataAdapter(cmd);
           try
           {
               cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "Registra_usuario";
               cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 15).Value = ObjBuscaUsuario.NomUsuario;
               cmd.Parameters.Add("@Rut", SqlDbType.Int, 10).Value = ObjBuscaUsuario.Rut;
               cmd.Parameters.Add("@Dv", SqlDbType.VarChar, 1).Value = ObjBuscaUsuario.DV;
               cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 40).Value = ObjBuscaUsuario.Nombre;
               cmd.Parameters.Add("@Cargo", SqlDbType.VarChar, 40).Value = ObjBuscaUsuario.Cargo;
               cmd.Parameters.Add("@Ccosto", SqlDbType.VarChar, 40).Value = ObjBuscaUsuario.Ccosto;
               cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = ObjBuscaUsuario.PassWord;
               cmd.Connection.Open();
               cmd.ExecuteNonQuery(); //sda.Fill(ds);

               cmd.Connection.Close();
               exito = true;
           }
           catch (Exception ex)
           {
               Console.WriteLine("Excepcion Capturada:{0}", ex.Message.ToString());
               exito = false;
           }
           return exito;
       }
       public Boolean Estado_usuario(Usuario ObjBuscaUsuario)
       {
           Boolean exito = false;
           SqlCommand cmd = new SqlCommand();
           SqlDataAdapter sda = new SqlDataAdapter(cmd);
           try
           {
               cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "Estado_usuario";
               cmd.Parameters.Add("@Rut", SqlDbType.Int, 10).Value = ObjBuscaUsuario.Rut;
               cmd.Parameters.Add("@Vigencia", SqlDbType.VarChar, 10).Value = ObjBuscaUsuario.EstadoE;
               cmd.Connection.Open();
               cmd.ExecuteNonQuery();// sda.Fill(ds);

               cmd.Connection.Close();
               exito = true;
           }
           catch (Exception ex)
           {
               Console.WriteLine("Excepcion Capturada:{0}", ex.Message.ToString());
               exito = false;
           }
           return exito;
       }
       public DataSet Existencia_usuario(Usuario ObjBuscaUsuario)
       {
           
           SqlCommand cmd = new SqlCommand();
           SqlDataAdapter sda = new SqlDataAdapter(cmd);
           DataSet ds = new DataSet();
           try
           {
               cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "Existencia_usuario";
               cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 15).Value = ObjBuscaUsuario.Email;
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
       public DataSet BuscaRespon(Usuario ObjBuscaUsuario)
       {
           // SqlConnection Conn = new SqlConnection();
           SqlCommand cmd = new SqlCommand();
           DataSet ds = new DataSet();
           SqlDataAdapter sda = new SqlDataAdapter(cmd);
           try
           {
               string CCOSTO = ObjBuscaUsuario.Ccosto.ToString();
               cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
               cmd.CommandText = "SELECT RESP_CC FROM  EMAIL_RESPONSABLE WHERE (DES_CC = '"+ CCOSTO +"')";
               cmd.CommandType = CommandType.Text;
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