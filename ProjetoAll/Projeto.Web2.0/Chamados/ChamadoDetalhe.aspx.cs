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
    public partial class ChamadoDetalhe : System.Web.UI.Page
    {
        ChamadosModel cm = new ChamadosModel();
        ChamadosBll cb = new ChamadosBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            ChamadosModel cm = new ChamadosModel();
            ChamadosBll cb = new ChamadosBll();
            List<ChamadosModel> listaChamado = new List<ChamadosModel>();

            int idChamado = 0;
            int.TryParse(Request.QueryString["idChamado"], out idChamado);

            cm.IdChamado = idChamado;
            listaChamado = cb.ConsultaChamado(cm);

            rptChamado.DataSource = listaChamado;
            rptChamado.DataBind();

            this.Title = "Detalhe Chamado: " + idChamado.ToString();

            Session.Add("IdChamado", idChamado);

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAtender_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Chamados/ChamadoAtender.aspx?IdChamado=" + cm.IdChamado);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Chamados/ChamadoAlterar.aspx?IdChamado=" + cm.IdChamado);
        }

        protected void btnFinalizar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Chamados/ChamadoFinalizar.aspx?IdChamado=" + cm.IdChamado);
        }
    }
}