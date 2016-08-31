<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="CreacionFichas.aspx.cs" Inherits="WebTotalControl.Views.CreacionFichas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-xs-12">
            <h1>Creación de Fichas</h1>
        </div>
    </div>
    <div id="Div1" class="form-horizontal" runat="server">
        <div class="form-group">
            <asp:Label ID="lblProFor" runat="server" Text="Programa de Formación" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:DropDownList ID="ddlFicha" runat="server" OnSelectedIndexChanged="ddlFicha_SelectedIndexChanged" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Nombre"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>" SelectCommand="SELECT [Nombre] FROM [Ficha]"></asp:SqlDataSource>
            </div>
        </div> 

        <div class="form-group">
            <asp:Label ID="lblCodFicha" runat="server" Text="Número de Ficha" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtCodFicha" runat="server" class="form-control" placeholder="Ingrese el número de la ficha" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revCodFicha" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtCodFicha" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-z0-9 ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblInstructor" runat="server" Text="Instructor" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtInstructor" runat="server" class="form-control" placeholder="Ingrese el nombre del Instructor" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revInstructor" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtInstructor" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-z ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblAmbiente" runat="server" Text="Ambiente" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtAmbiente" runat="server" class="form-control" placeholder="Ingrese el código del ambiente" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revAmbiente" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtAmbiente" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[0-9 ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:FileUpload ID="fuSubirArchivo" runat="server"  AllowMultiple="true" Text="Buscar Archivo" class="col-xs-6" />
            <div class="col-xs-6">
                <asp:Button ID="btnSubir" Text="Subir" runat="server" aceptan="image/gif,image/jpg" class="btn btn-primary" OnClick="btnSubir_Click" />
            </div>
            <div class="col-xs-6">
                <asp:Label ID="lblSuccess" runat="server" Text="" class="col-xs-6"></asp:Label>
            </div>
        </div>

        <div class="text-center">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-primary" ValidationGroup="grupoval1" CausesValidation="true" OnClick="btnGuardar_Click" />
        </div>
    </div>
</asp:Content>
