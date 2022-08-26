using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using WebMacul.Data;
using WebMacul.Comun;


namespace WebMacul.Negocio
{
    public class NegUsuario
    {
        public DataSet ListaUsuario(Usuario ObjUsuario)
        {
            DataSet ds = new DataSet();
            DataUsuario ObjUsuarioData = new DataUsuario();
            ds = ObjUsuarioData.BuscaUsuario(ObjUsuario);
            return ds;
            
        }
        public Boolean ActualizaClaveUsuario(Usuario ObjUsuario)
        {
            Boolean result; 
            DataUsuario ObjUsuarioData = new DataUsuario();
            result = ObjUsuarioData.CambioClave(ObjUsuario);
            return result;
            
        }
        public Boolean RegistraLogUsuario(Usuario ObjUsuario)
        {
            Boolean result;
            DataUsuario ObjUsuarioData = new DataUsuario();
            result = ObjUsuarioData.Graba_Log_usuario(ObjUsuario);
            return result;

        }
        public Boolean RegistraUsuario(Usuario ObjUsuario)
        {
            Boolean result;
            DataUsuario ObjUsuarioData = new DataUsuario();
            result = ObjUsuarioData.Registra_usuario(ObjUsuario);
            return result;

        }
        public Boolean EstadoUsuario(Usuario ObjUsuario)
        {
            Boolean result;
            DataUsuario ObjUsuarioData = new DataUsuario();
            result = ObjUsuarioData.Estado_usuario(ObjUsuario);
            return result;

        }
        public DataSet ExisteUsuario(Usuario ObjUsuario)
        {
            DataSet ds = new DataSet();
            DataUsuario ObjUsuarioData = new DataUsuario();
            ds = ObjUsuarioData.Existencia_usuario(ObjUsuario);
            return ds;

        }
    }
}