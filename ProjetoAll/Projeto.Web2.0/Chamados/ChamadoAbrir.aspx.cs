using Projeto.Business;
using Projeto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto.Web2._0.Chamados
{
    public partial class ChamadoAbrir : System.Web.UI.Page
    {
        UsuarioModel um = new UsuarioModel();
        ChamadosModel cm = new ChamadosModel();
        ChamadosBll cb = new ChamadosBll();
        ComboboxBll cbb = new ComboboxBll();

        public class Sessao
        {
            public static UsuarioModel UsuarioLogado
            {
                get
                {
                    return (HttpContext.Current.Session["UsuarioLogado"] == null) ? null :
                        (UsuarioModel)HttpContext.Current.Session["UsuarioLogado"];
                }
                set
                {
                    HttpContext.Current.Session["UsuarioLogado"] = value;
                }
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            cmbArea.DataSource = cbb.PreencheCombo(1);
            cmbArea.DataValueField = "idArea";
            cmbArea.DataTextField = "Area";
            cmbArea.DataBind();

            cmbProblema.DataSource = cbb.PreencheCombo(3);
            cmbProblema.DataValueField = "IdEmpresa";
            cmbProblema.DataTextField = "Empresa";
            cmbProblema.DataBind();

            cmbEmpresa.DataSource = cbb.PreencheCombo(3);
            cmbEmpresa.DataValueField = "IdEmpresa";
            cmbEmpresa.DataTextField = "Empresa";
            cmbEmpresa.DataBind();


        }

        protected void btnAbrir_Click(object sender, EventArgs e)
        {
            cm.IdProblema = Convert.ToInt32(cmbProblema.SelectedValue);
            cm.IdArea = Convert.ToInt32(cmbArea.SelectedValue);
            cm.IdEmpresa = Convert.ToInt32(cmbEmpresa.SelectedValue);
            cm.Descricao = txtDes.Text;

            if (txtSol.Text == "")
            {
                cm.Solicitante = Sessao.UsuarioLogado.Usuario;
            }
            else
            {
                cm.Solicitante = txtSol.Text;
            }

            cm.TelefoneContato = Convert.ToInt64(txtTel.Text);

            try
            {
                cb.AbrirChamado(cm);
                Response.Write("<script>alert('Chamado Aberto com Sucesso Numero:3')</script>");
            }
            catch
            {
            }
            finally
            {
                Limpar();
            }

        }
        protected void Limpar()
        {
            cmbProblema.SelectedValue = "0";
            cmbArea.SelectedValue = "0";
            cmbEmpresa.SelectedValue = "0";
            txtSol.Text = "";
            txtDes.Text = "";
            txtTel.Text = "";
        }


        protected void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbProblema.DataSource = cbb.PreencheCombo(2, 1);
            //cmbProblema.DataValueField = "idProblema";
            //cmbProblema.DataTextField = "Problema";
            //cmbProblema.DataBind();
        }
    }
}