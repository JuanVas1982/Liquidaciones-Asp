using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMacul.Comun;
using WebMacul.Account;
using WebMacul;
using System.Data;
using WebMacul.Negocio;
using System.Windows.Forms;
using System.Drawing.Printing;
using Microsoft.Reporting.WebForms;
using System.Reflection;
using System.Runtime.Serialization;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;




namespace WebMacul
{
    public partial class Liquidaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Session["Test"] = "";
            if (Txt_ano.Text == "")
            {
                if (CheckBox1.Checked == true)
                {
                    Session["Tipo"] = 4;
                }
                else
                {
                    Session["Tipo"] = 1;
                }
                Txt_ano.Text = Session["ano"].ToString();
                int Mes = Convert.ToInt32(Session["mes"]) - 1;
                Session["mes"] = Mes;
                Txt_mes.Text = Session["mes"].ToString();


                Busca_Mes();
               /* if (!Page.IsPostBack)
                {
                    //Definimos los parámetros
                    ReportParameter parametro = new ReportParameter();
                    parametro.Name = "Monto";
                    Obtener_Monto();
                    parametro.Values.Add(Session["Test"].ToString());//txtContactID.Text
                    parametro.Visible = false;

                    ReportParameter[] rp = { parametro };
                    //Ahora agregamos el parámetro en al reporte
                    ReportViewer1.LocalReport.SetParameters(rp);
                    ReportViewer1.LocalReport.Refresh();
                }
                */
                ReportViewer1.LocalReport.Refresh();
                Carga_Report();
            }

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
           /* if (!Page.IsPostBack)
            {
                //Definimos los parámetros
                ReportParameter parametro = new ReportParameter();
                parametro.Name = "Monto";
                Obtener_Monto();
                parametro.Values.Add(Session["Test"].ToString());//txtContactID.Text
                parametro.Visible = false;

                ReportParameter[] rp = { parametro };
                //Ahora agregamos el parámetro en al reporte
                ReportViewer1.LocalReport.SetParameters(rp);
                ReportViewer1.LocalReport.Refresh();
            }*/

