<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Registro/Registro.Master" AutoEventWireup="true" CodeBehind="DetalleDispositivo.aspx.cs" Inherits="WebTotalControl.Views.Registro.DetalleDispositivo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="row">
        <div class="col-xs-12">
            <h1>Registro de Dispositivos</h1>
        </div>
    </div>
    <br />
    <div id="Div1" class="form-horizontal" runat="server">
        <div class="form-group">
            <asp:Label ID="lblTipoDis" runat="server" Text="Tipo de Dispositivo" CssClass="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:DropDownList ID="ddlTipoDis" runat="server"></asp:DropDownList>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblSerial" runat="server" Text="Serial" CssClass="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtSerial" runat="server" CssClass="form-control" placeholder="Ingrese el serial del dispositivo" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revSerial" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtSerial" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[0-9a-zA-Z ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblMarca" runat="server" Text="Marca" CssClass="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtMarca" runat="server" CssClass="form-control" placeholder="Ingrese la marca del dispositivo" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revMarca" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtMarca" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblDescripcion" runat="server" Text="Descripción" CssClass="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" placeholder="Ingrese una descripción del dispositivo" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revDescripcion" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtDescripcion" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblCargador" runat="server" Text="Cargador" CssClass="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:CheckBox ID="cbCargador" runat="server" />
            </div>
        </div>

        <div class="text-center">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
        </div>

        <div class="form-group">
            <asp:Label ID="lblValidacion" runat="server" Text="" CssClass="col-xs-6"></asp:Label>
        </div>

    </div>
</asp:Content>
