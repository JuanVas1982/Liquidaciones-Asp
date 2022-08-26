using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Common;
using System.Web.Security;
using WebMacul.Comun;
using WebMacul.Negocio;
using WebMacul.Account;




namespace WebMacul.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

       

        protected void Login_Authenticate(object sender, AuthenticateEventArgs e)
        {
            
            Login1.RememberMeSet = false;
            Usuario objUsuarioVar = new Usuario();
            NegUsuario objUsuario = new NegUsuario();
            Seguridad Objseguridad = new Seguridad();
            DataSet ds = new DataSet();
                    
            objUsuarioVar.NomUsuario = Login1.UserName;
            objUsuarioVar.PassWord = Objseguridad.Encripta(Login1.Password);
          
            ds = objUsuario.ListaUsuario(objUsuarioVar);


            if (ds.Tables[0].Rows.Count > 0)
            {
               
                Session["RUT"] = Convert.ToInt32(ds.Tables[0].Rows[0][3].ToString());
                Session["DV"] = ds.Tables[0].Rows[0][4].ToString();
                Session["UserName"] = Login1.UserName;
                Login1.UserName = ds.Tables[0].Rows[0][5].ToString();
                Session["ano"] = Convert.ToInt32(ds.Tables[0].Rows[0][12].ToString());
                Session["mes"] = Convert.ToInt32(ds.Tables[0].Rows[0][13].ToString());
                Session["RETURN"] = ds.Tables[0].Rows[0][10].ToString();
                objUsuarioVar.EstadoE = ds.Tables[0].Rows[0][11].ToString();
                Session["CCOSTO"] = ds.Tables[0].Rows[0][7].ToString();
                Session["PERFIL"] = ds.Tables[0].Rows[0][10].ToString();
                Session["Password"] = Login1.Password;
                Session["Tipo"] = 1;
               

                if (objUsuarioVar.EstadoE == "S")
                {
                    FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);
                    Response.Redirect("~/Menu.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "Acceso Sistema", "AlertaUsuarioerror();", true);
                    Login1.UserName = (Session["UserName"]).ToString();

                }
               

            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "Acceso Sistema", "AlertaUsuarioerror2();", true);
                /*Response.Redirect("~/Account/Login.aspx");*/
            }

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {

        }

     

       
             
            
                        
       
        
    }
}
