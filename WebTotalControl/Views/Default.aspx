<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Page.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebTotalControl.Views.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row"> 
        <div class="col-xs-12 col-md-offset-3 col-md-6">
            <img class="img-responsive" alt="Logo TotalControl" src="Image/total-control.png" />
        </div>
    </div>   
    <div class="row">
        <div class="col-xs-12 col-md-offset-3 col-md-6">
            <div class="form-group text-center">                
                <h5><asp:Label ID="lblUsuario" runat="server">Usuario</asp:Label></h5>
                <asp:TextBox ID="txtUsuario" runat="server" Cssclass="form-control" placeholder="Ingrese su nombre de usuario" required="required" Width="550px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="validacion1" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtUsuario" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>
            </div>
            <div class="form-group text-center">
                <h5><asp:Label ID="lblContrasena" runat="server">Contraseña</asp:Label></h5>
                <asp:TextBox ID="txtContraseña" runat="server" type="password" Cssclass="form-control" placeholder="Ingrese su contraseña" Width="550px"></asp:TextBox>
            </div> 
            <div class="text-center">
                <asp:Button ID="btnIngresar" runat="server" Text="Iniciar Sesión" type="submit" Cssclass="btn btn-primary" ValidationGroup="grupoval1" causesvalidation="true" OnClick="btnIngresar_Click" /> <hr />
                <h4><strong><i><asp:Label ID="lblError" runat="server" Text="" CssClass="label label-danger"></asp:Label></i></strong></h4>
            </div>
              
            <div class="text-center">
                <asp:LinkButton ID="lbtOlvido" runat="server" OnClick="lbtOlvido_Click">¿Olvidaste tu contraseña?/Cambiar contraseña</asp:LinkButton>
            </div> 
        </div> 
    </div>
</asp:Content>
 