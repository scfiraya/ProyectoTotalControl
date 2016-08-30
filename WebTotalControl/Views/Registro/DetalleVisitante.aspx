<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Registro/Registro.Master" AutoEventWireup="true" CodeBehind="DetalleVisitante.aspx.cs" Inherits="WebTotalControl.Views.Registro.DetalleVisitante1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="row">
        <div class="col-xs-12">
            <h1>Registrar Visitante</h1>
        </div>
    </div>
    <br />

    <div id="Div1" class="form-horizontal" runat="server">

        <div class="form-group">
            <asp:Label ID="lblCargo" runat="server" Text="Cargo: " CssClass="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:DropDownList ID="ddlCargo" runat="server"></asp:DropDownList>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblNombre" runat="server" Text="Nombre: " CssClass="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Ingrese el nombre" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revNombre" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtNombre" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblApellido" runat="server" Text="Apellido: " CssClass="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" placeholder="Ingrese el apellido" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revApellido" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtApellido" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblTipoDI" runat="server" Text="Tipo de Documento" CssClass="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:DropDownList ID="ddlTipoDoc" runat="server"></asp:DropDownList>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblNumDoc" runat="server" Text="Número de Documento" CssClass="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtNumDoc" runat="server" CssClass="form-control" placeholder="Ingrese el número de documento" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revNumDoc" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtNumDoc" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[0-9 ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div>
            <asp:Button ID="btnRegisNewDis" runat="server" Text="Registrar Nuevo Dispositivo" CssClass="btn btn-default" OnClick="btnRegisNewDis_Click" />
        </div>

        <div class="text-center submit-main">
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" CssClass="btn btn-success" OnClick="btnRegistrar_Click" />
        </div>

        <asp:Label ID="lblValidacion" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
