<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Funcionario.aspx.cs" Inherits="WebMacul.Funcionario" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style10
    {
        width: 269px;
    }
    .style11
    {
        width: 89px;
    }
        .style13
        {
        width: 158px;
    }
    .style14
    {
        width: 221px;
        text-align: left;
    }
    .style15
    {
        width: 158px;
        text-align: left;
    }
    .style16
    {
        width: 187px;
    }
        .style17
        {
            width: 4px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
         <tr>
            <td class="style16">
         
                               
            </td>
            <td class="style13">
                &nbsp;
            </td>
            <td class="style10">
                &nbsp;
            </td>
            <td class="style11">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style16">
                &nbsp;
            </td>
            <td class="style13">
                &nbsp;
                &nbsp;
                </td>
             <td align="center" colspan="2" 
                                
                                style="color:White;background-color:#507CD1;font-size:1.2em;font-weight:bold;" 
                                bgcolor="#95ADC9">
                                Informacion Funcionario</td>
            <td class="style11">
                &nbsp;
                </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
         <tr>
            <td class="style16">
                &nbsp;
            </td>
            <td class="style13">
                &nbsp;
            </td>
            <td class="style10">
                &nbsp;
                </td>
            <td class="style11">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
         <tr>
            <td class="style16">
                &nbsp;
            </td>
            <td class="style15">
                &nbsp;
                <asp:Label ID="Label1" runat="server" Text="Numero Funcionario:"></asp:Label>
            </td>
            <td class="style14">
                <asp:TextBox ID="TxtNum" runat="server" Width="60px" Enabled="False" 
                    ontextchanged="TxtNum_TextChanged"></asp:TextBox>
            </td>
            <td class="style11">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
         <tr>
            <td class="style16">
                &nbsp;
            </td>
            <td class="style15">
                &nbsp;
                Nombres:</td>
            <td class="style14">
                <asp:TextBox ID="TxtNom" runat="server" Width="258px" Enabled="False"></asp:TextBox>
            </td>
            <td class="style11">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
         <tr>
            <td class="style16">
                &nbsp;
            </td>
            <td class="style15">
                &nbsp;
                Fecha Nacimiento:</td>
            <td class="style14">
                <asp:TextBox ID="TxtFnac" runat="server" Width="67px" Enabled="False" 
                    ontextchanged="TxtFnac_TextChanged"></asp:TextBox>
            </td>
            <td class="style11">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        </tr>
         <tr>
            <td class="style16">
                &nbsp;
            </td>
            <td class="style15">
                &nbsp;
                <asp:Label ID="Label2" runat="server" Text="Estudios:"></asp:Label>
            </td>
            <td class="style14">
                <asp:TextBox ID="TxtEst" runat="server" Width="257px" Height="21px" 
                    Enabled="False"></asp:TextBox>
            </td>
            <td class="style11">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        </tr>
         <tr>
            <td class="style16">
                &nbsp;
            </td>
            <td class="style15">
                &nbsp;
                <asp:Label ID="Label3" runat="server" Text="Centro de Costo:"></asp:Label>
            </td>
            <td class="style14">
                <asp:TextBox ID="TxtCcos" runat="server" Width="255px" Enabled="False"></asp:TextBox>
            </td>
            <td class="style11">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        </tr>
         <tr>
            <td class="style16">
                &nbsp;
            </td>
            <td class="style15">
                &nbsp;
                <asp:Label ID="Label5" runat="server" Text="Calidad Juridica:"></asp:Label>
            </td>
            <td class="style14">
                <asp:TextBox ID="TxtCjur" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td class="style11">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        </tr>
         <tr>
            <td class="style16">
                &nbsp;
            </td>
            <td class="style15">
                &nbsp;
                <asp:Label ID="Label4" runat="server" Text="Escalafon:"></asp:Label>
            </td>
            <td class="style14">
                <asp:TextBox ID="TxtCom" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td class="style11">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        </tr>
         <tr>
            <td class="style16">
                &nbsp;
            </td>
            <td class="style15">
                &nbsp;
                <asp:Label ID="Label6" runat="server" Text="Grado:"></asp:Label>
            </td>
            <td class="style14">
                <asp:TextBox ID="TxtGra" runat="server" Width="40px" Enabled="False"></asp:TextBox>
            </td>
            <td class="style11">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        </tr>
         <tr>
            <td class="style16">
                &nbsp;
            </td>
            <td class="style13">
                &nbsp;
            </td>
            <td class="style10">
                &nbsp;
            </td>
            <td class="style11">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        </tr>
         <tr>
            <td class="style16">
                &nbsp;
            </td>
            <td class="style13">
                &nbsp;
            </td>
            <td class="style10">
                &nbsp;
            </td>
            <td class="style11">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>
