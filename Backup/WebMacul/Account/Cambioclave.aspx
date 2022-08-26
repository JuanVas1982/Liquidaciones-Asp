<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cambioclave.aspx.cs" Inherits="WebMacul.Account.Cambioclave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style13
        {
            width: 177px;
            text-align: left;
        }
        .style14
        {            height: 33px;
        }
        .style16
        {
            color: #0000FF;
            font-family: Verdana;
            width: 177px;
        }
        .style17
        {
            width: 177px;
            text-align: left;
            color: #0000FF;
            font-family: Verdana;
        }
        .style18
        {
            height: 1px;
            width: 177px;
        }
        .style19
        {
            width: 177px;
        }
        .style20
        {
            font-family: Verdana;
        }
        .style21
        {
            height: 26px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <table style="width:31%; height: 144px;" bgcolor="#EFF3FB" align="center">
    <tr>
    <td class="style18"></td>
    <td style="height:1px"></td>
    </tr>
       <tr>
      
        <td align="center" colspan="2" 
                                
                                
               style="color:White;background-color:#507CD1;font-size:1.2em;font-weight:bold;" 
               class="style20">
                                Cambio Contraseña</td>
      
    </tr>
      
        <tr>
        <td class="style13">
                                    &nbsp;</td>
         <td>
             &nbsp;</td>
        </tr>
      
        <tr>
        <td class="style17">
                                    Contraseña Actual&nbsp;&nbsp;&nbsp; :</td>
         <td>
             <asp:TextBox ID="clave_antes" runat="server" TextMode="Password" Width="116px"></asp:TextBox>
         </td>
        </tr>
      
        <tr>
        <td class="style16" style="text-align: left">Contraseña Nueva&nbsp;&nbsp;&nbsp; :</td>
         <td>
             <asp:TextBox ID="clave_nueva" runat="server" TextMode="Password" Width="116px" 
                 ontextchanged="clave_nueva_TextChanged"></asp:TextBox>
         </td>
        </tr>
      
        <tr>
        <td class="style17">
                                   Confirmar contraseña:</td>
         <td>
             <asp:TextBox ID="clave_confir" runat="server" TextMode="Password" Width="116px"></asp:TextBox>
         </td>
        </tr>
        <tr>
            <td class="style19">
                &nbsp;</td>
            
        </tr>
        <tr>
            <td style="text-align: center" class="style14" colspan="2">
                <asp:Button ID="BtnCambiar" runat="server" onclick="Button1_Click" 
                    Text="Aceptar" Width="83px" CssClass="style21" />
            &nbsp;
                <asp:Button ID="BtnCancelar" runat="server" Text="Cancelar" 
                    onclick="BtnCancelar_Click" PostBackUrl="~/Menu.aspx" Width="83px" />
            </td>
        </tr>
    </table>
<br />
    </asp:Content>
