using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMacul.Comun;
using WebMacul.Account;
using WebMacul.Negocio;
using System.Data;
using System.Windows.Forms;
using System.Text;
using System.Security.Cryptography;
using System.IO;


namespace WebMacul
{
    public partial class Registro : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

           
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Account/Login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
         
            if (TxtPass1.Text == TxtPass2.Text)
            {
               
                Boolean resultado;
                WebMacul.Comun.Usuario ObjUsuarioVar = new WebMacul.Comun.Usuario();
                WebMacul.Negocio.NegUsuario ObjUsuario = new WebMacul.Negocio.NegUsuario();
                WebMacul.Account.Seguridad Objseguridad = new Seguridad();
                
                ObjUsuarioVar.NomUsuario = TxtCorreo.Text;
                ObjUsuarioVar.Rut = Int32.Parse(TxtRut.Text);
                ObjUsuarioVar.DV = TxtDv.Text;
                ObjUsuarioVar.Nombre = TxtNom.Text;
                ObjUsuarioVar.Cargo = TxtCargo.Text;
                ObjUsuarioVar.Ccosto = TxtCcos.Text;
                ObjUsuarioVar.PassWord =  Objseguridad.Encripta(TxtPass1.Text);

                resultado = ObjUsuario.RegistraUsuario(ObjUsuarioVar);

                if (resultado == true)
                {
                    EnviarEmail();
                    Limpiar();
                    ClientScript.RegisterStartupScript(GetType(), "Registro de usuario", "AlertaUsuarioexito();", true);
                    Response.Redirect("~/Account/login.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "Registro de usuario", "AlertaUsuarioerror3();", true);
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "Registro de usuario", "AlertaClave();", true);
            }
            
        }
        

        
        public void EnviarEmail()
        {
             WebMacul.Data.DataUsuario resp  = new Data.DataUsuario();
            WebMacul.Comun.Usuario ObjUsuarioVar = new WebMacul.Comun.Usuario();

            DataSet ds = new DataSet();
            string from = "maculditec@gmail.com";
            string pass = "desarrollo2015";
            ObjUsuarioVar.Ccosto = TxtCcos.Text;
            ds = resp.BuscaRespon(ObjUsuarioVar);
            string to = ds.Tables[0].Rows[0][0].ToString();
            string msg = "El Usuario Sr(a)." + TxtNom.Text + " se ha registrado para ver sus liquidaciones de sueldo, se requiere de su autorizacion para que el nuevo usuario pueda accesar al portal Web.  http://172.16.0.13:8082/Account/Login.aspx";

            new Enviocorreo().Enviarcorreo(from,pass,to,msg);

        
        }
        
        public void Limpiar()
        {
            TxtNom.Text = "";
            TxtCorreo.Text = "";
            TxtRut.Text = "";
            TxtDv.Text = "";
            TxtNom.Text = "";
            TxtCargo.Text = "";
            TxtCcos.Text = "";
            TxtPass1.Text = "";
            TxtPass2.Text = "";
        }

        protected void TxtNum_TextChanged(object sender, EventArgs e)
        {
            Validar_usuario();
        }

        public void Valida_Rut(Int32 Rut)
        {
            int Digito;
            int Contador;
            int Múltiplo;
            int Acumulador;
            string RutDigito; /*cadena*/

            Contador = 2;
            Acumulador = 0;

            while (Rut != 0)
            {
                Múltiplo = (Rut % 10) * Contador;
                Acumulador = Acumulador + Múltiplo;
                Rut = Rut / 10;
                Contador = Contador + 1;
                if (Contador == 8)
                {
                    Contador = 2;
                }

            }

            Digito = 11 - (Acumulador % 11);
            RutDigito = TxtDv.Text;
            if (Digito == 10)
            {
                RutDigito = "10";
            }
            if (Digito == 11)
            {
                RutDigito = "0";
            }
            if (Digito == Int32.Parse(RutDigito))
            {
                TxtCargo.Focus();
            }
            else
            {
                TxtRut.Text = "";
                TxtDv.Text = "";
                TxtRut.Focus();
                ClientScript.RegisterStartupScript(GetType(), "Registro de usuario", "AlertaRut();", true);
            }

        }

        protected void TxtDv_TextChanged(object sender, EventArgs e)
        {
            Valida_Rut(Int32.Parse(TxtRut.Text));
            
        }

        public void Validar_usuario()
        {
            
            WebMacul.Comun.Usuario ObjUsuarioVar = new WebMacul.Comun.Usuario();
            WebMacul.Negocio.NegUsuario ObjUsuario = new WebMacul.Negocio.NegUsuario();
            DataSet ds = new DataSet();

            ObjUsuarioVar.Email = TxtCorreo.Text;
            ds = ObjUsuario.ExisteUsuario(ObjUsuarioVar);

            if (ds.Tables[0].Rows.Count == 0)
            {
                TxtNom.Focus();
            }
            else
            {
                
                ClientScript.RegisterStartupScript(GetType(), "Registro de usuario", "AlertaUsuarioerror3();", true);
                TxtCorreo.Text = "";
            }

        }

        protected void TxtNom_TextChanged(object sender, EventArgs e)
        {
            TxtRut.Focus();
        }

        protected void TxtRut_TextChanged(object sender, EventArgs e)
        {
            TxtDv.Focus();
        }

        protected void TxtPass2_TextChanged(object sender, EventArgs e)
        {
            BtnGrabar.Focus();
        }

        protected void TxtPass1_TextChanged(object sender, EventArgs e)
        {
            TxtPass2.Focus();
        }

        protected void TxtCcos_TextChanged(object sender, EventArgs e)
        {
            //TxtPass1.Focus();
        }

        protected void TxtCargo_TextChanged(object sender, EventArgs e)
        {
            Cbo_Ccosto.Focus();
            //TxtCcos.Focus();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            
        }

        protected void Cbo_Ccosto_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtCcos.Text = Cbo_Ccosto.Text;
            TxtPass1.Focus();
        }
        
    }
    

}