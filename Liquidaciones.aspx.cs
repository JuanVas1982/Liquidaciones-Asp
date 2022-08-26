using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMacul.Account;
using System.Data;
using System.Data.Common;
using System.Web.Security;

namespace WebMacul
{
    public partial class Liquidaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void Txt_ano_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Txt_mes_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CmbListMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CmbListMes.Text)
            {
                case "Enero":
                    Txt_mes.Text = "1";
                    break;
                case "Febrero":
                    Txt_mes.Text = "2";
                    break;
                case "Marzo":
                    Txt_mes.Text = "3";
                    break;
                case "Abril":
                    Txt_mes.Text = "4";
                    break;
                case "Mayo":
                    Txt_mes.Text = "5";
                    break;
                case "Junio":
                    Txt_mes.Text = "6";
                    break;
                case "Julio":
                    Txt_mes.Text = "7";
                    break;
                case "Agosto":
                    Txt_mes.Text = "8";
                    break;
                case "Septiembre":
                    Txt_mes.Text = "9";
                    break;
                case "Octubre":
                    Txt_mes.Text = "10";
                    break;
                case "Noviembre":
                    Txt_mes.Text = "11";
                    break;
                case "Diciembre":
                    Txt_mes.Text = "12";
                    break;

            }
            Session["Tipo"] = 1;
            Session["ano"] = Txt_ano.Text;
            Session["mes"] = Txt_mes.Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ReportViewer1.LocalReport.Refresh();
        }
    }
}