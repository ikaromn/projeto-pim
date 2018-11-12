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
    public partial class ChamadoAlterar : System.Web.UI.Page
    {
        ChamadosModel cm = new ChamadosModel();
        ChamadosBll cb = new ChamadosBll();


        protected void Page_Load(object sender, EventArgs e)
        {

            List<ChamadosModel> listaChamado = new List<ChamadosModel>();
            int Idchamado = (int)HttpContext.Current.Session["IdChamado"];

            cm.IdChamado = Idchamado;
            listaChamado = cb.ConsultaChamado(cm);

            rptChamado.DataSource = listaChamado;
            rptChamado.DataBind();

            this.Title = "Alterar Chamado: " + Idchamado.ToString();

        }

        protected void btnAlt_Click(object sender, EventArgs e)
        {
            try
            {


                cb.AlterarChamado(cm);
                Response.Write("<script> alert('Chamado alterado!!')</script>");
                Response.Redirect("ChamadoDetalhe.aspx?IdChamado=" + cm.IdChamado);

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