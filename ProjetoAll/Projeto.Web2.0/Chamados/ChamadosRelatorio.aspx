<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChamadosRelatorio.aspx.cs" Inherits="Projeto.Web2._0.Chamados.ChamadosRelatorio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/><br/>
    <div style="border:solid 2px">
            Monte o seu Relatório Sobre chamados<br/>
            <asp:DropDownList ID="Filtro" runat="server">
                <asp:ListItem Value="0">Selecione uma Opcao</asp:ListItem>
                <asp:ListItem Value="1">Operadores</asp:ListItem>
                <asp:ListItem Value="2">Clientes</asp:ListItem>
                <asp:ListItem Value="3">Empresa</asp:ListItem>
            </asp:DropDownList>&nbsp&nbsp&nbsp&nbsp
            <asp:DropDownList ID="Coluna" runat="server"></asp:DropDownList>&nbsp&nbsp&nbsp&nbsp
            <br/>
            <asp:Button ID="Button1" runat="server" Text="Carregar Relatório" OnClick="Button1_Click" CssClass="btn btn-outline-dark" />
            
            <asp:Button ID="btnExcel" runat="server" Text="Exportar Excel" OnClick="btnExcel_Click" CssClass="btn btn-outline-dark" />
     </div>
     <br/>
     <asp:GridView ID="GridRel" runat="server" OnSelectedIndexChanged="GridRel_SelectedIndexChanged" 
         OnRowCreated="GridRel_RowCreated" CssClass="table table-hover table-striped" UseAccessibleHeader="true" OnPreRender="GridRel_PreRender">
     </asp:GridView>
    
</asp:Content>
