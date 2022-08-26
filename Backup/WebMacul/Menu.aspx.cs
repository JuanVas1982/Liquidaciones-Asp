using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMacul.Data;
using WebMacul.Comun;
using WebMacul.Negocio;
using System.Web.Security;

namespace WebMacul
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string sw = Session["RETURN"].ToString();
            if (sw == "1")
            {
                BtnAuto.Visible = false;
            }
            else
            {
                BtnAuto.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Liquidaciones.aspx", true);
        }

        protected void BtnAuto_Click(object sender, EventArgs e)
        {
           
                Response.Redirect("~/Autorizacion.aspx", true);
          
        }

        protected void BtnClave_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Account/Cambioclave.aspx", true);
        }
        
    }
}