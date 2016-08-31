<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Registro/Registro.Master" AutoEventWireup="true" CodeBehind="DetalleSalida.aspx.cs" Inherits="WebTotalControl.Views.Registro.DetalleSalida" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h1 class="col-xs-12">Salida Usuario</h1>
    </div>

    <div class="row">
        <div class="col-xs-3 text-center">
            <img src="../Image/profile-default.png" alt="Foto usuario" class="img-responsive img-profile" />
        </div>
        <div class="col-xs-6 profile-info">
            <p>Nombre completo: Sindy Carolina Firaya</p>
            <p>Número de identificación: 1032564896</p>
            <p>Cargo: Aprendiz</p>
            <p>Ficha: 901541G1</p>
        </div>
        <div class="table-responsive devices-list">
            <table class="table table-bordered">
                <tr>
                    <th>Hora de Ingreso</th>
                </tr>
                <tr>
                    <th>2016-06-24 18:03:45</th>
                </tr>
            </table>
        </div>
    </div>

    <div class="row">
        <div class="col-xs-9">
            <strong>Equipos Ingresados</strong>
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
                <th class="text-center"></th>
            </tr>

            <tr>
                <td>Marca 1</td>
                <td>Modelo 1</td>
                <td>00000000001</td>
                <td class="text-center">
                    <a href="#">
                        <span class="glyphicon glyphicon-ok-circle"></span>
                    </a>
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
                    <a href="#">
                        <span class="glyphicon glyphicon-ok-circle"></span>
                    </a>
                </td>
                <td class="text-center">
                    <a href="#">
                        <span class="glyphicon glyphicon-ok-circle"></span>
                    </a>
                </td>
            </tr>
        </table>
    </div>
    <div class="text-center submit-main">
        <button class="btn btn-success">
            <span class="glyphicon glyphicon-ok"></span>
            <span>Guardar Salida</span>
        </button>
    </div>
</asp:Content>
