using Projeto.Business;
using Projeto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Desktop
{
    public partial class ChamadosConsultar : Form
    {
        UsuarioModel um = new UsuarioModel();
        ChamadosModel cm = new ChamadosModel();
        ChamadosBll cb = new ChamadosBll();

        public ChamadosConsultar()
        {
            InitializeComponent();
        }

        private void ChamadosConsultar_Load(object sender, EventArgs e)
        {
            List<ChamadosModel> listChamados = new List<ChamadosModel>();
            listChamados = cb.ConsultaTodosChamado(cm);

            GrdChamados.DataSource = listChamados;
        }

        private void GrdChamados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ChamadoDetalhe cd = new ChamadoDetalhe(1);
            cd.Show();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            List<ChamadosModel> listChamados = new List<ChamadosModel>();
            listChamados = cb.ConsultaTodosChamado(cm);

            GrdChamados.DataSource = listChamados;
        }
    }
}
