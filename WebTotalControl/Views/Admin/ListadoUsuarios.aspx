<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ListadoUsuarios.aspx.cs" Inherits="WebTotalControl.Views.Admin.ListadoUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h1>Listado Usuarios</h1>

    <div class="form-horizontal" runat="server">

        <div class="form-group">
            <asp:Label ID="lblNumDoc" runat="server" Text="Número de Documento" class="col-xs-4"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtNumDoc" runat="server" class="form-control" placeholder="Ingrese su número de documento" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revNumDoc" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtNumDoc" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[0-9 ]*$"></asp:RegularExpressionValidator>
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            </div>
        </div>

        <div class="form-group">
            <asp:GridView ID="gvBuscarUsuario" runat="server" AutoGenerateColumns="false" HeaderStyle-BackColor="WhiteSmoke" RowStyle-HorizontalAlign="Justify">
            <Columns>
                <asp:BoundField HeaderText="Nombres" DataField="Nombre" HeaderStyle-HorizontalAlign="Justify" />
                <asp:BoundField HeaderText="Apellidos" DataField="Apellido" HeaderStyle-HorizontalAlign="Justify" />
                <asp:BoundField HeaderText="Tipo de Documento" DataField="IdTipoDocumento" HeaderStyle-HorizontalAlign="Justify" />
                <asp:BoundField HeaderText="Número de Documento" DataField="NumeroIdentificacion" HeaderStyle-HorizontalAlign="Justify" />
                <asp:BoundField HeaderText="Cargo" DataField="Cargo" HeaderStyle-HorizontalAlign="Justify" />
                <asp:BoundField HeaderText="Rol" DataField="NombreRol" HeaderStyle-HorizontalAlign="Justify" />
                <asp:BoundField HeaderText="Login" DataField="Usuario" HeaderStyle-HorizontalAlign="Justify" />
                <asp:BoundField HeaderText="Estado" DataField="Activo" HeaderStyle-HorizontalAlign="Justify" />
                <asp:HyperLinkField DataNavigateUrlFields="IdFicha" DataNavigateUrlFormatString="DetalleFichas.aspx" HeaderText="Detalle" Text="Ver" DataTextFormatString="{0:c}" />
            </Columns>
        </asp:GridView>
        </div>

        </div>
</asp:Content>
