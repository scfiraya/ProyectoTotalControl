﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Registro/Registro.Master" AutoEventWireup="true" CodeBehind="DetalleIngreso.aspx.cs" Inherits="WebTotalControl.Views.Registro.DetalleIngreso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h1 class="col-xs-12">Ingreso Usuario</h1>
    </div>

    <div class="row">
        <div class="col-xs-3 text-center">
            <img src="../Image/profile-default.png" alt="Foto usuario" class="img-responsive img-profile" />
        </div>

        <div class="col-xs-9 profile-info">
            <div>
                <asp:Label ID="lblNombre1" runat="server" Text="Nombre Completo: "></asp:Label>
                <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
            </div>

            <div>
                <asp:Label ID="lblNumDoc1" runat="server" Text="Número de identificación:"></asp:Label>
                <asp:Label ID="lblNumDoc" runat="server" Text=""></asp:Label>
            </div>

            <div>
                <asp:Label ID="lblCargo1" runat="server" Text="Cargo: "></asp:Label>
                <asp:Label ID="lblCargo" runat="server" Text=""></asp:Label>
            </div>

            <div>
                <asp:Label ID="lblFicha1" runat="server" Text="Número de Ficha: "></asp:Label>
                <asp:Label ID="lblFicha" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>

    <div class="row">

        <div class="form-group">
            <asp:Label ID="lblSeccion" runat="server" Text="Seccion a Visitar" CssClass="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:DropDownList ID="dllSeccion" runat="server"></asp:DropDownList>
            </div>
        </div>

        <div class="col-xs-9">
            <strong>Dispositivos Registrados</strong>
        </div>

    </div>

    <div class="form-group">
        <asp:GridView ID="gvDispositivos" runat="server" AutoGenerateColumns="false" HeaderStyle-BackColor="WhiteSmoke" RowStyle-HorizontalAlign="Justify" DataKeyNames="Nombre,Serial,Marca,Descripcion">
            <Columns>

                <asp:BoundField HeaderText="Tipo del Dispositivo" DataField="Nombre" />
                <asp:BoundField HeaderText="Serial del Dispositivo" DataField="Serial" />
                <asp:BoundField HeaderText="Marca del Dispositivo" DataField="Marca" />
                <asp:BoundField HeaderText="Descripción del Dispositivo" DataField="Descripcion" />

                <asp:TemplateField HeaderText="Cargador">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>

                </asp:TemplateField>

                <asp:TemplateField HeaderText="Ingreso">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox2" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>

    <div>
        <asp:Button ID="btnRegisNewDis" runat="server" Text="Registrar Nuevo Dispositivo" CssClass="btn btn-default" OnClick="btnRegisNewDis_Click" />
    </div>

    <div class="text-center submit-main">
        <asp:Button ID="btnIngresar" runat="server" Text="Registrar Ingreso" CssClass="btn btn-success" OnClick="btnIngresar_Click" />
    </div>
</asp:Content>
