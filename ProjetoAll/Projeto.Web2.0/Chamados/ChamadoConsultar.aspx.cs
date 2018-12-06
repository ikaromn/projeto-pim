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
    public partial class ChamadoConsultar : System.Web.UI.Page
    {
        UsuarioModel um = new UsuarioModel();
        ChamadosModel cm = new ChamadosModel();
        ChamadosBll cb = new ChamadosBll();

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
            List<ChamadosModel> listChamados = new List<ChamadosModel>();
            listChamados = cb.ConsultaTodosChamado(cm);

            GrdChamados.DataSource = listChamados;
            GrdChamados.DataBind();

        }

        protected void btnCarregar_Click(object sender, EventArgs e)
        {
            cm.IdChamado = Convert.ToInt32(txtIdCha.Text);

            List<ChamadosModel> listChamados = new List<ChamadosModel>();
            listChamados = cb.ConsultaChamado(cm);

            GrdChamados.DataSource = listChamados;
            GrdChamados.DataBind();

        }

        /// <summary>
        /// Evento de criacao da linha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GrdChamados_RowCreated(object sender, GridViewRowEventArgs e)
        {

            e.Row.Cells[1].Visible = false; // id dddd
            e.Row.Cells[2].Visible = false;
            e.Row.Cells[3].Visible = false;
            //e.Row.Cells[4].Visible = false;
            e.Row.Cells[5].Visible = false;
            e.Row.Cells[7].Visible = false;

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.DataItem != null)
                {
                    ChamadosModel cm = (ChamadosModel)e.Row.DataItem;

                    HyperLink hl = (HyperLink)e.Row.Cells[0].Controls[0];

                    hl.ID = string.Concat("hl_", cm.IdChamado.ToString()); ;
                    hl.NavigateUrl = string.Concat(@"~/Chamados/ChamadoDetalhe.aspx?IdChamado=", cm.IdChamado); //~/Chamados/ChamadoDetalhe.aspx
                    hl.Text = cm.IdChamado.ToString();
                    hl.Attributes.Add("width", "20%");
                    hl.Target = "_blank";

                }
            }

        }

        protected void GrdChamados_PreRender(object sender, EventArgs e)
        {
            //try
            //{
            //    this.GrdChamados.HeaderRow.TableSection = TableRowSection.TableHeader;
            //}
            //catch (Exception)
            //{
            //    throw;
            //}


        }
    }
}
