<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="GenerarReportes.aspx.cs" Inherits="WebTotalControl.Views.Admin.GenerarReportes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <%--   <script type="text/javascript">
        $(function () {
            $('#datetimepicker6').datetimepicker();
            $('#datetimepicker7').datetimepicker({
                useCurrent: false //Important! See issue #1075
            });
            $("#datetimepicker6").on("dp.change", function (e) {
                $('#datetimepicker7').data("DateTimePicker").minDate(e.date);
            });
            $("#datetimepicker7").on("dp.change", function (e) {
                $('#datetimepicker6').data("DateTimePicker").maxDate(e.date);
            });
        });
    </script>--%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Exportar Datos</h1>

    <div class="form-horizontal" runat="server">

        <div class="form-group">
            <asp:Label ID="lblNumFicha" runat="server" CssClass="col-xs-6" Text="Número Ficha"></asp:Label>
            <div class="col-xs-6">
                <asp:DropDownList ID="ddlNumFicha" runat="server"  DataSourceID="SqlDataSource1" DataTextField="NumeroFicha" DataValueField="NumeroFicha"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>" SelectCommand="SELECT [NumeroFicha] FROM [Ficha]"></asp:SqlDataSource>

                <asp:TextBox ID="txtFicha" runat="server"></asp:TextBox>

            </div>
        </div>

        <%--<div class="form-group">
            <asp:Label ID="lblFechaI" runat="server" CssClass="col-xs-6" Text="Fecha Inicial"></asp:Label>
            <div class="col-xs-6">
                <div class="form-group">
                    <div class="input-group date" id="datetimepicker6">
                        <input type="text" class="form-control" />
                        <span class="input-group-addon">
                            <span class="glyphicon glyphicon-calendar"></span>
                        </span>
                    </div>
                </div>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblFechaF" runat="server" CssClass="col-xs-6" Text="Fecha Final"></asp:Label>
            <div class="col-xs-6">
                <div class="form-group">
                    <div class="input-group date" id="datetimepicker7">
                        <input type="text" class="form-control" />
                        <span class="input-group-addon">
                            <span class="glyphicon glyphicon-calendar"></span>
                        </span>
                    </div>
                </div>
            </div>
        </div>--%>

        <div class="text-center">
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="btnBuscar_Click" />
        </div>

        <asp:GridView ID="gvFicha" runat="server" AutoGenerateColumns="false" HeaderStyle-BackColor="WhiteSmoke" RowStyle-HorizontalAlign="Justify">
            <Columns>
                <asp:BoundField HeaderText="Número de Ficha" DataField="NumeroFicha" HeaderStyle-HorizontalAlign="Justify" />
                <asp:BoundField HeaderText="Programa de Formación" DataField="Nombre" HeaderStyle-HorizontalAlign="Justify" />
                <asp:HyperLinkField DataNavigateUrlFields="IdFicha" DataNavigateUrlFormatString="DetalleFichas.aspx" HeaderText="Detalle" Text="Ver" DataTextFormatString="{0:c}" />
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>