<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChamadoConsultar.aspx.cs" Inherits="Projeto.Web2._0.Chamados.ChamadoConsultar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/><br/>
    <div>
            <asp:Label ID="lblId" runat="server" Text="Digite o Id do Chamado"></asp:Label>
            <asp:TextBox ID="txtIdCha" runat="server"></asp:TextBox><br/>
            <asp:Button ID="btnCarregar" runat="server" Text="Carregar" OnClick="btnCarregar_Click" /><br/><br/><br/>
            <br/>
            <asp:GridView ID="GrdChamados" runat="server" style="border-radius:20px" OnRowCreated="GrdChamados_RowCreated" CssClass="table table-hover table-striped" UseAccessibleHeader="true" OnPreRender="GrdChamados_PreRender" >
                <Columns>
                    <asp:HyperLinkField HeaderText="Nr. chamado" NavigateUrl="~/Chamados/ChamadoDetalhe.aspx" Text="0" />
                </Columns>
            </asp:GridView><br/>
            
    </div>
</asp:Content>
