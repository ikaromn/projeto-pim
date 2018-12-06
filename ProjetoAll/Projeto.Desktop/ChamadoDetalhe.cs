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
    public partial class ChamadoDetalhe : Form
    {
        ChamadosModel cm = new ChamadosModel();
        ChamadosBll cb = new ChamadosBll();

        public ChamadoDetalhe(int chamado)
        {
            InitializeComponent();
            List<ChamadosModel> listaChamado = new List<ChamadosModel>();

            cm.IdChamado = chamado;
            listaChamado = cb.ConsultaChamado(cm);

            cm = listaChamado[0];

            textBox1.Text = cm.IdChamado.ToString();
            textBox2.Text = cm.Problema.ToString();
            textBox3.Text = cm.Area.ToString();
            textBox4.Text = cm.Empresa.ToString();
            richTextBox1.Text = cm.Descricao.ToString();
            textBox6.Text = cm.Solicitante.ToString();
            textBox7.Text = cm.Status.ToString();
            textBox8.Text = cm.TelefoneContato.ToString();
            //textBox9.Text = cm.Operador.ToString();
            //textBox10.Text = cm.MensagemFinal.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChamadoAtender ca = new ChamadoAtender(1);
            ca.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChamadoAlterar ca = new ChamadoAlterar(1);
            ca.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChamadoFinalzar ca = new ChamadoFinalzar(1);
            ca.Show();
            this.Close();
        }

        private void ChamadoDetalhe_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
