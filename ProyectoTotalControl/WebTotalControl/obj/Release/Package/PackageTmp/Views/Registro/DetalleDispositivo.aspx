<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Registro/Registro.Master" AutoEventWireup="true" CodeBehind="DetalleDispositivo.aspx.cs" Inherits="WebTotalControl.Views.Registro.DetalleDispositivo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-xs-12">
            <h1>Registro de Dispositivos</h1>
        </div>
    </div>

    <div class="form-group">
        <label class="col-xs-6">Tipo de Dispositivo</label>
        <div class="col-xs-6">
            <select id="Select1" class="form-control">
                <option>Portatil</option>
                <option>Tablet</option>
                <option>Camara</option>
            </select>
        </div>
    </div>

    <div class="form-group">
        <label class="col-xs-6">Serial</label>
        <div class="col-xs-6">
            <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <label class="col-xs-6">Marca</label>
        <div class="col-xs-6">
            <asp:TextBox ID="TextBox2" runat="server" class="form-control"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <label class="col-xs-6">Modelo</label>
        <div class="col-xs-6">
            <asp:TextBox ID="TextBox4" runat="server" class="form-control"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <label class="col-xs-6">Descripción</label>
        <div class="col-xs-6">
            <asp:TextBox ID="TextBox3" runat="server" class="form-control"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <label class="col-xs-6">Cargador</label>
        <div class="col-xs-6">
            <input type="checkbox" />
        </div>
    </div>

    <div class="text-center">
        <button type="button" class="btn btn-primary">Guardar</button>
    </div>
</asp:Content>
