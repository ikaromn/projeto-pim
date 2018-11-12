<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChamadoDetalhe.aspx.cs" Inherits="Projeto.Web2._0.Chamados.ChamadoDetalhe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/><br/>
    <div style="border:solid" >
            <center>
            <asp:Repeater ID="rptChamado" runat="server">
            <itemtemplate>
                <%--<div class="row">
                <center>
                <div class="col-md-2">
                    <div class="input-group">
                        <div class="input-group-addon">Chamado</div>
                    <asp:TextBox ID="txtval6" runat="server" CssClass="form-control" Text='<%#DataBinder.Eval(Container, "DataItem.IdChamado") %>'></asp:TextBox>
                    </div>

                    <div class="col-lg-9 col-md-8">
                        <div class="input-group">
                            <div class="input-group-addon">Problema</div>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" Text='<%#DataBinder.Eval(Container, "DataItem.Problema") %>'></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-lg-9 col-md-3 control-label">
                        <asp:Label ID="Label11" runat="server" Text="Chamado"></asp:Label>
                    </div>
                    <div class="col-lg-9 col-md-8">
                        <%--<asp:TextBox ID="txtval6" runat="server" CssClass="form-control" Text='<%#DataBinder.Eval(Container, "DataItem.IdChamado") %>'></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-2">
                    <div class="col-lg-9 col-md-3 control-label">
                        <asp:Label ID="Label12" runat="server" Text="Problema"></asp:Label>
                    </div>
                    <div class="col-lg-9 col-md-8">
                        <asp:TextBox ID="txtval7" runat="server" CssClass="form-control" Text='<%#DataBinder.Eval(Container, "DataItem.Problema") %>'></asp:TextBox>
                    </div>
                </div>
                </center>
                </div><br/>

                <div class="row">
                <center>
                <div class="col-md-2">
                    <div class="col-lg-9 col-md-3 control-label">
                        <asp:Label ID="Label1" runat="server" Text="Area"></asp:Label>
                    </div>
                    <div class="col-lg-9 col-md-8">
                        <asp:TextBox ID="TextBox1" runat="server" Enabled="false" CssClass="form-control" Text='<%#DataBinder.Eval(Container, "DataItem.Area") %>'></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-2">
                    <div class="col-lg-9 col-md-3 control-label">
                        <asp:Label ID="Label2" runat="server" Text="Empresa"></asp:Label>
                    </div>
                    <div class="col-lg-9 col-md-8">
                        <asp:TextBox ID="TextBox9" runat="server" Enabled="false" CssClass="form-control" Text='<%#DataBinder.Eval(Container, "DataItem.Empresa") %>'></asp:TextBox>
                    </div>
                </div>
                </center>
                </div><br/>

                <asp:Label ID="Label13" runat="server" Text="Descricao:"></asp:Label>&nbsp<br/><asp:TextBox ID="TextBox11" runat="server" Height="100px" Width="300px" CssClass="form-control input-lg" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.Descricao") %>'></asp:TextBox><br/>
                
                <div class="row">
                <center>
                <div class="col-md-2">
                    <div class="col-lg-9 col-md-3 control-label">
                        <asp:Label ID="Label14" runat="server" Text="Solicitante"></asp:Label>
                    </div>
                    <div class="col-lg-9 col-md-8">
                        <asp:TextBox ID="TextBox12" runat="server" Enabled="false" CssClass="form-control" Text='<%#DataBinder.Eval(Container, "DataItem.Solicitante") %>'></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-2">
                    <div class="col-lg-9 col-md-3 control-label">
                        <asp:Label ID="Label15" runat="server" Text="Status"></asp:Label>
                    </div>
                    <div class="col-lg-9 col-md-8">
                        <asp:TextBox ID="TextBox13" runat="server" Enabled="false" CssClass="form-control" Text='<%#DataBinder.Eval(Container, "DataItem.Status") %>'></asp:TextBox>
                    </div>
                </div>
                </center>
                </div><br/>

                <div class="row">
                <center>
                <div class="col-md-2">
                    <div class="col-lg-9 col-md-3 control-label">
                        <asp:Label ID="Label16" runat="server" Text="Telefone"></asp:Label>
                    </div>
                    <div class="col-lg-9 col-md-8">
                        <asp:TextBox ID="TextBox14" runat="server" Enabled="false" CssClass="form-control" Text='<%#DataBinder.Eval(Container, "DataItem.TelefoneContato") %>'></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-2">
                    <div class="col-lg-9 col-md-3 control-label">
                        <asp:Label ID="Label17" runat="server" Text="Operador"></asp:Label>
                    </div>
                    <div class="col-lg-9 col-md-8">
                        <asp:TextBox ID="TextBox15" runat="server" Enabled="false" CssClass="form-control" Text='<%#DataBinder.Eval(Container, "DataItem.Operador") %>'></asp:TextBox>
                    </div>
                </div>
                </center>
                </div><br/>
                <asp:Label ID="Label18" runat="server"  Text="Ultima Mensagem:"></asp:Label>&nbsp<br/><asp:TextBox ID="TextBox16" runat="server" CssClass="form-control input-lg" Height="50px" Width="250px" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.MensagemAlt") %>'></asp:TextBox><br/>--%>

                <asp:Label ID="Label1" runat="server" Text="Chamado:"></asp:Label>&nbsp <asp:TextBox ID="TextBox1" runat="server" Enabled="false" CssClass="form-control input-lg" Text='<%#DataBinder.Eval(Container, "DataItem.IdChamado") %>'></asp:TextBox>
                <asp:Label ID="Label2" runat="server"  Text="Problema:"></asp:Label>&nbsp<asp:TextBox ID="TextBox9" runat="server" Enabled="false" CssClass="form-control input-lg"  Text='<%#DataBinder.Eval(Container, "DataItem.Problema") %>'></asp:TextBox><br/>
                <asp:Label ID="Label3" runat="server" Text="Area:"></asp:Label>&nbsp<asp:TextBox ID="TextBox7" runat="server" Enabled="false" CssClass="form-control input-lg" Text='<%#DataBinder.Eval(Container, "DataItem.Area") %>'></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Text="Empresa:"></asp:Label>&nbsp<asp:TextBox ID="TextBox8" runat="server" Enabled="false" CssClass="form-control input-lg" Text='<%#DataBinder.Eval(Container, "DataItem.Empresa") %>'></asp:TextBox><br/>
                <asp:Label ID="Label5" runat="server" Text="Descricao:"></asp:Label>&nbsp<br/><asp:TextBox ID="TextBox2" runat="server" Height="100px" Width="300px" CssClass="form-control input-lg" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.Descricao") %>'></asp:TextBox><br/>
                <asp:Label ID="Label6" runat="server" Text="Solicitante:"></asp:Label>&nbsp<asp:TextBox ID="TextBox3" runat="server" Enabled="false" CssClass="form-control input-lg"  Text='<%#DataBinder.Eval(Container, "DataItem.Solicitante") %>'></asp:TextBox>
                <asp:Label ID="Label7" runat="server" Text="Status:"></asp:Label>&nbsp<asp:TextBox ID="TextBox10" runat="server" Enabled="false"  CssClass="form-control input-lg" Text='<%#DataBinder.Eval(Container, "DataItem.Status") %>'></asp:TextBox><br/>
                <asp:Label ID="Label8" runat="server" Text="Telefone:"></asp:Label>&nbsp<asp:TextBox ID="TextBox4" runat="server" Enabled="false" CssClass="form-control input-lg" Text='<%#DataBinder.Eval(Container, "DataItem.TelefoneContato") %>'></asp:TextBox>
                <asp:Label ID="Label9" runat="server" Text="Operador:"></asp:Label>&nbsp<asp:TextBox ID="TextBox5" runat="server" Enabled="false" CssClass="form-control input-lg" Text='<%#DataBinder.Eval(Container, "DataItem.Operador") %>'></asp:TextBox><br/>
                <asp:Label ID="Label10" runat="server"  Text="Ultima Mensagem:"></asp:Label>&nbsp<br/><asp:TextBox ID="TextBox6" runat="server" CssClass="form-control input-lg" Height="50px" Width="250px" Enabled="false" Text='<%#DataBinder.Eval(Container, "DataItem.MensagemAlt") %>'></asp:TextBox><br/>

            </itemtemplate>
        </asp:Repeater>
        </center>
        <center>
            <asp:Button ID="btnAtender" runat="server" Text="Atender" CssClass="btn btn-primary" OnClick="btnAtender_Click" />&nbsp&nbsp&nbsp&nbsp
            <asp:Button ID="btnAlterar" runat="server" Text="Alterar" CssClass="btn btn-primary" OnClick="btnAlterar_Click" />&nbsp&nbsp&nbsp&nbsp
            <asp:Button ID="btnFinalizar" runat="server" Text="Encerrar" CssClass="btn btn-primary" OnClick="btnFinalizar_Click" />
        </center>
    </div>
</asp:Content>
