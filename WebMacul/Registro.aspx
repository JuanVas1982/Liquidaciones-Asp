<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="WebMacul.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style13
        {
            height: 21px;
            text-align: center;
            color: #FFFFFF;
            background-color: #507CD1;
            font-size:medium;
        }
        .style14
        {
            width: 321px;
            text-align: left;
        }
        .style16
        {
            height: 5px;
            text-align: center;
            }
        .style18
        {
            font-size: large;
        }
        .style19
        {
            font-size: x-large;
        }
        .style23
        {
            width: 321px;
            text-align: left;
            height: 29px;
        }
        .style24
        {
            width: 352px;
            text-align: left;
        }
        .style25
        {
            width: 352px;
            text-align: left;
            height: 29px;
        }
        .style26
        {}
        .style27
        {}
        .style28
        {}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <table style="width: 43%; margin-left: 276px;" bgcolor="#EFF3FB" >
         <tr>
            <td class="style13" colspan="2" ><strong>Registro Funcionario</strong></td>
        </tr>
         <tr>
            <td class="style16" colspan="2" >  </td>
        </tr>
         <tr>
            <td class="style24">
                &nbsp;
                Correo :</td>
            <td class="style14">
                <asp:TextBox ID="TxtCorreo" runat="server" Width="123px" 
                    ontextchanged="TxtNum_TextChanged" AutoPostBack="True"></asp:TextBox>
                <span class="style18"><strong>@munimacul.cl </strong></span>
                <asp:RequiredFieldValidator ID="CorreoRequired" runat="server" 
                    ControlToValidate="TxtCorreo" ErrorMessage="Debe ingresar correo">*</asp:RequiredFieldValidator>
             </td>
        </tr>
         <tr>
            <td class="style24">
                &nbsp; Nombre :</td>
            <td class="style14">
                <asp:TextBox ID="TxtNom" runat="server" Width="256px" AutoPostBack="True" 
                    ontextchanged="TxtNom_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="NombreRequired" runat="server" 
                    ControlToValidate="TxtNom" ErrorMessage="Debe ingresar un nombre">*</asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td class="style24">
                  &nbsp; Rut:</td>
            <td class="style14">
                <asp:TextBox ID="TxtRut" runat="server" Width="68px" MaxLength="8" 
                    AutoPostBack="True" ontextchanged="TxtRut_TextChanged"></asp:TextBox>
                <span class="style19"><strong>-</strong></span><asp:TextBox ID="TxtDv" 
                    runat="server" Width="16px" MaxLength="1" AutoPostBack="True" 
                    ontextchanged="TxtDv_TextChanged"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RutRequired" runat="server" 
                    ControlToValidate="TxtRut" ErrorMessage="Debe ingresar rut ">*</asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator ID="DigitoRequired" runat="server" 
                    ControlToValidate="TxtDv" ErrorMessage="Debe ingresar digito">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        </tr>
         <tr>
            <td class="style24">
                &nbsp;
                Cargo&nbsp; :</td>
            <td class="style14">
                <asp:TextBox ID="TxtCargo" runat="server" Width="256px" AutoPostBack="True" 
                    ontextchanged="TxtCargo_TextChanged"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="CargoRequired" runat="server" 
                    ControlToValidate="TxtCargo" ErrorMessage="Debe ingresar Cargo">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        </tr>
         <tr>
            <td class="style25">
                &nbsp;
                Centro de Costo:</td>
            <td class="style23">
                <asp:DropDownList ID="Cbo_Ccosto" runat="server" AutoPostBack="True" 
                    CssClass="style28" DataSourceID="SqlDataccosto" DataTextField="DES_CC" 
                    DataValueField="DES_CC" Height="16px" 
                    onselectedindexchanged="Cbo_Ccosto_SelectedIndexChanged" Width="107px">
                </asp:DropDownList>
                <asp:TextBox ID="TxtCcos" runat="server" Width="16px" AutoPostBack="True" 
                    ontextchanged="TxtCcos_TextChanged" CssClass="style27" Visible="False"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="CcostoRequired" runat="server" 
                    ControlToValidate="TxtCcos" ErrorMessage="Debe ingresar Centro de costo">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        </tr>
        </tr>
         <tr>
            <td class="style24">
                &nbsp;
                Password Nueva:</td>
            <td class="style14">
                <asp:TextBox ID="TxtPass1" runat="server" Width="100px" TextMode="Password" 
                    ontextchanged="TxtPass1_TextChanged"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="Pass1Required" runat="server" 
                    ControlToValidate="TxtPass1" ErrorMessage="Debe ingresar password ">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        </tr>
         <tr>
            <td class="style24">
                &nbsp;
                Repite Password:</td>
            <td class="style14">
                <asp:TextBox ID="TxtPass2" runat="server" Width="100px" TextMode="Password" 
                    ontextchanged="TxtPass2_TextChanged"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="Pass2Required" runat="server" 
                    ControlToValidate="TxtPass2" ErrorMessage="Debe ingresar password">*</asp:RequiredFieldValidator>
            </td>
        </tr>
      
         <tr>
            <td class="style16" colspan="2">   
                <asp:SqlDataSource ID="SqlDataccosto" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:Conn %>" 
                    SelectCommand="SELECT [DES_CC] FROM [EMAIL_RESPONSABLE] ORDER BY [COD_CC]">
                </asp:SqlDataSource>
             </td>
            <tr>
            <td class="style16" colspan="2">   
                 <asp:Button ID="BtnGrabar" runat="server" Text="Grabar" onclick="Button2_Click" 
                     CssClass="style26" Height="19px" />
                &nbsp;
                </td>
            </tr>
            <tr>
            
            <td class="style16" colspan="2">   </td>
            </tr>
            <tr>
          
            <td class="style16" colspan="2"> <asp:ValidationSummary ID="ValidationSummary1" runat="server" />  </td>
              </tr>
        </tr>
       
         </table>
    </asp:Content>
