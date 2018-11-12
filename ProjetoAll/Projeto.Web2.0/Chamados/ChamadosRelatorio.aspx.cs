using Projeto.Business;
using Projeto.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto.Web2._0.Chamados
{
    public partial class ChamadosRelatorio : System.Web.UI.Page
    {
        ChamadosModel cm = new ChamadosModel();
        ChamadosBll cb = new ChamadosBll();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExcel_Click(object sender, EventArgs e)
        {
            ExportGridToExcel();
        }

        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        public void ExportGridToExcel()
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AppendHeader("content-disposition", "attachment; filename=ListaChamados.xls");
            Response.Charset = "";
            Response.ContentType = "application/vnd.ms-excel";

            using (var sw = new StringWriter())
            {
                var hw = new HtmlTextWriter(sw);

                GridRel.AllowPaging = false;
                BindGrid();

                foreach (GridViewRow row in GridRel.Rows)
                {
                    foreach (Control rowControl in row.Controls)
                        PrepareControlForExport(rowControl);
                }

                GridRel.RenderControl(hw);

                //Response.Write(@"<style> .textmode { } </style>");
                var headerHtml = sw.ToString()
                    .Substring(sw.ToString().Substring(0, sw.ToString().IndexOf("<th", StringComparison.Ordinal)).Length,
                    sw.ToString().LastIndexOf("</th>", StringComparison.Ordinal) + 9 - sw.ToString().Substring(0, sw.ToString().IndexOf("<th", StringComparison.Ordinal)).Length);

                var header = new StringBuilder();

                header.Append("<th style='background-color: green; color:white;'> Id Chamado </th>");
                header.Append("<th style='background-color: green; color:white;'> Problema </th>");
                header.Append("<th style='background-color: green; color:white;'> Area </th>");
                header.Append("<th style='background-color: green; color:white;'> Empresa </th>");
                header.Append("<th style='background-color: green; color:white;'> Descricao </th>");
                header.Append("<th style='background-color: green; color:white;'> Status </th>");
                header.Append("<th style='background-color: green; color:white;'> Data Abertura </th>");
                header.Append("<th style='background-color: green; color:white;'> Data Fechamento </th>");
                header.Append("<th style='background-color: green; color:white;'> Telefone </th>");
                header.Append("<th style='background-color: green; color:white;'> Operador </th>");
                header.Append("<th style='background-color: green; color:white;'> Mensagem Final </th>");



                var htmlFinal = sw.ToString().Replace(headerHtml, header.ToString());
                htmlFinal = htmlFinal.Substring(5);
                htmlFinal = htmlFinal.Substring(0, htmlFinal.Length - 6);

                Response.Output.Write(htmlFinal);
                Response.Flush();
                Response.End();

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            List<ChamadosModel> listChamados = new List<ChamadosModel>();
            listChamados = cb.ConsultaTodosChamado(cm);

            GridRel.DataSource = listChamados;
            GridRel.DataBind();
        }

        private static void PrepareControlForExport(Control control)
        {
            for (var i = 0; i < control.Controls.Count; i++)
            {
                var current = control.Controls[i];
                if (current is TextBox)
                {
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl((current as TextBox).Text));
                }
                else if (current is LinkButton)
                {
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl((current as LinkButton).Text));
                }
                else if (current is ImageButton)
                {
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl((current as ImageButton).AlternateText));
                }
                else if (current is HyperLink)
                {
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl((current as HyperLink).Text));
                }
                else if (current is DropDownList)
                {
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl((current as DropDownList).SelectedIndex > 0 ? (current as DropDownList).SelectedItem.Text : string.Empty));
                }
                else if (current is CheckBox)
                {
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl((current as CheckBox).Checked ? "Verdadeiro" : "Falso"));
                }
                else if (current is HiddenField)
                {
                    control.Controls.Remove(current);
                }

                if (current.HasControls())
                {
                    PrepareControlForExport(current);
                }
            }
        }

        protected void GridRel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridRel_RowCreated(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Visible = false; // id dddd
            e.Row.Cells[2].Visible = false;
            e.Row.Cells[3].Visible = false;
            //e.Row.Cells[4].Visible = false;
            e.Row.Cells[5].Visible = false;
            e.Row.Cells[7].Visible = false;
        }

        protected void GridRel_PreRender(object sender, EventArgs e)
        {
            if (GridRel.DataSource!=null)
            try
            {
                this.GridRel.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}