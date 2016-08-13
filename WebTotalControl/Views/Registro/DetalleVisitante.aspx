<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Registro/Registro.Master" AutoEventWireup="true" CodeBehind="DetalleVisitante.aspx.cs" Inherits="WebTotalControl.Views.Registro.DetalleVisitante1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Registrar Visitante</h1>
    <div class="form-group">
        <label class="col-xs-6">Nombre Completo</label>
        <div class="col-xs-6">
            <asp:TextBox ID="TextBox1" runat="server" class="form-control" required="required"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <label class="col-xs-6">Tipo de Documento</label>
        <div class="col-xs-6">
            <select id="SelectTipoD" class="form-control" required="required">
                <option value="">Seleccionar</option>
                <option value="cc">Cédula de Ciudadanía</option>
                <option value="ti">Tarjeta de Identidad</option>
                <option value="ce">Cédula de Extranjería</option>
            </select>
        </div>
    </div>

    <div class="form-group">
        <label class="col-xs-6">Número de Documento</label>
        <div class="col-xs-6">
            <asp:TextBox ID="TextBox2" runat="server" class="form-control" required="required"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <label class="col-xs-6">Seccion a Visitar</label>
        <div class="col-xs-6">
            <select id="Selectficha" class="form-control" required="required">
                <option>Piso 1</option>
                <option>Piso 2</option>
                <option>Piso 3</option>
            </select>
        </div>
    </div>

    <div>
        <button class="btn btn-default">Registrar nuevo equipo</button>
    </div>

    <div class="text-center submit-main">
        <button class="btn btn-success">
            <span class="glyphicon glyphicon-ok"></span>
            <span>Registrar</span>
        </button>
    </div>
</asp:Content>
