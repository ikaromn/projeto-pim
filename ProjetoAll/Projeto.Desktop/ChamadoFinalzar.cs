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
    public partial class ChamadoFinalzar : Form
    {
        ChamadosModel cm = new ChamadosModel();
        ChamadosBll cb = new ChamadosBll();
        public ChamadoFinalzar(int chamado)
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

        private void ChamadoFinalzar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChamadoDetalhe cd = new ChamadoDetalhe(1);
            cd.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cm.MensagemFinal = textBox10.Text;
                cm.Operador = textBox9.Text;
                cm.IdChamado = 1;

                cb.FecharChamado(cm);
                MessageBox.Show("Chamado Finalizado!!");
                timer1.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro!!!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ChamadoDetalhe cd = new ChamadoDetalhe(1);
            cd.Show();
            this.Hide();
        }
    }
}
