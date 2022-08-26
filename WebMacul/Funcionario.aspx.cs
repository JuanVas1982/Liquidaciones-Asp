using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using WebMacul.Comun;
using WebMacul.Account;
using WebMacul.Negocio;
using System.Data;

namespace WebMacul
{
    public partial class Funcionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            WebMacul.Comun.Funcionario ObjFuncionarioVar = new WebMacul.Comun.Funcionario();
            WebMacul.Negocio.NegFuncionario ObjFuncionario = new WebMacul.Negocio.NegFuncionario();
            DataSet ds = new DataSet();

            ObjFuncionarioVar.RUtFunci = Convert.ToInt32(Session["RUT"]);
            ObjFuncionarioVar.DvFunci = Convert.ToInt32(Session["DV"]);
            ds = ObjFuncionario.ListarFuncionario(ObjFuncionarioVar);
                

            if (ds.Tables[0].Rows.Count > 0)
            {

                TxtNum.Text = ds.Tables[0].Rows[0][0].ToString();
                TxtNom.Text = ds.Tables[0].Rows[0][1].ToString();
                TxtFnac.Text = ds.Tables[0].Rows[0][2].ToString();
                TxtEst.Text = ds.Tables[0].Rows[0][3].ToString();
                TxtCcos.Text =ds.Tables[0].Rows[0][4].ToString();

                var cali = ds.Tables[0].Rows[0][5].ToString();
                if (cali == "1")
                {
                    TxtCjur.Text = "PLANTA";
                }
                else
                {
                    TxtCjur.Text = "CONTRATA";
                }
               
                TxtCom.Text = ds.Tables[0].Rows[0][6].ToString();
                TxtGra.Text = ds.Tables[0].Rows[0][7].ToString();
                          


            }
        
        }

        protected void TxtNum_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TxtFnac_TextChanged(object sender, EventArgs e)
        {

        }

    } 
}