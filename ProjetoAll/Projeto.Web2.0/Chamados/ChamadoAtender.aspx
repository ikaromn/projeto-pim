<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChamadoAtender.aspx.cs" Inherits="Projeto.Web2._0.Chamados.ChamadoAtender" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/><br/>
    <div style="border:solid 2px">
            <center>
            <asp:Repeater ID="rptChamado" runat="server">
            <itemtemplate>
                <asp:Label ID="Label1" runat="server" Text="Chamado:"></asp:Label>&nbsp
                <asp:TextBox ID="TextBox1" CssClass="form-control input-lg" runat="server" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.IdChamado") %>'></asp:TextBox>
                <asp:Label ID="Label2" runat="server"  Text="Problema:"></asp:Label>&nbsp
                <asp:TextBox ID="TextBox9" runat="server" CssClass="form-control input-lg" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.Problema") %>'></asp:TextBox><br/>
                <asp:Label ID="Label3" runat="server" Text="Area:"></asp:Label>&nbsp
                <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control input-lg" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.Area") %>'></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Text="Empresa:"></asp:Label>&nbsp
                <asp:TextBox ID="TextBox8" runat="server" CssClass="form-control input-lg" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.Empresa") %>'></asp:TextBox><br/>
                <asp:Label ID="Label5" runat="server" Text="Descricao:"></asp:Label>&nbsp
                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control input-lg" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.Descricao") %>'></asp:TextBox><br/>
                <asp:Label ID="Label6" runat="server" Text="Solicitante:"></asp:Label>&nbsp
                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control input-lg" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.Solicitante") %>'></asp:TextBox><br/>
                <asp:Label ID="Label7" runat="server" Text="Status:"></asp:Label>&nbsp
                <asp:TextBox ID="TextBox10" runat="server" CssClass="form-control input-lg" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.Status") %>'></asp:TextBox>
                <asp:Label ID="Label8" runat="server" Text="Telefone:"></asp:Label>&nbsp
                <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control input-lg" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.TelefoneContato") %>'></asp:TextBox><br/>
                <asp:Label ID="Label9" runat="server" Text="Operador:"></asp:Label>&nbsp
                <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control input-lg" Text='<%#DataBinder.Eval(Container, "DataItem.Operador") %>'></asp:TextBox><br/>
                <asp:Label ID="Label10" runat="server" Text="Ultima Mensagem:"></asp:Label>&nbsp
                <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control input-lg" Height="50px" Width="250px" Text="Chamado em Atendimento"></asp:TextBox><br/>
            </itemtemplate>
        </asp:Repeater>
        </center>
        <center>
            <!--OnClick="btnAten_Click"-->
            <asp:Button ID="btnAten" runat="server" Text="Atender Chamado" OnClick="btnAten_Click" OnClientClick="return confirm('Chamado em atendimento!!');" CssClass="btn btn-outline-dark"  />
             &nbsp&nbsp
             &nbsp&nbsp
            <asp:Button ID="btnVolt" runat="server" Text="Voltar" CssClass="btn btn-primary" OnClick="btnVolt_Click" /><br/>
        </center>
        </div>
</asp:Content>
