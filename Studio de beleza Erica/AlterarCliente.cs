using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Studio_de_beleza_Erica
{

    public partial class AlterarCliente : Form
    {
        string _conexao = Studio_de_beleza_Erica.Properties.Settings.Default.conexao;

        public AlterarCliente(int codigo)
        {
            InitializeComponent();

            if (codigo > 0)
            {
                Cliente Cliente = new Cliente();

                ClienteCRUD ClienteCRUD = new ClienteCRUD(_conexao);

                Cliente = ClienteCRUD.ObtemCliente(codigo);

                if (Cliente == null)
                {
                    MessageBox.Show("Cliente não encontrado!",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                   
                    this.Close();
                }
             
                txbCodigoCliente.Text = Cliente.ClienteID.ToString();
                txbnomecliente.Text = Cliente.NOME;
                txbendereco.Text = Cliente.Endereço;
                mtxbtelefonecliente.Text = Cliente.Telefone;
                txbemailcliente.Text = Cliente.Email;
                mktnumero.Text = Cliente.Numero;
                mtbdata.Text = Cliente.Data_servico;
                cmbservico.Text = Cliente.Servico;
            }
        }
        private void btnfechar_Click(object sender, EventArgs e)
        {           
            var result = MessageBox.Show("Você realmente deseja fechar a tela de Alterar cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void btnsalvar_Click(object sender, EventArgs e)
        {
            Cliente Cliente = new Cliente();

            ClienteCRUD clientecrud = new ClienteCRUD(_conexao);

            try
            {               

                Cliente.NOME = txbnomecliente.Text;
                Cliente.Telefone = mtxbtelefonecliente.Text;
                Cliente.Numero = mktnumero.Text;
                Cliente.Endereço = txbendereco.Text;
                Cliente.Email = txbemailcliente.Text;
                Cliente.Data_servico = mtbdata.Text;
                Cliente.Servico = cmbservico.Text;

                int codigo = Convert.ToInt32(txbCodigoCliente.Text);

                Cliente.ClienteID = codigo; 

                clientecrud.AlterarCliente(Cliente);

                this.Close();
            }
            catch (Exception erro)
            {              
                MessageBox.Show("Ocorreu um erro" + erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnfechar_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Você realmente deseja fechar a tela Alterar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }          
}

    
    

