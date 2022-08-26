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
using WebMacul;




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
            DataSet ds = new DataSet();
                        
            objUsuarioVar.NomUsuario = Login1.UserName;
            objUsuarioVar.PassWord = Login1.Password;

            ds = objUsuario.ListaUsuario(objUsuarioVar);
          

            if (ds.Tables[0].Rows.Count > 0)
            {
                
                Session["RUT"] = Convert.ToInt32(ds.Tables[0].Rows[0][3].ToString());
                Session["DV"] = ds.Tables[0].Rows[0][5].ToString();
                Session["UserName"] = Login1.UserName;
                Session["Password"] = Login1.Password;
                Session["RETURN"] = ds.Tables[0].Rows[0][7].ToString();
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);

               
            }
         
                   
                
             
            
                        
        }
        
    }
}
