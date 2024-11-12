using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studio_de_beleza_Erica
{
    public partial class SoftVision : Form
    {
        public SoftVision()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1();
            Form1.ShowDialog();
        }

        private void gerirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var GerirCliente = new PesquisarCliente();
            GerirCliente.ShowDialog();
        }     

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Sobre = new Sobre();
            Sobre.ShowDialog();
        }   
        
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