            ReportViewer1.LocalReport.Refresh();
            Carga_Report();
        }
        public void Carga_Report()
        {
            WebMacul.Negocio.NegLiquidacion ObjExistenciasProductosNC = new WebMacul.Negocio.NegLiquidacion();
            WebMacul.Comun.Liquidacion objExistenciasProductos = new WebMacul.Comun.Liquidacion();

            DataSet ds = new DataSet();
            objExistenciasProductos.Tipo = Convert.ToInt32(Session["Tipo"].ToString());
            objExistenciasProductos.Ano = Convert.ToInt32(Txt_ano.Text);
            objExistenciasProductos.Mes = Convert.ToInt32(Txt_mes.Text);
            objExistenciasProductos.Rut = Convert.ToInt32(Session["RUT"]);
            objExistenciasProductos.Dv = Convert.ToString(Session["DV"]);

            ds = ObjExistenciasProductosNC.ListaLiquidacion(objExistenciasProductos);

            if (ds.Tables[0].Rows.Count > 0)
            {

                try
                {


                    if (CheckBox1.Checked == true)
                    {
                        Session["Tipo"] = 4;
                    }
                    else
                    {
                        Session["Tipo"] = 1;
                    }
                    Session["ano"] = Txt_ano.Text;
                    Session["mes"] = Txt_mes.Text;

                    if (Session["mes"].ToString() == Txt_mes.Text)
                    {
                        //Definimos los parámetros
                        ReportParameter parametro = new ReportParameter();
                        parametro.Name = "Monto";
                        Obtener_Monto();
                        parametro.Values.Add(Session["Test"].ToString());//txtContactID.Text
                        parametro.Visible = false;

                        ReportParameter[] rp = { parametro };
                        //Ahora agregamos el parámetro en al reporte
                        ReportViewer1.LocalReport.SetParameters(rp);
                        ReportViewer1.LocalReport.Refresh();
                    }
                  
                 

                    ReportViewer1.LocalReport.Refresh();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception Message: " + ex.Message);
                  
                }
            }

            else
            {

                if (Convert.ToInt32(Session["Tipo"].ToString()) == 4)
                {
                    ClientScript.RegisterStartupScript(GetType(), "Liquidacion de sueldo", "AlertaLiquidacionHoras();", true);
                    CheckBox1.Checked = false;
                    Session["Tipo"] = 1;
                    Carga_Report();
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "Liquidacion de sueldo", "AlertaLiquidacion();", true);
                    Txt_mes.Text = Session["mes"].ToString();
                    Busca_Mes();
                
                }
               
            }
        }

        protected void RenderReport()
        {
            LocalReport localReport = new LocalReport();
            localReport.ReportPath = Server.MapPath("~/Liquidaciones.rdlc");

            ReportDataSource reportDataSource = new ReportDataSource();
            localReport.DataSources.Add(reportDataSource);

            string reportType = "PDF";
            string mimeType;
            string encoding;
            string fileNameExtension;

            //The DeviceInfo settings should be changed based on the reportType
            //http://msdn2.microsoft.com/en-us/library/ms155397.aspx
            string deviceInfo =
            "<DeviceInfo>" +
            "  <OutputFormat>PDF</OutputFormat>" +
            "  <PageWidth>8.5in</PageWidth>" +
            "  <PageHeight>13in</PageHeight>" +
            "  <MarginTop>0.5in</MarginTop>" +
            "  <MarginLeft>1in</MarginLeft>" +
            "  <MarginRight>1in</MarginRight>" +
            "  <MarginWidth>0.5in</MarginWidth>" +
            "  <MarginBottom>0.5in</MarginBottom>" +
            "</DeviceInfo>";

            Warning[] warnings;
            string[] streams;
            byte[] renderedBytes;

            //Render the report
            renderedBytes = ReportViewer1.LocalReport.Render(
                reportType,
                deviceInfo,
                out mimeType,
                out encoding,
                out fileNameExtension,
                out streams,
                out warnings);

            Response.Clear();
            Response.ContentType = mimeType;
            Response.AddHeader("content-disposition", "attachment; filename=Liquidacion." + fileNameExtension);
            Response.BinaryWrite(renderedBytes);
            Response.End();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            RenderReport();
        }

        protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu.aspx", true);
        }

        private System.Collections.IEnumerable GetData()
        {
            throw new NotImplementedException();
        }
        private void Obtener_Monto()
        {
             WebMacul.Negocio.NegLiquidacion ObjExistenciasProductosNC = new WebMacul.Negocio.NegLiquidacion();
            WebMacul.Comun.Liquidacion objExistenciasProductos = new WebMacul.Comun.Liquidacion();

            DataSet ds = new DataSet();
            objExistenciasProductos.Tipo = Convert.ToInt32(Session["Tipo"].ToString());
            objExistenciasProductos.Ano = Convert.ToInt32(Txt_ano.Text);
            objExistenciasProductos.Mes = Convert.ToInt32(Txt_mes.Text);
            objExistenciasProductos.Rut = Convert.ToInt32(Session["RUT"]);
            objExistenciasProductos.Dv = Convert.ToString(Session["DV"]);

            ds = ObjExistenciasProductosNC.ListaLiquidacion(objExistenciasProductos);

            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["Test"] = "";
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Session["Test"] = ToText(Int32.Parse(dr["LIQU_LIQUIDO_PAGO"].ToString()));
                }
            }

        }
        public static string ToText(int value)
        {
            string Num2Text = "";
            if (value < 0) return "menos " + Math.Abs(value).ToString();

            if (value == 0) Num2Text = "cero";
            else if (value == 1) Num2Text = "uno";
            else if (value == 2) Num2Text = "dos";
            else if (value == 3) Num2Text = "tres";
            else if (value == 4) Num2Text = "cuatro";
            else if (value == 5) Num2Text = "cinco";
            else if (value == 6) Num2Text = "seis";
            else if (value == 7) Num2Text = "siete";
            else if (value == 8) Num2Text = "ocho";
            else if (value == 9) Num2Text = "nueve";
            else if (value == 10) Num2Text = "diez";
            else if (value == 11) Num2Text = "once";
            else if (value == 12) Num2Text = "doce";
            else if (value == 13) Num2Text = "trece";
            else if (value == 14) Num2Text = "catorce";
            else if (value == 15) Num2Text = "quince";
            else if (value < 20) Num2Text = "dieci" + ToText(value - 10).ToString();
            else if (value == 20) Num2Text = "veinte";
            else if (value < 30) Num2Text = "veinti" + ToText(value - 20).ToString();
            else if (value == 30) Num2Text = "treinta";
            else if (value == 40) Num2Text = "cuarenta";
            else if (value == 50) Num2Text = "cincuenta";
            else if (value == 60) Num2Text = "sesenta";
            else if (value == 70) Num2Text = "setenta";
            else if (value == 80) Num2Text = "ochenta";
            else if (value == 90) Num2Text = "noventa";
            else if (value < 100)
            {
                int u = value % 10;
                Num2Text = string.Format("{0} y {1}", ToText((value / 10) * 10).ToString(), (u == 1 ? "un" : ToText(value % 10).ToString()));
            }
            else if (value == 100) Num2Text = "cien";
            else if (value < 200) Num2Text = "ciento " + ToText(value - 100).ToString();
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800))
                Num2Text = ToText((value / 100)).ToString() + "cientos";
            else if (value == 500) Num2Text = "quinientos";
            else if (value == 700) Num2Text = "setecientos";
            else if (value == 900) Num2Text = "novecientos";
            else if (value < 1000) Num2Text = string.Format("{0} {1}", ToText((value / 100) * 100).ToString(), ToText(value % 100).ToString());
            else if (value == 1000) Num2Text = "mil";
            else if (value < 2000) Num2Text = "mil " + ToText(value % 1000).ToString();
            else if (value < 1000000)
            {
                Num2Text = ToText((value / 1000)).ToString() + " mil";
                if ((value % 1000) > 0) Num2Text += " " + ToText(value % 1000).ToString();
            }
            else if (value == 1000000) Num2Text = "un millón";
            else if (value < 2000000) Num2Text = "un millón " + ToText(value % 1000000).ToString();
            else if (value < int.MaxValue)
            {
                Num2Text = ToText((value / 1000000)).ToString() + " millones";
                if ((value - (value / 1000000) * 1000000) > 0) Num2Text += " " + ToText(value - (value / 1000000) * 1000000).ToString();
            }
            return Num2Text.ToUpper();
        }

        protected void ObjectDataSource2_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox1.Checked == true)
            {
                Session["Tipo"] = 4;
                Carga_Report();
            }
            else
            {
                Session["Tipo"] = 1;
                Carga_Report();
            }

        }

        public void Busca_Mes()
        {
            if (Txt_mes.Text != "")
            {
                switch (Txt_mes.Text)
                {
                    case "1":
                        CmbListMes.Text = "Enero";
                        break;
                    case "2":
                        CmbListMes.Text = "Febrero";
                        break;
                    case "3":
                        CmbListMes.Text = "Marzo";
                        break;
                    case "4":
                        CmbListMes.Text = "Abril";
                        break;
                    case "5":
                        CmbListMes.Text = "Mayo";
                        break;
                    case "6":
                        CmbListMes.Text = "Junio";
                        break;
                    case "7":
                        CmbListMes.Text = "Julio";
                        break;
                    case "8":
                        CmbListMes.Text = "Agosto";
                        break;
                    case "9":
                        CmbListMes.Text = "Septiembre";
                        break;
                    case "10":
                        CmbListMes.Text = "Octubre";
                        break;
                    case "11":
                        CmbListMes.Text = "Noviembre";
                        break;
                    case "12":
                        CmbListMes.Text = "Diciembre";
                        break;
                }
            }
        }
       
    }
}

