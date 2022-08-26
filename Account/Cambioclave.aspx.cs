using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using WebMacul.Data;
using WebMacul.Comun;
using WebMacul.Negocio;
using System.Web.Security;

namespace WebMacul.Account
{
    public partial class Cambioclave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

                   
        }

        
        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", true);           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["Password"].ToString() == clave_antes.Text)
            {
                if (clave_nueva.Text == clave_confir.Text)
                {
                    Boolean resultado;
                    Boolean RegLog;

                    WebMacul.Comun.Usuario ObjUsuario = new WebMacul.Comun.Usuario();
                    NegUsuario ObjActualizaUsuario = new NegUsuario();
                                      
                    ObjUsuario.NomUsuario = Session["UserName"].ToString();
                    ObjUsuario.PassWord = clave_nueva.Text;
                    resultado = ObjActualizaUsuario.ActualizaClaveUsuario(ObjUsuario);

                    if (resultado == true)
                    {
                        ObjUsuario.EstadoE = "Cambia clave " + clave_antes.Text + " A Nueva clave " + clave_nueva.Text;
                        ObjUsuario.Rut = Convert.ToInt32((Session["RUT"]));
                        ObjUsuario.DV = Session["DV"].ToString();
                        RegLog = ObjActualizaUsuario.RegistraLogUsuario(ObjUsuario);
                    }
                    Response.Write("<script>window.close('Cambioclave.aspx','popup')</script>");
                    Session.Abandon();
                    Session.Clear();

                    FormsAuthentication.SignOut();
                    Response.Redirect("Login.aspx", true);

                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "Cambio de clave", "AlertaClave();", true);
                   
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "Cambio de clave", "AlertaUsuario();", true);
                
            }


        }

      
       
       
    }  
    
}