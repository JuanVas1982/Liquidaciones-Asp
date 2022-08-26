using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Collections;
using WebMacul.Data;
using WebMacul.Comun;
using WebMacul.Negocio;
using System.Web.Security;



namespace WebMacul
{
    public partial class Autorizacion : System.Web.UI.Page
    {
        ArrayList ar = new ArrayList();
        /*string estado = "";*/

        protected void Page_Load(object sender, EventArgs e)
        {
            Button4.Visible = false;
            if (Session["CCOSTO"].ToString() == "DITEC" & Session["PERFIL"].ToString() == "4")
            {
                Button4.Visible = true;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu.aspx", true);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow grv in GridView1.Rows)
            {
                CheckBox chi = (CheckBox)(grv.FindControl("checkbox2"));


                if (chi.Checked)
                {
                    GridViewRow row = (GridViewRow)chi.NamingContainer;
                    var x = row.RowIndex;
                    string estado;


                    if (GridView1.Rows[x].Cells[7].Text == "N")
                    {

                        estado = "S";
                    }
                    else
                    {

                        estado = "N";
                    }

                    Boolean Resultado;

                    WebMacul.Comun.Usuario ObjUsuario = new WebMacul.Comun.Usuario();
                    NegUsuario ObjActualizaUsuario = new NegUsuario();

                    ObjUsuario.Rut = Int32.Parse(GridView1.Rows[x].Cells[2].Text);
                    ObjUsuario.EstadoE = estado;

                    Resultado = ObjActualizaUsuario.EstadoUsuario(ObjUsuario);


                }

            }
            Response.Redirect("~/Autorizacion.aspx", true);
        }
     
        

        protected void Button4_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow grv in GridView1.Rows)
            {
                CheckBox chi = (CheckBox)(grv.FindControl("checkbox2"));


                if (chi.Checked)
                {
                    GridViewRow row = (GridViewRow)chi.NamingContainer;
                    var x = row.RowIndex;


                    if (GridView1.Rows[x].Cells[7].Text == "S")
                    {
                        Boolean resultado;
                        Boolean RegLog;

                        WebMacul.Comun.Usuario ObjUsuario = new WebMacul.Comun.Usuario();
                        NegUsuario ObjActualizaUsuario = new NegUsuario();

                        ObjUsuario.NomUsuario = GridView1.Rows[x].Cells[1].Text;
                        ObjUsuario.PassWord = "3LzoFCt7QkQ9bI22e/Zf3g==";
                        resultado = ObjActualizaUsuario.ActualizaClaveUsuario(ObjUsuario);

                        if (resultado == true)
                        {
                            ObjUsuario.EstadoE = "Se resetea la clave del funcionario";
                            ObjUsuario.Rut = Convert.ToInt32((Session["RUT"]));
                            ObjUsuario.DV = Session["DV"].ToString();
                            RegLog = ObjActualizaUsuario.RegistraLogUsuario(ObjUsuario);

                            if (RegLog == true)
                            {
                                ClientScript.RegisterStartupScript(GetType(), "Reseteo de clave", "AlertaExito();", true);
                            }
                        }
                        else
                        {
                            ClientScript.RegisterStartupScript(GetType(), "Reseteo de clave", "AlertaClave();", true);


                        }

                        /*Response.Write("<script>window.close('Cambioclave.aspx','popup')</script>");
                        Session.Abandon();
                        Session.Clear();

                        FormsAuthentication.SignOut();
                        Response.Redirect("~/Account/Login.aspx", true);*/

                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(GetType(), "Cambio de clave", "AlertaUsuarioerror();", true);

                    }

                }
                
            }
            Response.Redirect("~/Autorizacion.aspx", true);
        }

    }
}

    
