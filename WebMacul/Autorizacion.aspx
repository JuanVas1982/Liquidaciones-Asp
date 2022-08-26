<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Autorizacion.aspx.cs" Inherits="WebMacul.Autorizacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style4
        {}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:80%; margin-left: 95px;" aling="center">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" runat="server" AllowSorting="True" 
                    AutoGenerateColumns="False" DataSourceID="SqlAutoUser" 
                    EnableModelValidation="True" CellPadding="4" ForeColor="#333333" 
                    GridLines="None" onselectedindexchanged="GridView1_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" 
                                    oncheckedchanged="CheckBox2_CheckedChanged" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="USUA_SISTWEB" HeaderText="USUARIO" 
                            SortExpression="USUA_SISTWEB" />
                        <asp:BoundField DataField="USUA_RUT" HeaderText="RUT" 
                            SortExpression="USUA_RUT" />
                        <asp:BoundField DataField="USUA_DV" HeaderText="DV" 
                            SortExpression="USUA_DV" />
                        <asp:BoundField DataField="USUA_NOMBRE" HeaderText="NOMBRE" 
                            SortExpression="USUA_NOMBRE" />
                        <asp:BoundField DataField="USUA_FECHA_INGRESO" HeaderText="FECHA CREACION" 
                            SortExpression="USUA_FECHA_INGRESO" />
                        <asp:BoundField DataField="USUA_CORREO" HeaderText="CORREO" 
                            SortExpression="USUA_CORREO" />
                        <asp:BoundField DataField="USUA_VIGENCIA" HeaderText="VIGENCIA" 
                            SortExpression="USUA_VIGENCIA" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <EmptyDataTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </EmptyDataTemplate>
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlAutoUser" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:Conn %>" 
                    
                    SelectCommand="SELECT [USUA_SISTWEB], [USUA_RUT], [USUA_DV], [USUA_NOMBRE], [USUA_CORREO], [USUA_FECHA_INGRESO], [USUA_VIGENCIA] FROM [NM_USUARIO] WHERE ([USUA_CCOSTO] = @USUA_CCOSTO)">
                    <SelectParameters>
                        <asp:SessionParameter DefaultValue="ditec" Name="USUA_CCOSTO" 
                            SessionField="CCOSTO" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button4" runat="server" onclick="Button4_Click" 
                    Text="Resetear Clave" />
&nbsp;
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Volver" />
&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Cambiar Estado" 
                    onclick="Button2_Click" CssClass="style4" Width="112px" />
&nbsp;
                </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
