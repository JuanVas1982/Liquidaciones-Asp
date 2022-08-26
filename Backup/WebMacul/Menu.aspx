<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WebMacul.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style13
        {
            height: 21px;
        }
        .style14
        {
            font-weight: 700;
        }
        .style15
        {
            font-weight: 700;
        }
        .style16
        {
            font-weight: 700;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:37%; margin-left: 358px; height: 212px;" aling="center">
        <tr>
            <td colspan="3">
                <asp:Button ID="BtnAuto" runat="server" onclick="BtnAuto_Click" 
                    Text="AUTORIZAR USUARIOS" Width="285px" CssClass="style14" Height="48px" />
            </td>
        </tr>
        <tr>
            <td class="style13" colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style13" colspan="3">
                <asp:Button ID="BtnLiqui" runat="server" onclick="Button1_Click" 
                    Text="LIQUIDACIONES" Width="285px" CssClass="style15" Height="48px" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Button ID="BtnClave" runat="server" onclick="BtnClave_Click" 
                    Text="CAMBIO CONTRASEÑA" Width="285px" CssClass="style16" Height="48px" />
            </td>
        </tr>
    </table>
</asp:Content>
