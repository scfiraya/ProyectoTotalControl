<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ListadoFichas.aspx.cs" Inherits="WebTotalControl.Views.ListadoFichas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <script type="text/javascript">
       function CheckOn(objRef) {

           var row = objRef.parentNode.parentNode;
           if (objRef.cheked) {
               row.style.backgroundcolor = "red";
           }
           else {
               row.style.backgroundcolor = "Write";
           }

           var gvListas = row.parentNode;
       }



   </script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <h2>Listado Fichas </h2>
   <div>
       <asp:GridView ID="gvListas" runat="server" AutoGenerateColumns="false" HeaderStyle-BackColor="WhiteSmoke" RowStyle-HorizontalAlign="Justify">
           <Columns>
               
               <asp:TemplateField>
                   <ItemTemplate>
                       <asp:CheckBox ID="CheckBox1" runat="server" Oneclick="chekOn(this)" />
                   </ItemTemplate>
               </asp:TemplateField>
               <asp:BoundField HeaderText="Número de Ficha" DataField="NumeroFicha" HeaderStyle-HorizontalAlign="Justify" />
               <asp:BoundField HeaderText="Programa de Formación" DataField="Nombre" />
               <asp:HyperLinkField DataNavigateUrlFields="IdFicha" DataNavigateUrlFormatString="DetalleFichas.aspx" HeaderText="Detalle" Text="Ver" DataTextFormatString="{0:c}" />

           </Columns>
       </asp:GridView>
       <div id="margin">
           <asp:Button ID="btnVer" runat="server" Text="VER" OnClick="btnVer_Click" />
           <asp:Label ID="lblIdgvListas" runat="server" Text=""></asp:Label>
       </div>
   </div>
</asp:Content>
