<%@ Page Title="Iniciar sesión" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="WebMacul.Account.Login" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
    <asp:Login ID="Login1" runat="server" onauthenticate="Login_Authenticate" 
        Height="211px" 
        
        style="text-align: center; margin-top: 0px; color: #0000FF; margin-left: 348px;" 
        Width="261px" BackColor="#EFF3FB" BorderColor="#B5C7DE" BorderPadding="4" 
        BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" 
        ForeColor="#333333">
        <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
        <LayoutTemplate>
               <table style="width:35%;" align="center">
                <tr>
                    <td>
                        <table style="width:106%; height: 191px;" align="center">
                        <tr>
                        <td align="center" colspan="2" 
                                style="color:White;background-color:#507CD1;font-size:1.2em;font-weight:bold;"> Inicio Sesion</td>
      
                        </tr>
                            <tr>
                                <td align="right" style="text-align: left">
                                    <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName" 
                                        style="text-align: left">Usuario:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="UserName" runat="server" Width="114px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                                        ControlToValidate="UserName" 
                                        ErrorMessage="El nombre de usuario es obligatorio." 
                                        ToolTip="El nombre de usuario es obligatorio." ValidationGroup="Login">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Contraseña:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="Password" runat="server" TextMode="Password" Width="115px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" 
                                        ControlToValidate="Password" ErrorMessage="La contraseña es obligatoria." 
                                        ToolTip="La contraseña es obligatoria." ValidationGroup="Login">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:CheckBox ID="RememberMe" runat="server" 
                                        Text="Recordármelo la próxima vez." />
                                </td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2" style="color:Red;">
                                    <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                </td>
                            </tr>
                             <tr>
                                <td colspan="2" align="center">
                                    <asp:Button ID="LoginButton" runat="server" CommandName="Login" aling="center"
                                        Text="Inicio de sesión" ValidationGroup="Login" style="text-align: left" 
                                        onclick="LoginButton_Click" />
                                </td>
                                
                            </tr>
                            <tr>
                                <td align="center" colspan="2" style="color:Red;">
                                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registro.aspx">Registrar Nuevo usuario</asp:HyperLink>
                                </td>
                            </tr>
                           
                            
                        </table>
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" 
            BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
        <TextBoxStyle Font-Size="0.8em" />
        <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.9em" 
            ForeColor="White" />
</asp:Login>
</asp:Content>
