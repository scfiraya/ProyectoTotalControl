<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ListadoFichas.aspx.cs" Inherits="WebTotalControl.Views.ListadoFichas" EnableEventValidation="false" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <h2>Listado Fichas </h2>
   <div>
       <asp:GridView ID="gvListas" runat="server" AutoGenerateColumns="false" HeaderStyle-BackColor="WhiteSmoke" RowStyle-HorizontalAlign="Justify" DataKeyNames="IdFicha,NumeroFicha,Ambiente,NombrePrograma" SelectedRowStyle-BackColor="#ff3399">
           <Columns>
               <asp:TemplateField  HeaderText="Seleccionar">
                        <ItemTemplate>
                            <asp:ImageButton ImageUrl="../Image/editarficha.gif" AlternateText="Editar"  runat="server"  OnClick="gvListas_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
              

               <asp:BoundField HeaderText="Número de Ficha" DataField="NumeroFicha" HeaderStyle-HorizontalAlign="Justify" />
                <asp:BoundField HeaderText="Programa" DataField="NombrePrograma" HeaderStyle-HorizontalAlign="Justify" />
               <asp:HyperLinkField DataNavigateUrlFields="IdFicha" DataNavigateUrlFormatString="DetalleFichas.aspx" HeaderText="Detalle" Text="Ver" DataTextFormatString="{0:c}" />
           </Columns>
       </asp:GridView>
       <asp:Label ID="lblPrueba" runat="server" Text=""></asp:Label>
   </div>
</asp:Content>
