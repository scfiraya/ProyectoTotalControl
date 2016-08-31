<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="CreacionUsuario.aspx.cs" Inherits="WebTotalControl.Views.Admin.CreacionUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    

    <h1> <strong>Creación Usuario</strong> </h1> <hr />
    
    <div class="form-horizontal" runat="server">

        <asp:DropDownList ID="ddlCargo" runat="server" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlCargo_SelectedIndexChanged" Width="460px">
        <asp:ListItem Value="0" Selected="True">Selecciona el cargo del usuario a crear...</asp:ListItem>
        <asp:ListItem Value="200">Aprendiz</asp:ListItem>
        <asp:ListItem Value="201" >Instructor</asp:ListItem>
        <asp:ListItem Value="202">Vigilante</asp:ListItem>      
    </asp:DropDownList> <br />
        

    <asp:Panel ID="pnlDatos" runat="server" Visible="false">
        
        <div id="divTipoDoc" class="form-group">
            <asp:Label ID="lblTipoDoc" runat="server" Text="Tipo de Documento" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:DropDownList ID="ddlTipoDoc" runat="server" class="form-control"  Width="530px">
                </asp:DropDownList>
            </div>
        </div>

        <div id="divNumDoc" class="form-group">  
            <asp:Label ID="lblNumDoc" runat="server" Text="Número de Documento" class="col-xs-6"></asp:Label>
            <div class="col-xs-6"> 
                <asp:TextBox ID="txtNumDoc" runat="server" class="form-control" placeholder="Ingrese su número de documento" required="required"  Width="530px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revNumDoc" runat="server" CssClass="label label-warning" ErrorMessage="Ingresó un caracter invalido" ControlToValidate="txtNumDoc" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[0-9 ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div id="divNombre" class="form-group">
            <asp:Label ID="lblNombre" runat="server" Text="Nombres" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtNombre" runat="server" class="form-control" placeholder="Ingrese su nombre" required="required" Width="530px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revNombre" runat="server" CssClass="label label-warning" ErrorMessage="Ingresó un caracter invalido" ControlToValidate="txtNombre" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Za-ñA-Ñ ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblApellido" runat="server" Text="Apellidos" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtApellido" runat="server" class="form-control" placeholder="Ingrese su apellido" required="required" Width="530px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" CssClass="label label-warning" ErrorMessage="Ingresó un caracter invalido" ControlToValidate="txtApellido" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Za-ñ ]*$"></asp:RegularExpressionValidator>
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
            <asp:Label ID="lblFichaPrograma" runat="server" Text="Número de ficha/Programa" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:DropDownList ID="ddlFichaPrograma" runat="server" class="form-control" Width="530px">
                </asp:DropDownList>
                <%--<asp:RequiredFieldValidator ID="revPrograma" runat="server" ErrorMessage="Por favor seleccione una opción" ControlToValidate="ddlFichaPrograma" ValidationGroup="grupoval1" InitialValue="--Select--"></asp:RequiredFieldValidator>--%>
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
                <asp:RegularExpressionValidator ID="revContrasena" runat="server" CssClass="label label-warning" ErrorMessage="Su contraseña no cumple con los requisitos" ControlToValidate="txtContrasena" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Za-ñ0-9 ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>
        
        <div class="form-group">
            <asp:Label ID="lblRcontrasena" runat="server" Text="Confirmar contraseña" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtRcontrasena" runat="server" type="password" class="form-control" placeholder="Confirme su nueva contraseña" required="required" Width="530px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revRcontrasena" runat="server" CssClass="label label-warning" ErrorMessage="Su contraseña no cumple con los requisitos" ControlToValidate="txtRcontrasena" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Z0-9- ]*$"></asp:RegularExpressionValidator>
            </div>
        </div> 
                
        <div class="text-center">            
            <asp:Button ID="btnInsertarAprendiz" runat="server" Text="Insertar" CssClass="btn btn-primary" CausesValidation="true" ValidationGroup="grupoval1" OnClick="btnInsertar_Click" />
        </div> <br /> <hr />

        <div class="text-center form-group">
        <h4><i><asp:Label ID="lblValidacion" runat="server" Text="" CssClass="label label-danger text-center form-control"></asp:Label></i></h4>
            <asp:Label ID="lblIniciaSesion" runat="server">¿Deseas </asp:Label>
            <asp:LinkButton ID="lbtIniciaSesion" runat="server" OnClick="lbtIniciaSesion_Click">iniciar sesión</asp:LinkButton>
            <asp:Label runat="server" Text="?"></asp:Label>
        </div>
        <br /> <br />

        <div class="form-group text-center">            
            
        </div>
        <br />


        </asp:Panel>

    </div>
    

</asp:Content>
