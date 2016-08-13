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
            <div class="form-group">
                <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
                <asp:TextBox ID="txtUsuario" runat="server" Cssclass="form-control" placeholder="Ingrese su nombre de usuario" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="validacion1" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtUsuario" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>
            </div>
            <div class="form-group">
                <asp:Label ID="lblContrasena" runat="server" Text="Contraseña"></asp:Label>
                <asp:TextBox ID="txtContraseña" runat="server" type="password" Cssclass="form-control" placeholder="Ingrese su contraseña"></asp:TextBox>
            </div>
            <div class="text-center">
                <asp:Button ID="btnIngresar" runat="server" Text="Iniciar Sesión" type="submit" Cssclass="btn btn-primary" ValidationGroup="grupoval1" causesvalidation="true" OnClick="btnIngresar_Click" />
                <asp:Label ID="lblError" runat="server" Text="" CssClass="alert-info"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
