<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Registro/Registro.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebTotalControl.Views.Registro.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="row">
        <div class="col-xs-12 col-md-offset-3 col-md-6">
            <h1>Registro Ingreso/Salida</h1>
        </div>
    </div>

    <br />
    <br />
    

    <div class="row">

        <div id="Div1" class="form-horizontal" runat="server">

            <div class="col-xs-12 col-md-offset-3 col-md-6">

                <div class="form-group">
                    <asp:Label ID="lblDocumento" runat="server" Text="Número de Documento" CssClass="col-xs-6"></asp:Label>
                    <div class="col-xs-6">
                        <asp:TextBox ID="txtDocumento" runat="server" CssClass="form-control" placeholder="Ingrese su número de documento"></asp:TextBox>
                    </div>
                </div>

                <div class="text-center">
                    <asp:Button ID="btnIngreso" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="btnIngreso_Click" />
                </div>

                <div class="form-group">
                    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                </div>

                <div class="text-center">
                    <asp:Button ID="btnCrearVisitante" runat="server" Text="Crear Visitante" CssClass="btn btn-primary" OnClick="btnCrearVisitante_Click" />
                </div>
                
            </div>
        </div>
    </div>
</asp:Content>
