<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Liquidacion.aspx.cs" Inherits="WebMacul.Liquidacion" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

    <style type="text/css">
        #Text2
        {
            width: 25px;
        }
        #Text1
        {
            width: 40px;
        }
        #Txt_ano
        {
            width: 40px;
        }
        #Txt_mes
        {
            width: 26px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server"   >
  
        <asp:Label ID="Label1" runat="server" Text="AÑO: "></asp:Label>
        <asp:TextBox ID="Txt_ano" runat="server" AutoPostBack="True" 
    MaxLength="4" ontextchanged="Txt_ano_TextChanged" Width="40px"></asp:TextBox>
&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
    ControlToValidate="Txt_ano" ErrorMessage="Ingrese Año" style="color: #FF0000"></asp:RequiredFieldValidator>
&nbsp; <asp:Label ID="Label2" runat="server" Text="MES: "></asp:Label>
        <asp:TextBox ID="Txt_mes" runat="server" Visible="False"></asp:TextBox>
        &nbsp;&nbsp;<asp:DropDownList ID="CmbListMes" runat="server" 
    AutoPostBack="True" Height="19px" 
    onselectedindexchanged="CmbListMes_SelectedIndexChanged" Width="158px">
    <asp:ListItem>Ingrese Mes</asp:ListItem>
    <asp:ListItem Value="Enero">Enero</asp:ListItem>
    <asp:ListItem>Febrero</asp:ListItem>
    <asp:ListItem>Marzo</asp:ListItem>
    <asp:ListItem>Abril</asp:ListItem>
    <asp:ListItem>Mayo</asp:ListItem>
    <asp:ListItem>Junio</asp:ListItem>
    <asp:ListItem>Julio</asp:ListItem>
    <asp:ListItem>Agosto</asp:ListItem>
    <asp:ListItem>Septiembre</asp:ListItem>
    <asp:ListItem>Octubre</asp:ListItem>
    <asp:ListItem>Noviembre</asp:ListItem>
    <asp:ListItem>Diciembre</asp:ListItem>
</asp:DropDownList>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
    ControlToValidate="CmbListMes" ErrorMessage="Selecciones Mes" 
    InitialValue="Ingrese Mes" style="color: #FF0000"></asp:RequiredFieldValidator>
&nbsp;
        <asp:Button ID="Button1" runat="server" Text="CONSULTAR" 
            onclick="Button1_Click" Width="93px" />
        &nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" 
    ControlToValidate="Txt_ano" ErrorMessage="Periodos 2006 al actual" 
    MaximumValue="2014" MinimumValue="2006" style="color: #FF0000"></asp:RangeValidator>
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
            AutoDataBind="true" ReportSourceID="CrystalReportSource1" ToolPanelView="None" 
            Visible="False" oninit="CrystalReportViewer1_Init1" />
        <br />
        <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
            <Report FileName="CrLiquidacion.rpt">
            </Report>
        </CR:CrystalReportSource>
    
</asp:Content>
