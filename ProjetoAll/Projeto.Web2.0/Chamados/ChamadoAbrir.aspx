<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChamadoAbrir.aspx.cs" Inherits="Projeto.Web2._0.Chamados.ChamadoAbrir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/><br/>
        <div style="border:solid 2px">
            <center>
                <h1>Abrir Chamado</h1>
                <asp:Label ID="lblEmp" runat="server" Text="Empresa:"></asp:Label>&nbsp
                <asp:DropDownList ID="cmbEmpresa" runat="server" CssClass="form-control">
                </asp:DropDownList><br/>
                <asp:Label ID="lblAre" runat="server" Text="Area:"></asp:Label>&nbsp
                <asp:DropDownList ID="cmbArea" runat="server" OnSelectedIndexChanged="cmbArea_SelectedIndexChanged" CssClass="form-control">
                </asp:DropDownList><br/>
                <asp:Label ID="lblPro" runat="server" Text="Problema:"></asp:Label>&nbsp
                <asp:DropDownList ID="cmbProblema"   runat ="server" CssClass="form-control" >
                </asp:DropDownList><br/><br/>
                <asp:Label ID="lblDes" runat="server" Text="Descricao"></asp:Label><br/>
                <asp:TextBox ID="txtDes" runat="server" Height="150px" Width="370px" CssClass="form-control input-lg" ></asp:TextBox><br/>
                <asp:Label ID="lblSol" runat="server" Text="Solicitante"></asp:Label><br/>
                <asp:TextBox ID="txtSol" runat="server" CssClass="form-control input-lg"></asp:TextBox><br/>
                <asp:Label ID="lblTel" runat="server" Text="Telefone"></asp:Label>
                <asp:TextBox ID="txtTel" runat="server" CssClass="form-control"></asp:TextBox><br/>

                <asp:Button ID="btnAbrir" runat="server" Text="Abrir Chamado" OnClick="btnAbrir_Click" CssClass="btn btn-primary" /><br/><br/>
            </center>
        </div>
</asp:Content>
