<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Projeto.Web2._0._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
    <h1>Seja Bem vindo ao HelpDesk Inc</h1>
    </div>
    <%--<div class="jumbotron">
        <h1>Seja Bem vindo ao HelpDesk Inc</h1>
        <p>Selecione o que deseja fazer:</p>
    </div>--%>

    <%--<div class="w3-container w3-center w3-animate-opacity">--%>
    
        <div class="row">
            <div class = "animated fadeIn" >
                <div class="col-md-4" id="Op1">
                    <asp:Image ID="Image1" runat="server"/>
                    <h2>Minha conta</h2>
                    <p>
                      Defina agora suas Preferências
                    </p>
                    <p>
                        Ir para a minha conta!! lorem ipsum lorem ipsulum lorem ipsulum
                    </p>
                    <p>
                        <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Minha conta &raquo;</a>
                    </p>
                </div>
            </div>
            <div class = "animated2 fadeIn">
                <div class="col-md-4" id="Op2" >
                    <h2>Chamados</h2>
                    <p>
                        Tem um problema? Nós podemos ajuda-lo.  
                    </p>
                    <p>
                        Abra agora um chamado para um de nossos Técnicos   
                    </p>
                    <p>
                        <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Ir para Chamados &raquo;</a>
                    </p>
                </div>
            </div>
            <div class = "animated3 fadeIn">
                <div class="col-md-4" id="Op3" >
                    <h2>Sobre a Help Desk Inc</h2>
                    <p>
                        Descubra um pouco sobre a empresa e por Todos os serviços que são fornecidos...
                    </p>
                    <p>
                        <a class="btn btn-default" href="About.aspx">Ir para Sobre &raquo;</a>
                    </p>
                </div>
            </div>
        </div>
    
    <%--</div>--%>

</asp:Content>
