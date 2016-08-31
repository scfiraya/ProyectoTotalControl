<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Registro/Registro.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebTotalControl.Views.Registro.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-xs-12 col-md-offset-3 col-md-6">
            <h1>Registro Ingreso/Salida</h1>
        </div>
    </div>
    <div class="row">
        <div class="col-xs-12 col-md-offset-3 col-md-6">
            <div class="form-group">
                <label for="lblTipoDI">Tipo de Documento</label>
                <div>
                    <select id="SelectTipoD" class="form-control">
                        <option>Seleccionar</option>
                        <option selected="selected" value="CC">CC</option>
                        <option value="TI">TI</option>
                        <option value="CE">CE</option>
                        <option value="NIT">NIT</option>

                    </select>
                </div>
            </div>
            <div class="form-group">
                <label for="lblNumeroDI">Número de Documento</label>
                <asp:TextBox ID="txtDocumento" runat="server" Cssclass="form-control" placeholder="Ingrese su numero de documento" ></asp:TextBox>
            </div>

            <div class="text-center">
                <asp:Button ID="btbIngeso" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="btbIngeso_Click" />
            </div>
            <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>

        </div>
    </div>
</asp:Content>
