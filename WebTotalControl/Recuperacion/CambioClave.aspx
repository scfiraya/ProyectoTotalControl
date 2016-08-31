<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambioClave.aspx.cs" Inherits="WebTotalControl.Recuperacion.CambioClave" %>

<!DOCTYPE html> 

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/Style.css" rel="stylesheet" />
    <title>Cambio de contraseña</title>
</head>
<body class="clasee"> 
    <form id="form1" runat="server">
    
    <div id="Principal" class="container row form-horizontal text-center" runat="server">

        <div class="row">
            <div class="col-xs-12 col-md-offset-3 col-md-6">
                <img src="../Views/Image/total-control.png" class="img-responsive center-block" />
            </div>
        </div>

        <div id="Titulo">
            <h1><strong>Cambio de contraseña</strong></h1>    
        </div><hr /> <br />
         
            <div id="Paneles" class="container">

        <asp:Panel ID="pnlValidacion" runat="server" Visible="true">

            <div class="form-horizontal form-group" role="form">

                <div class="form-group">
                    <label class="col-lg-6 col-md-12 col-sm-12 control-label">Digita tu número de identificación</label>
                    <div class="col-lg-6 col-md-12 col-sm-12">
                        <asp:TextBox ID="txtCedula" placeholder="Número de cedula" runat="server" Width="357px" CssClass="form-control" required="required"></asp:TextBox>
                    </div>
                </div>

                    <div class="center-block form-group">

                        <asp:Button ID="btnValidar" runat="server" Text="Cambiar contraseña" class="btn btn-primary" OnClick="btnValidar_Click" />
                        <h4>
                            <asp:Label ID="lblError" runat="server" class="label label-info" Text="" CssClass="label label-warning"></asp:Label></h4>

                    </div>
                
            </div>

        </asp:Panel>
         

        <asp:Panel ID="pnlCambio" runat="server" Visible="false">

            <div class="form-horizontal" role="form">

                <div class="form-group">
                    <label class="col-lg-3 col-lg-offset-3 col-md-12 col-sm-12 control-label">Nueva contraseña</label>
                    <div class="col-lg-6 col-md-12 col-sm-12">
                        <asp:TextBox ID="txtNueva" placeholder="Nueva contraseña" runat="server" CssClass="form-control" type="password" required="required"></asp:TextBox>
                    </div>
                </div>
                     
                <div class="form-group">
                    <label class="col-lg-3 col-lg-offset-3 col-md-12 col-sm-12 control-label">Confirma tu contraseña</label>
                    <div class="col-lg-6 col-md-12 col-sm-12">
                        <asp:TextBox ID="txtConfirma" placeholder="Confirmar contraseña" runat="server" CssClass="form-control" type="password" required="required"></asp:TextBox>
                    </div>
                </div>

                <div class="center-block">

                    <asp:Button ID="btnCambiar" runat="server" Text="Cambiar contraseña" CssClass="btn btn-primary" OnClick="btnCambiar_Click" Width="225px" />

                    <h4><asp:Label ID="lblNovedad" runat="server" class="label label-info" Text="" CssClass="alert-danger"></asp:Label></h4>

                    <h4><asp:LinkButton ID="lbtIniciarSesion" runat="server" Visible="false" OnClick="lbtIniciarSesion_Click">Iniciar sesión</asp:LinkButton></h4>
                </div>

                </div>

        </asp:Panel>

            </div>

        </div>

        <footer class="container-fluid">
            <div class="row text-center">
                <h5>&copy; ADSI. 2016</h5>
            </div>
        </footer>

        <script src="../../Scripts/jquery-2.2.1.min.js"></script>
        <script src="../../Scripts/bootstrap.min.js"></script>
        
    </form>
</body>
</html>
