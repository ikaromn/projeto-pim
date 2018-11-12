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
    public partial class ChamadoFinalizar : System.Web.UI.Page
    {
        ChamadosModel cm = new ChamadosModel();
        ChamadosBll cb = new ChamadosBll();
        MenuBll mb = new MenuBll();


        protected void Page_Load(object sender, EventArgs e)
        {
            List<ChamadosModel> listaChamado = new List<ChamadosModel>();
            int Idchamado = (int)HttpContext.Current.Session["IdChamado"];

            cm.IdChamado = Idchamado;
            listaChamado = cb.ConsultaChamado(cm);

            rptChamado.DataSource = listaChamado;
            rptChamado.DataBind();

            this.Title = "Finalizar Chamado: " + Idchamado.ToString();

        }

        protected void btnFinal_Click(object sender, EventArgs e)
        {
            try
            {
                cm.MensagemFinal = "Mensagem Final";
                cm.Operador = "Operador 1";
                cm.IdChamado = cm.IdChamado;

                cb.FecharChamado(cm);
                Response.Write("<script> alert('Chamado " + cm.IdChamado + " Finalizado!!')</script>");
                //Response.Redirect("ChamadoDetalhe.aspx?IdChamado=" + cm.IdChamado);
            }
            catch
            {
                Response.Write("<script> window.alert('Ocorreu um Erro!! Contate o suporte!!')</script>");
            }

        }

        protected void btnVolt_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Chamados/ChamadoDetalhe.aspx?IdChamado=" + cm.IdChamado);
        }
    }
}