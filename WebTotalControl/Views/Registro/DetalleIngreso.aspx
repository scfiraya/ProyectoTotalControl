<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Registro/Registro.Master" AutoEventWireup="true" CodeBehind="DetalleIngreso.aspx.cs" Inherits="WebTotalControl.Views.Registro.DetalleIngreso" %>

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
           
            <div><p>Nombre completo:</p><asp:Label ID="lblNom" runat="server" Text=""></asp:Label></div>
            <p>Número de identificación:</p><asp:Label ID="lblDocumento" runat="server" Text=""></asp:Label>
            <p>Cargo: Aprendiz</p>
            <p>Ficha: 901541G1</p>
        </div>
    </div>

    <div class="row">
        <div class="col-xs-9">
            <strong>Equipos registrados</strong>
        </div>
        <div class="col-xs-3 text-right">
            <input type="text" name="search-device" placeholder="Ingresar serial equipo" class="form-control" />
        </div>
    </div>

    <div class="table-responsive devices-list">
        <table class="table table-bordered">
            <tr>
                <th>Marca</th>
                <th>Modelo</th>
                <th>Serial</th>
                <th class="text-center">Cargador</th>
                <th class="text-center">Ingresar</th>
            </tr>

            <tr>
                <td>Marca 1</td>
                <td>Modelo 1</td>
                <td>00000000001</td>
                <td class="text-center">
                    <input type="checkbox" />
                </td>
                <td class="text-center">
                    <a href="#">
                        <span class="glyphicon glyphicon-ok-circle"></span>
                    </a>
                </td>
            </tr>

            <tr>
                <td>Marca 2</td>
                <td>Modelo 2</td>
                <td>00000000002</td>
                <td class="text-center">
                    <input type="checkbox" />
                </td>
                <td class="text-center">
                    <a href="#">
                        <span class="glyphicon glyphicon-ok-circle"></span>
                    </a>
                </td>
            </tr>
        </table>
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
