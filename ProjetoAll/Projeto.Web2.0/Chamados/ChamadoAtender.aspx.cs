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
    public partial class ChamadoAtender : System.Web.UI.Page
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

            this.Title = "Atender Chamado: " + Idchamado.ToString();

        }

        protected void btnAten_Click(object sender, EventArgs e)
        {
            try
            {
                cm.IdChamado = (int)HttpContext.Current.Session["IdChamado"];
                cm.Operador = "Operador 1";

                cb.AtenderChamado(cm);

                Response.Write("<script> confirm('Chamado em atendimento!!')</script>");
                //var Direcionar = "ChamadoDetalhe.aspx?IdChamado=" + cm.IdChamado.ToString();
                //Response.Redirect(Direcionar);
            }
            catch
            {
                Response.Write("<script>alert('Ocorreu um Erro!! Contate o suporte!!')</script>");
            }
            finally
            {

            }

        }

        protected void btnVolt_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Chamados/ChamadoDetalhe.aspx?IdChamado=" + cm.IdChamado);
        }
    }
}