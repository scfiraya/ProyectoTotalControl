<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="CargaAprendiz.aspx.cs" Inherits="WebTotalControl.Views.CargaAprendiz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cargar Aprendiz</h1>
    <div class="form-horizontal" runat="server">
        <div class="form-group">
            <asp:Label ID="lblNumFicha" runat="server" Cssclass="col-xs-6" Text="Número Ficha"></asp:Label>
            <div class="col-xs-6">
                <asp:DropDownList ID="ddlNumFicha" runat="server"  DataSourceID="SqlDataSource1" DataTextField="NumeroFicha" DataValueField="NumeroFicha"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>" SelectCommand="SELECT [NumeroFicha] FROM [Ficha]"></asp:SqlDataSource>

               </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblNomAprendiz" runat="server" Cssclass="col-xs-6" Text="Nombre Aprendiz"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtNomAprendiz" runat="server" Cssclass="form-control" placeholder="Ingrese su nombre de completo" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revNomAprendiz" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtNomAprendiz" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblTipoDoc" runat="server" Cssclass="col-xs-6" Text="Tipo de Documento"></asp:Label>
            <div class="col-xs-6">
                <asp:DropDownList ID="ddlTipoDocumento" runat="server"  DataSourceID="SqlDataSource2" DataTextField="Tipo" DataValueField="Tipo"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>" SelectCommand="SELECT [Tipo] FROM [TipoDocumento]"></asp:SqlDataSource>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblNumDoc" runat="server" Cssclass="col-xs-6" Text="Número de Documento"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtNumDoc" runat="server" Cssclass="form-control" placeholder="Ingrese su número de documento" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revNumDoc" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtNumDoc" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[0-9 ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="text-center">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Cssclass="btn btn-primary" ValidationGroup="grupoval1" CausesValidation="true" OnClick="btnGuardar_Click" />
        </div>
    </div>
</asp:Content>
