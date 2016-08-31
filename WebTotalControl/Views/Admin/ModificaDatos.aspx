<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ModificaDatos.aspx.cs" Inherits="WebTotalControl.Views.Admin.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h1><strong>Modifica datos</strong></h1> <hr />


    <div class="form-group">
        <asp:Label ID="lblDocumento" runat="server" class="col-lg-7 col-md-6 col-sm-12 col-lg-1 col-xs-12">Número de documento a modificar</asp:Label>
        <div class="col-lg-5 col-md-6 col-sm-12 col-lg-1 col-xs-12">
            <asp:TextBox ID="txtNumDoc" runat="server" CssClass="form-control" placeholder="Ingrese el documento a modificar" required="required" Width="377px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtNumDoc" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[0-9 ]*$"></asp:RegularExpressionValidator>
        </div>
    </div>

    <div class="text-center">
        <asp:Button ID="btnModificar" runat="server" Text="Modificar datos" CssClass="form-control btn btn-primary" OnClick="btnModificar_Click" />
    </div>
     
     

    <asp:Panel ID="pnlModifica" runat="server" Visible="false">

    <div class="form-group">
            <asp:Label ID="lblTipoDoc" runat="server" Text="Tipo de Documento" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:DropDownList ID="ddlTipoDoc" runat="server" class="form-control"  Width="530px">
                </asp:DropDownList>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblNombre" runat="server" Text="Nombres" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtNombre" runat="server" class="form-control" placeholder="Ingrese su nombre" required="required" Width="530px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revNombre" runat="server" CssClass="label label-warning" ErrorMessage="Ingresó un caracter invalido" ControlToValidate="txtNombre" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblApellido" runat="server" Text="Apellidos" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtApellido" runat="server" class="form-control" placeholder="Ingrese su apellido" required="required" Width="530px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" CssClass="label label-warning" ErrorMessage="Ingresó un caracter invalido" ControlToValidate="txtApellido" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>        

        <div class="form-group">
            <asp:Label ID="lblRol" runat="server" Text="Rol" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:DropDownList ID="ddlRol" runat="server" class="form-control" Width="530px">
                </asp:DropDownList>
            </div>
        </div>
        
        <div class="form-group">
            <asp:Label ID="lblFicha" runat="server" Text="Número de ficha" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtFicha" runat="server" class="form-control" placeholder="Ingrese su número de ficha" required="required" Width="530px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revFicha" runat="server" CssClass="label label-warning" ErrorMessage="Ingresó un caracter invalido" ControlToValidate="txtFicha" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[0-9 ]*$"></asp:RegularExpressionValidator>
            </div>
        </div> 

        <div class="form-group">
            <asp:Label ID="lblPrograma" runat="server" Text="Nombre de programa" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:DropDownList ID="ddlPrograma" runat="server" class="form-control" Width="530px">
                </asp:DropDownList>
            </div>
        </div>
        

        <div class="form-group">
            <asp:Label ID="lblLogin" runat="server" Text="Login" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtLogin" runat="server" class="form-control" placeholder="Ingrese su login" required="required" Width="530px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revLogin" runat="server" CssClass="label label-warning" ErrorMessage="Ingresó un caracter invalido" ControlToValidate="txtLogin" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblContrasena" runat="server" Text="Contraseña" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtContrasena" runat="server" type="password" class="form-control" placeholder="Ingrese su nueva contraseña" required="required" Width="530px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revContrasena" runat="server" CssClass="label label-warning" ErrorMessage="Su contraseña no cumple con los requisitos" ControlToValidate="txtContrasena" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Z0-9 ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>
        
        <div class="form-group">
            <asp:Label ID="lblRcontrasena" runat="server" Text="Confirmar contraseña" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtRcontrasena" runat="server" type="password" class="form-control" placeholder="Repita su nueva contraseña" required="required" Width="530px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revRcontrasena" runat="server" CssClass="label label-warning" ErrorMessage="Su contraseña no cumple con los requisitos" ControlToValidate="txtRcontrasena" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Z0-9- ]*$"></asp:RegularExpressionValidator>
            </div>
        </div> 
                
        <div class="form-group">
            <asp:Label ID="lblEstado" runat="server" Text="Estado" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:CheckBox ID="cbEstado" runat="server"/>
                <asp:Label ID="lblActivo" runat="server" Text="Activo"></asp:Label>
            </div>
        </div>
                
        <div class="text-center">            
            <asp:Button ID="btnInsertarAprendiz" runat="server" Text="Insertar" CssClass="btn btn-primary" CausesValidation="true" ValidationGroup="grupoval1"/>
        </div> <br /> <hr />

        <div class="text-center form-group">
        <h4><i><asp:Label ID="lblValidacion" runat="server" Text="" CssClass="label label-danger text-center form-control"></asp:Label></i></h4>
            <asp:Label ID="Label1" runat="server">¿Deseas </asp:Label>
            <asp:LinkButton ID="lbtIniciaSesion" runat="server">iniciar sesión?</asp:LinkButton>
        </div>
        <br /> <br />

        <div class="form-group text-center">           
            
        </div>
        <br />
    </asp:Panel>

</asp:Content>
