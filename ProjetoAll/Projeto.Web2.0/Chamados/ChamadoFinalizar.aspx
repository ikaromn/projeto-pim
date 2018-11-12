<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChamadoFinalizar.aspx.cs" Inherits="Projeto.Web2._0.Chamados.ChamadoFinalizar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/><br/>
    <div style="border:solid 2px" runat="server">
        <center>
            <asp:Repeater ID="rptChamado" runat="server">
                <itemtemplate>
                    <asp:Label ID="Label1" runat="server" Text="Chamado:"></asp:Label>&nbsp
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.IdChamado") %>'></asp:TextBox>
                    <asp:Label ID="Label2" runat="server"  Text="Problema:"></asp:Label>&nbsp
                    <asp:TextBox ID="TextBox9" runat="server" CssClass="form-control input-lg" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.Problema") %>'></asp:TextBox><br/>
                    <asp:Label ID="Label3" runat="server" Text="Area:"></asp:Label>&nbsp
                    <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control input-lg" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.Area") %>'></asp:TextBox>
                    <asp:Label ID="Label4" runat="server" Text="Empresa:"></asp:Label>&nbsp
                    <asp:TextBox ID="TextBox8" runat="server" CssClass="form-control input-lg" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.Empresa") %>'></asp:TextBox><br/>
                    <asp:Label ID="Label5" runat="server" Text="Descricao:"></asp:Label>&nbsp
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control input-lg" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.Descricao") %>'></asp:TextBox><br/>
                    <asp:Label ID="Label6" runat="server" Text="Solicitante:"></asp:Label>&nbsp
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control input-lg" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.Solicitante") %>'></asp:TextBox>
                    <asp:Label ID="Label7" runat="server" Text="Status:"></asp:Label>&nbsp
                    <asp:TextBox ID="TextBox10" runat="server" CssClass="form-control input-lg" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.Status") %>'></asp:TextBox><br/>
                    <asp:Label ID="Label8" runat="server" Text="Telefone:"></asp:Label>&nbsp
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control input-lg" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.TelefoneContato") %>'></asp:TextBox>
                    <asp:Label ID="Label9" runat="server" Text="Operador:"></asp:Label>&nbsp
                    <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control input-lg" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.Operador") %>'></asp:TextBox><br/>
                    <asp:Label ID="Label10" runat="server" Text="Ultima Mensagem:"></asp:Label>&nbsp
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control input-lg" Text='<%#DataBinder.Eval(Container, "DataItem.MensagemAlt") %>'></asp:TextBox><br/>
                </itemtemplate>
            </asp:Repeater>
        </center>
        <center>
        <asp:Button ID="btnFinal" runat="server" Text="Finalizar Chamado" OnClick="btnFinal_Click" CssClass="btn btn-primary"/>
         &nbsp&nbsp
         &nbsp&nbsp
        <asp:Button ID="btnVolt" runat="server" Text="Voltar" CssClass="btn btn-primary" OnClick="btnVolt_Click" /><br/>
        
        </center>
        </div>
</asp:Content>
