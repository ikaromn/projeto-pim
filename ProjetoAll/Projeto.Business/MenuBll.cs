using Projeto.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Business
{
    public class MenuBll
    {
        LoginDao ld = new LoginDao();

        public string MenuMontar2(int UsuarioMenu, string usuario)
        {
            string ret = "";

            if (UsuarioMenu == 1)
            {
               // ret = "<ul>" +
               //   "<li><a href = " + "#home" + " > Home </a></li>" +
               //      "<li><a href = " + "#news" + " > News </a></li>" +
               //         "<li class=" + "dropdown" + ">" +
               //     "<a href = " + "javascript:void(0)" + " class=" + "dropbtn" + ">Dropdown</a>" +
               //     "<div class=" + "dropdown-content" + ">" +
               //       "<a href = " + "#" + " > Link 1</a>" +
               //       "<a href = " + "#" + " > Link 2</a>" +
               //       "<a href = " + "#" + " > Link 3</a>" +
               //     "</div>" +
               //   "</li>" +
               //"</ul>";

                ret =
                    "<ul>" +
                    "   <li><A class=" + "active" + " href=" + "#" + ">Home</A></li>" +
                    //"   <li><A href=" + "#" + ">Minha Conta</A></li>" +
                    "   <li><A href=" + "ChamadoConsultar.aspx" + ">Consultar Chamado</A></li>" +
                    "   <li><A href=" + "ChamadoAbrir.aspx" + ">Abrir Chamado</A></li>" +
                    "   <li><A href=" + "#" + ">Abrir Chamado Urgente</A></li>" +
                    "   <li style=" + "float:right" + "><A href=" + "#" + ">Sair</A></li>" +
                    "   <li style=" + "float:right" + "><A href=" + "#" + ">"+usuario+"</A></li>" +
                    "</ul>";
            }

            else if (UsuarioMenu == 2)
            {
                ret =
                    "<ul>" +
                    "   <li><A class=" + "active" + " href=" + "#" + ">Home</A></li>" +
                    "   <li><A href=" + "ChamadoConsultar.aspx" + ">Consultar Chamado</A></li>" +
                    "   <li><A href=" + "ChamadoAbrir.aspx" + ">Abrir Chamado</A></li>" +
                    "   <li><A href=" + "#" + ">Painel de Chamados</A></li>" +
                    "   <li><A href=" + "UsuariosAll.aspx" + ">Usuários</A></li>" +
                    "   <li style=" + "float:right" + "><A href=" + "#" + ">" + usuario + "</A></li>" +
                    "   <li style=" + "float:right" + "><A href=" + "#" + ">Sair</A></li>" +
                    "</ul>";
            }

            else if (UsuarioMenu == 3)
            {
                ret =
                    "<ul>" +
                    "   <li><A class=" + "active" + " href=" + "#" + ">Home</A></li>" +
                    "   <li><A href=" + "ChamadoConsultar.aspx" + ">Consultar Chamado</A></li>" +
                    "   <li><A href=" + "ChamadoAbrir.aspx" + ">Abrir Chamado</A></li>" +
                    "   <li><A href=" + "#" + ">Painel de Chamados</A></li>" +
                    "   <li><A href=" + "#" + ">Usuários</A></li>" +
                    "   <li><A href=" + "#" + ">Acompanhamento Equipe</A></li>" +
                    "   <li style=" + "float:right" + "><A href=" + "#" + ">Sair</A></li>" +
                    "   <li style=" + "float:right" + "><A href=" + "#" + ">" + usuario + "</A></li>" +
                    "</ul>";
            }
            else if (UsuarioMenu == 4)
            {
                ret =
                    "<ul>" +
                    "   <li><A class=" + "active" + " href=" + "#" + ">Home</A></li>" +
                    "   <li><A href=" + "#" + ">Minha Conta</A></li>" +
                    "   <li><A href=" + "ChamadoConsultar.aspx" + ">Consultar Chamado</A></li>" +
                    "   <li><A href=" + "ChamadoAbrir.aspx" + ">Abrir Chamado</A></li>" +
                    "   <li><A href=" + "#" + ">Abrir Chamado Urgente</A></li>" +
                    "   <li><A href=" + "#" + ">Painel de Chamados</A></li>" +
                    "   <li><A href=" + "#" + ">Usuários</A></li>" +
                    "   <li><A href=" + "Relatorios.aspx" + ">Relatório</A></li>" +
                    "   <li style=" + "float:right" + "><A href=" + "#" + ">Sair</A></li>" +
                    "   <li style=" + "float:right" + "><A href=" + "#" + ">" + usuario + "</A></li>" +
                    "</ul>";
            }
            else if (UsuarioMenu==5)
                {
                ret =
                    "<ul>" +
                    "   <li><A href=" + "ChamadoAtender.aspx" + ">Atender Chamado</A></li>" +
                    "   <li><A href=" + "ChamadoAlterar.aspx" + ">Editar Chamado</A></li>" +
                    "   <li><A href=" + "ChamadoFinalizar.aspx" + ">Finalizar Chamado</A></li>" +
                    "   <li style=" + "float:right" + "><A href=" + "#" + ">Sair</A></li>" +
                    "</ul>";
            }


            return ret;
        }

        public string MontarMenu(int funcao)
        {
            string menu = "";
            try
            {
                menu=ld.MontarMenu(funcao);
            }
            catch (Exception)
            {

                throw;
            }

            return menu;
        }
    }


}
