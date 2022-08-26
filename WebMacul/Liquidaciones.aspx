<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Liquidaciones.aspx.cs" Inherits="WebMacul.Liquidaciones" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style11
        {
            width: 4px;
        }
        .style12
        {}
        .style13
        {
            width: 76px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%; height: 30px;">
        <tr>
            <td>
                AÑO:&nbsp;<asp:TextBox ID="Txt_ano" runat="server" 
    MaxLength="4" ontextchanged="Txt_ano_TextChanged" Width="40px" Height="20px"></asp:TextBox>
            </td>
           <td class="style13">
                <asp:CheckBox ID="CheckBox1" runat="server" 
                    oncheckedchanged="CheckBox1_CheckedChanged" Text="Horas Extras" 
                    TextAlign="Left" AutoPostBack="True" />
            </td>
            <td>
                MES:&nbsp;<asp:DropDownList ID="CmbListMes" runat="server" Height="28px" 
    onselectedindexchanged="CmbListMes_SelectedIndexChanged" Width="145px" AutoPostBack="True">
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
            
            <td style="text-align: left">
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                    Text="Genera Pdf" />
                &nbsp;
                <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Volver" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
    ControlToValidate="Txt_ano" ErrorMessage="Ingrese Año" style="color: #FF0000"></asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
    ControlToValidate="CmbListMes" ErrorMessage="Selecciones Mes" 
    InitialValue="Ingrese Mes" style="color: #FF0000"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" 
    ControlToValidate="Txt_ano" ErrorMessage="Periodos 2006 al actual" 
    MaximumValue="2099" MinimumValue="2006" style="color: #FF0000"></asp:RangeValidator>
            </td>
        </tr>
        </table>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
        Font-Size="8pt" Height="1050px" InteractiveDeviceInfos="(Colección)" 
        WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="900px" 
        ShowBackButton="False" ShowExportControls="False" ShowFindControls="False" 
        ShowPageNavigationControls="False" ShowRefreshButton="False" 
        ShowZoomControl="False" CssClass="style12">
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
    TypeName="WebMacul.NETMACULDataSetLiqTableAdapters.LiquidacionTableAdapter" 
        onselecting="ObjectDataSource2_Selecting">
    <SelectParameters>
        <asp:SessionParameter Name="Tipo_liq" SessionField="Tipo" Type="Decimal" 
            DefaultValue="1" />
        <asp:SessionParameter Name="Ano_liq" SessionField="ano" Type="Decimal" 
            DefaultValue="2014" />
        <asp:SessionParameter Name="Mes_liq" SessionField="mes" Type="Decimal" 
            DefaultValue="11" />
        <asp:SessionParameter Name="Rut_liq" SessionField="RUT" Type="Decimal" 
            DefaultValue="11845869" />
        <asp:SessionParameter Name="Dv_liq" SessionField="DV" Type="String" 
            DefaultValue="9" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
    
        TypeName="WebMacul.NETMACULDataSetLiqTableAdapters.Det_LiquidacionTableAdapter" 
        onselecting="ObjectDataSource1_Selecting">
    <SelectParameters>
        <asp:SessionParameter Name="Tipo_liq" SessionField="Tipo" Type="Decimal" 
            DefaultValue="1" />
        <asp:SessionParameter DefaultValue="2014" Name="Ano_liq" SessionField="ano" 
            Type="Decimal" />
        <asp:SessionParameter DefaultValue="11" Name="Mes_liq" SessionField="mes" 
            Type="Decimal" />
        <asp:SessionParameter DefaultValue="11845869" Name="Rut_liq" SessionField="RUT" 
            Type="Decimal" />
        <asp:SessionParameter DefaultValue="9" Name="Dv_liq" SessionField="DV" 
            Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
    

    <asp:ScriptManager ID="ScriptManager1" runat="server" />


    </asp:ScriptManager>
    

</asp:Content>
