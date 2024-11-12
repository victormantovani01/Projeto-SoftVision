using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
namespace Studio_de_beleza_Erica
{
    public partial class PesquisarCliente : Form
    {
        string _conexao = Studio_de_beleza_Erica.Properties.Settings.Default.conexao;
        public PesquisarCliente()
        {
            InitializeComponent();
            ListarCliente();
            ConfigurarDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Você realmente deseja fechar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void ListarCliente()
        {
            
            ClienteCRUD clientecrud = new ClienteCRUD(_conexao);

            
            string busca = txbPesquisa.Text.ToString();
            
            DataSet dspesquisarCliente = new DataSet();
            dspesquisarCliente = clientecrud.BuscarCliente(busca);
           
            dgvClientes.DataSource = dspesquisarCliente;
            dgvClientes.DataMember = "Clientes";
        }
        
        private void ConfigurarDataGrid()
        {
            
            dgvClientes.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
          
            dgvClientes.RowHeadersWidth = 25;
            
            dgvClientes.Columns["ClienteID"].Visible = true;
            dgvClientes.Columns["NOME"].HeaderText = "NOME";
            dgvClientes.Columns["Telefone"].HeaderText = "Telefone";
            dgvClientes.Columns["Numero"].HeaderText = "Numero";
            dgvClientes.Columns["Endereço"].HeaderText = "Endereço";
            dgvClientes.Columns["Email"].HeaderText = "Email";

            
            dgvClientes.Columns["ClienteID"].DisplayIndex = 0;
            dgvClientes.Columns["NOME"].DisplayIndex = 1;
            dgvClientes.Columns["Telefone"].DisplayIndex = 2;
            dgvClientes.Columns["Numero"].DisplayIndex = 3;
            dgvClientes.Columns["Endereço"].DisplayIndex = 4;
            dgvClientes.Columns["Email"].DisplayIndex = 5;
        }    

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txbPesquisa.Text == "")
            {
                MessageBox.Show("Digite um Nome !!"); ;
                txbPesquisa.Focus();
                return;
            }
            ListarCliente();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ListarCliente();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dgvClientes.CurrentRow.Cells["ClienteID"].Value);
                var resultado = MessageBox.Show(
                "Deseja Excluir Esse Registro ? einn",
                "Pergunta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
                if (resultado == DialogResult.Yes)
                {
                    ClienteCRUD clientecrud = new ClienteCRUD(_conexao);
                    clientecrud.ExcluirCliente(codigo);
                    ListarCliente();
                }

                else
                {
                    MessageBox.Show("Selecione um Registro né jovem ! ");
                }
            }
        }
        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);

            var AlterarCliente = new AlterarCliente(codigo);

            AlterarCliente.ShowDialog();

        }

        private void btnIncluir_Click_1(object sender, EventArgs e)
        {
            var incluirCliente = new IncluirCliente();
            
            incluirCliente.ShowDialog();
           
            ListarCliente();
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            if (btnPesquisar.Text == "")
            {             
                MessageBox.Show("Informe um conteúdo !");
               
                btnPesquisar.Focus();
            }          
            ListarCliente();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);

                var resultado = MessageBox.Show(
                    "Deseja excluir esse registro?",
                    "Pergunta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (resultado == DialogResult.Yes)
                {
                    ClienteCRUD ClienteCRUD = new ClienteCRUD(_conexao);

                    ClienteCRUD.ExcluiCliente(codigo);

                    ListarCliente();
                }
            }
            else
            {
                
                MessageBox.Show("Selecione um registro para exclusão!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnpesquisardata_Click(object sender, EventArgs e)
        {
          
        }
    }    
}
