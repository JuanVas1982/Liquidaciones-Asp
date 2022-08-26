<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cambioclave.aspx.cs" Inherits="WebMacul.Account.Cambioclave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:44%;">
        <tr>
            <td style="text-align: right">
                Cambiar la contraseña</td>
           
            
        </tr>
        <tr>
        <td style="text-align: right">
                                    <asp:Label ID="usuario" runat="server" Text="Usuario:"></asp:Label>
            </td>
         <td>
             <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
         </td>
        </tr>
        <tr>
        <td style="text-align: right">
                                    <asp:Label ID="contrasena" runat="server" Text="Contraseña:"></asp:Label>
            </td>
         <td>
             <asp:TextBox ID="clave_antes" runat="server" TextMode="Password"></asp:TextBox>
         </td>
        </tr>
      
        <tr>
        <td style="text-align: right">
                                    Nueva contraseña:</td>
         <td>
             <asp:TextBox ID="clave_nueva" runat="server" TextMode="Password"></asp:TextBox>
         </td>
        </tr>
     
        <tr>
        <td style="text-align: right">
                                   Confirmar la nueva contraseña:</td>
         <td>
             <asp:TextBox ID="clave_confir" runat="server" TextMode="Password"></asp:TextBox>
         </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            
        </tr>
        <tr>
            <td>
                <asp:Button ID="BtnCambiar" runat="server" onclick="Button1_Click" 
                    Text="Cambiar Contraseña" />
            </td>
            <td>
                <asp:Button ID="BtnCancelar" runat="server" Text="Cancelar" 
                    onclick="BtnCancelar_Click" />
                </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </asp:Content>
