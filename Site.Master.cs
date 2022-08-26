using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMacul.Account;
using System.Security;
using WebMacul.Comun;
using WebMacul.Negocio;
using System.Data;
using System.Data.Common;
using System.Web.Security;

namespace WebMacul

{
    
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["RUT"] == null)
            {
                NavigationMenu.Enabled = false;
            }
            else
            {
                NavigationMenu.Enabled = true;
            }
             
        }

        protected void HeadLoginStatus_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Session.RemoveAll();

            
            

                 
        }

        protected void NavigationMenu_MenuItemClick(object sender, MenuEventArgs e)
        {
           

 
        }

        protected void HeadLoginView_ViewChanged(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Write(" <script> javascript: parent.opener =''; " +
                                             " parent.close (); </ script> ");
        }

      
        protected  void Session_End ( Object sender, EventArgs e)
        {
        if (Convert.ToString (Session[ "UserName " ]).Length > 0 )
        {
       // <... Su código para actualizar la base de datos>
        Session ["username"] = null ;
        

        }
    }
    }
}
