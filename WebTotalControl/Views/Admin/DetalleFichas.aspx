<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="DetalleFichas.aspx.cs" Inherits="WebTotalControl.Views.DetalleFichas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row record-card-info">

        <div class="col-xs-12">
            <h2>Detalle Ficha
                <%-- configurar para que traiga datos de la base de datos --%>
                <asp:Label ID="lblEncabezado" runat="server" Text=""></asp:Label><br />
            </h2>
        </div>

        <div class="col-xs-8">
            <asp:Label ID="Label4" runat="server" Text="Programa de Formación"></asp:Label><br />
            <asp:Label ID="Label5" runat="server" Text="Instructor"></asp:Label><br />
            <asp:Label ID="Label6" runat="server" Text="Ambiente"></asp:Label><br />
        </div>

        <div class="col-xs-4">
            <asp:Label ID="lblPrograma" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="lblAmbiente" runat="server" Text=""></asp:Label><br />
        </div>
    </div>

    <div class="row">
        <div class="col-xs-8">
            <asp:GridView ID="gvDetalle" runat="server" AutoGenerateColumns="false" RowStyle-HorizontalAlign="Justify">
                <Columns>
                    <asp:BoundField HeaderText="Nombres" DataField="Nombre" HeaderStyle-HorizontalAlign="Justify" />
                    <asp:BoundField HeaderText="Apellidos" DataField="Apellido" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
