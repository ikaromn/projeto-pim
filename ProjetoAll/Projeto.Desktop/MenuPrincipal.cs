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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirChamadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamadoAbrir ca = new ChamadoAbrir();
            ca.Show();
            this.Hide();
        }

        private void painelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamadosConsultar ca = new ChamadosConsultar();
            ca.Show();
            this.Hide();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChamadoAbrir ca = new ChamadoAbrir();
            ca.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChamadosConsultar ca = new ChamadosConsultar();
            ca.Show();
            this.Hide();
        }
    }
}
