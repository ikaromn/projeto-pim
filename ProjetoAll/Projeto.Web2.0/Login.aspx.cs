using Projeto.Business;
using Projeto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto.Web2._0
{
    public partial class Login : System.Web.UI.Page
    {
        private LoginBll lb = new LoginBll();
        private UsuarioModel um = new UsuarioModel();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEntrar_Click(object sender, EventArgs e)
        {

            um.Usuario = "Cliente";
            um.Senha = "cli123";
            um.IdFuncao = 4;

            Session.Add("UsuarioLogado", um);

            Response.Redirect("Default.aspx");
            //Response.Redirect("Teste.html");

            //if (lb.FazerLogin() == true)
            //{
            //um.Usuario = "Cliente";
            //um.Senha = "cli123";
            //um.IdFuncao = 2;

            //Session.Add("UsuarioLogado", um);

            //Response.Redirect("MenuPrincipal.aspx");
            //}
            //else
            //{
            //Response.Write("<script>window.alert('Usuário ou senha incorretos')</script>");
            //}
        }
    }
}