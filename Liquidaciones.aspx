<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Liquidaciones.aspx.cs" Inherits="WebMacul.Liquidaciones" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style10
        {
            height: 16px;
        }
        .style11
        {
            width: 4px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td>
                AÑO:&nbsp;<asp:TextBox ID="Txt_ano" runat="server" 
    MaxLength="4" ontextchanged="Txt_ano_TextChanged" Width="40px" Height="16px"></asp:TextBox>
            </td>
           
            <td>
                MES:&nbsp;<asp:DropDownList ID="CmbListMes" runat="server" 
    AutoPostBack="True" Height="18px" 
    onselectedindexchanged="CmbListMes_SelectedIndexChanged" Width="145px">
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
            </td>
            <td class="style11">
        <asp:TextBox ID="Txt_mes" runat="server" Visible="False" Width="16px" 
                    ontextchanged="Txt_mes_TextChanged"></asp:TextBox> 
        &nbsp;</td>
            <td>
        <asp:Button ID="Button1" runat="server" Text="CONSULTAR" 
            onclick="Button1_Click" Width="93px" />
            </td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
    ControlToValidate="Txt_ano" ErrorMessage="Ingrese Año" style="color: #FF0000"></asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
    ControlToValidate="CmbListMes" ErrorMessage="Selecciones Mes" 
    InitialValue="Ingrese Mes" style="color: #FF0000"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" 
    ControlToValidate="Txt_ano" ErrorMessage="Periodos 2006 al actual" 
    MaximumValue="2014" MinimumValue="2006" style="color: #FF0000"></asp:RangeValidator>
            </td>
        </tr>
        </table>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
    Font-Size="8pt" Height="439px" InteractiveDeviceInfos="(Colección)" 
    WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="789px">
        <LocalReport ReportPath="Liquidaciones.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" 
                    Name="DSLiqudaciones" />
                <rsweb:ReportDataSource DataSourceId="ObjectDataSource2" 
                    Name="DS_Liquidacion" />
            </DataSources>
        </LocalReport>
</rsweb:ReportViewer>
<asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
    TypeName="WebMacul.NETMACULDataSetLiqTableAdapters.LiquidacionTableAdapter">
    <SelectParameters>
        <asp:SessionParameter Name="Tipo_liq" SessionField="Tipo" Type="Decimal" />
        <asp:SessionParameter Name="Ano_liq" SessionField="ano" Type="Decimal" />
        <asp:SessionParameter Name="Mes_liq" SessionField="mes" Type="Decimal" />
        <asp:SessionParameter Name="Rut_liq" SessionField="RUT" Type="Decimal" />
        <asp:SessionParameter Name="Dv_liq" SessionField="DV" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
    TypeName="WebMacul.NETMACULDataSetLiqTableAdapters.Det_LiquidacionTableAdapter">
    <SelectParameters>
        <asp:SessionParameter Name="Tipo_liq" SessionField="Tipo" Type="Decimal" />
        <asp:SessionParameter DefaultValue="" Name="Ano_liq" SessionField="ano" 
            Type="Decimal" />
        <asp:SessionParameter DefaultValue="" Name="Mes_liq" SessionField="mes" 
            Type="Decimal" />
        <asp:SessionParameter DefaultValue="" Name="Rut_liq" SessionField="RUT" 
            Type="Decimal" />
        <asp:SessionParameter DefaultValue="" Name="Dv_liq" SessionField="DV" 
            Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
    <br />

</asp:Content>
