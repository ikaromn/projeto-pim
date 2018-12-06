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
    public partial class ChamadoAbrir : Form
    {
        UsuarioModel um = new UsuarioModel();
        ChamadosModel cm = new ChamadosModel();
        ChamadosBll cb = new ChamadosBll();
        ComboboxBll cbb = new ComboboxBll();

        public ChamadoAbrir()
        {
            //cmbArea.DataSource = cbb.PreencheCombo(1);
            //cmbArea.ValueMember= "idArea";
            //cmbArea.DataTextField = "Area";
            //cmbArea.DataBind();

            //cmbProblema.DataSource = cbb.PreencheCombo(1);
            //cmbProblema.DataValueField = "idArea";
            //cmbProblema.DataTextField = "Area";
            //cmbProblema.DataBind();

            //cmbEmpresa.DataSource = cbb.PreencheCombo(3);
            //cmbEmpresa.DataValueField = "IdEmpresa";
            //cmbEmpresa.DataTextField = "Empresa";
            //cmbEmpresa.DataBind();

            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
