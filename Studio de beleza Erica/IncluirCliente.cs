using Data;
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
    public partial class IncluirCliente : Form
    {
        string _conexao = Studio_de_beleza_Erica.Properties.Settings.Default.conexao;
        public IncluirCliente()
        {
            InitializeComponent();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Você realmente deseja fechar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            Cliente clientes = new Cliente();      

            ClienteCRUD clienteCRUD = new ClienteCRUD(_conexao);
           
            if (string.IsNullOrWhiteSpace(txbnomecliente.Text) || string.IsNullOrWhiteSpace(mtxbtelefonecliente.Text) || string.IsNullOrWhiteSpace(txbnumerodacasa.Text) || string.IsNullOrWhiteSpace(txbendereco.Text) || string.IsNullOrWhiteSpace(txbemail.Text) || string.IsNullOrWhiteSpace(mtbdata.Text) || string.IsNullOrWhiteSpace(cmbservico.Text))
            {               
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
   
                    clientes.NOME = txbnomecliente.Text;        
                    clientes.Telefone = mtxbtelefonecliente.Text; 
                    clientes.Numero = txbnumerodacasa.Text;        
                    clientes.Endereço = txbendereco.Text;        
                    clientes.Email = txbemail.Text;
                    clientes.Data_servico = mtbdata.Text;
                    clientes.Servico = cmbservico.Text;

                    clienteCRUD.IncluirCliente(clientes);
                   
                    MessageBox.Show("Cadastrado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
                catch (Exception erro)
                {
            
                    MessageBox.Show("Ocorreu um erro" + erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }   
}
