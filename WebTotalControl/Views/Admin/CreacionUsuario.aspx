<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="CreacionUsuario.aspx.cs" Inherits="WebTotalControl.Views.Admin.CreacionUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Creación Usuario</h1>

    <div class="form-horizontal" runat="server">

        <div class="form-group">
            <asp:Label ID="lblNombre" runat="server" Text="Nombres" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtNombre" runat="server" class="form-control" placeholder="Ingrese su nombre" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revNombre" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtNombre" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblApellido" runat="server" Text="Apellidos" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtApellido" runat="server" class="form-control" placeholder="Ingrese su apellido" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtApellido" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblTipoDoc" runat="server" Text="Tipo de Documento" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <%-- arreglar para que lo traiga de la base de datos  --%>
                <asp:DropDownList ID="ddlTipoDoc" runat="server" class="form-control">
                    <asp:ListItem Selected="FALSE">Seleccionar</asp:ListItem>
                    <asp:ListItem Value="1">Cédula de Ciudadanía</asp:ListItem>
                    <asp:ListItem Value="2">Tarjeta de Identidad</asp:ListItem>
                    <asp:ListItem Value="3">Cédula de Extranjería</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblNumDoc" runat="server" Text="Número de Documento" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtNumDoc" runat="server" class="form-control" placeholder="Ingrese su número de documento" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revNumDoc" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtNumDoc" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[0-9 ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblCargo" runat="server" Text="Cargo" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                 <%-- arreglar para que lo traiga de la base de datos  --%>
                <asp:DropDownList ID="ddlCargo" runat="server" class="form-control">
                    <asp:ListItem Selected="FALSE">Seleccionar</asp:ListItem>
                    <asp:ListItem Value="1">Aprendiz</asp:ListItem>
                    <asp:ListItem Value="2">Instructor</asp:ListItem>
                    <asp:ListItem Value="3">Vigilante</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblRol" runat="server" Text="Rol" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                 <%-- arreglar para que lo traiga de la base de datos  --%>
                <asp:DropDownList ID="ddlRol" runat="server" class="form-control">
                    <asp:ListItem Selected="FALSE">Seleccionar</asp:ListItem>
                    <asp:ListItem Value="1">Administrador</asp:ListItem>
                    <asp:ListItem Value="2">Registrador</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblLogin" runat="server" Text="Login" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtLogin" runat="server" class="form-control" placeholder="Ingrese su login" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revLogin" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtLogin" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblContrasena" runat="server" Text="Contraseña" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtContrasena" runat="server" type="password" class="form-control" placeholder="Ingrese su nueva contraseña" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revContrasena" runat="server" ErrorMessage="Su contraseña no cumple con los requisitos." ControlToValidate="txtContrasena" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Z0-9 ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblRcontrasena" runat="server" Text="Repetir Contraseña" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtRcontrasena" runat="server" type="password" class="form-control" placeholder="Repita su nueva contraseña" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revRcontrasena" runat="server" ErrorMessage="Su contraseña no cumple con los requisitos." ControlToValidate="txtRcontrasena" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Z0-9 ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblEstado" runat="server" Text="Estado" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:CheckBox ID="cbEstado" runat="server" />
            </div>
        </div>

        <div class="text-center">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" CausesValidation="true" ValidationGroup="grupoval1" OnClick="btnGuardar_Click" />
            <asp:Button ID="btnInserter" runat="server" Text="Insertar" CssClass="btn btn-primary" CausesValidation="true" ValidationGroup="grupoval1" OnClick="btnInserter_Click" />
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-primary" CausesValidation="true" ValidationGroup="grupoval1" OnClick="btnModificar_Click" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-primary" CausesValidation="true" ValidationGroup="grupoval1" OnClick="btnEliminar_Click" />
        </div>

        <asp:Label ID="lblValidacion" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
