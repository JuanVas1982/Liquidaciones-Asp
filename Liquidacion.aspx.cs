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
using WebMacul;
using System.Data;
using WebMacul.Negocio;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;



namespace WebMacul
{
    public partial class Liquidacion : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            

        }
     

        protected void Button1_Click(object sender, EventArgs e)
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
            WebMacul.Negocio.NegLiquidacion ObjExistenciasProductosNC = new WebMacul.Negocio.NegLiquidacion();
            WebMacul.Comun.Liquidacion objExistenciasProductos = new WebMacul.Comun.Liquidacion();

            DataSet ds = new DataSet();
            //Rows.Count > 0
            // if (ds.Tables[0].Rows.Count > 1)
            //  Label1.Text = ds.Tables[0].Rows[0][1].ToString();
            objExistenciasProductos.Tipo = 1;
            objExistenciasProductos.Ano = Convert.ToInt32(Txt_ano.Text);
            objExistenciasProductos.Mes = Convert.ToInt32(Txt_mes.Text);
            objExistenciasProductos.Rut = Convert.ToInt32(Session["RUT"]);
            objExistenciasProductos.Dv = Convert.ToString(Session["DV"]);
          
            ds = ObjExistenciasProductosNC.ListaLiquidacion(objExistenciasProductos);
            // dataset.Tables[nom_tabla] == nulL
            if (ds.Tables[0].Rows.Count > 0)
            {

                try

                {
                                   

                    ReportDocument crv = new ReportDocument();
                    ParameterField fcr = new ParameterField();
                    ParameterField fcr1 = new ParameterField();
                    ParameterField fcr2 = new ParameterField();
                    ParameterField fcr3 = new ParameterField();
                    ParameterField fcr4 = new ParameterField();
                    ParameterField fcr5 = new ParameterField();
                    ParameterFields fcvs = new ParameterFields();
                    ParameterDiscreteValue pdf = new ParameterDiscreteValue();
                    ParameterDiscreteValue pdf1 = new ParameterDiscreteValue();
                    ParameterDiscreteValue pdf2 = new ParameterDiscreteValue();
                    ParameterDiscreteValue pdf3 = new ParameterDiscreteValue();
                    ParameterDiscreteValue pdf4 = new ParameterDiscreteValue();
                    ParameterDiscreteValue pdf5 = new ParameterDiscreteValue();
                    

                    Usuario objUsuarioVar = new Usuario();


                    fcr.Name = "@Tipo_liq";
                    fcr1.Name = "@Ano_liq";
                    fcr2.Name = "@Mes_liq";
                    fcr3.Name = "@Rut_liq";
                    fcr4.Name = "@Dv_liq";
                    fcr5.Name = "Usuario";

                    pdf.Value = 1;
                    pdf1.Value = Txt_ano.Text;
                    pdf2.Value = Txt_mes.Text;
                    pdf3.Value = Session["RUT"];
                    pdf4.Value = Session["DV"];
                    pdf5.Value = Session["UserName"];

                    fcr.CurrentValues.Add(pdf);
                    fcr1.CurrentValues.Add(pdf1);
                    fcr2.CurrentValues.Add(pdf2);
                    fcr3.CurrentValues.Add(pdf3);
                    fcr4.CurrentValues.Add(pdf4);
                    fcr5.CurrentValues.Add(pdf5);

                    fcvs.Add(fcr);
                    fcvs.Add(fcr1);
                    fcvs.Add(fcr2);
                    fcvs.Add(fcr3);
                    fcvs.Add(fcr4);
                    fcvs.Add(fcr5);
                  


                    CrystalReportViewer1.ParameterFieldInfo = fcvs;

                                 
                                                      
                  
                  
                    CrystalReportViewer1.Visible = true;
                }
                catch (Exception ex)
                {
                    CrystalReportViewer1.Visible = false;
                }
            }

            else
            {
                MessageBox.Show("FUNCIONARIO SIN LIQUIDACION EN EL PERIODO");
            }
        }


        protected void CrystalReportViewer1_Init(object sender, EventArgs e)
        {

        }

        protected void CrystalReportViewer1_Init1(object sender, EventArgs e)
        {

        }

        protected void Txt_ano_TextChanged(object sender, EventArgs e)
        {
            CmbListMes.Focus();
        }

        protected void CmbListMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button1.Focus();
        }

       
      
    }
}