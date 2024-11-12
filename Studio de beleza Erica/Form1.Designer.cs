namespace Studio_de_beleza_Erica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbnomecliente = new System.Windows.Forms.TextBox();
            this.txbemailcliente = new System.Windows.Forms.TextBox();
            this.mtxbcepcliente = new System.Windows.Forms.MaskedTextBox();
            this.mtxbtelefonecliente = new System.Windows.Forms.MaskedTextBox();
            this.txbenderecocliente = new System.Windows.Forms.TextBox();
            this.mtxbdatacliente = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbnomefuncionario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbenderecofuncionario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtxbdatafuncionario = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mtxbtelefonefuncionario = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mtxbcepfuncionario = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbloginfuncionario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbsenhafuncionario = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.TxbNomeProduto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxbIdProduto = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TxbValorDoProduto = new System.Windows.Forms.TextBox();
            this.TxbQuantidadeEstoque = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.mtxbdatacliente);
            this.groupBox1.Controls.Add(this.mtxbtelefonecliente);
            this.groupBox1.Controls.Add(this.mtxbcepcliente);
            this.groupBox1.Controls.Add(this.txbenderecocliente);
            this.groupBox1.Controls.Add(this.txbemailcliente);
            this.groupBox1.Controls.Add(this.txbnomecliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro do Cliente ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro do Funcionario ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TxbQuantidadeEstoque);
            this.tabPage3.Controls.Add(this.TxbValorDoProduto);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.TxbIdProduto);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.TxbNomeProduto);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cadastro do Produto ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "CEP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de Nascimento:";
            // 
            // txbnomecliente
            // 
            this.txbnomecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnomecliente.Location = new System.Drawing.Point(129, 39);
            this.txbnomecliente.Name = "txbnomecliente";
            this.txbnomecliente.Size = new System.Drawing.Size(239, 26);
            this.txbnomecliente.TabIndex = 6;
            // 
            // txbemailcliente
            // 
            this.txbemailcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbemailcliente.Location = new System.Drawing.Point(475, 39);
            this.txbemailcliente.Name = "txbemailcliente";
            this.txbemailcliente.Size = new System.Drawing.Size(239, 26);
            this.txbemailcliente.TabIndex = 7;
            // 
            // mtxbcepcliente
            // 
            this.mtxbcepcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbcepcliente.Location = new System.Drawing.Point(475, 95);
            this.mtxbcepcliente.Mask = " 99 , 999 - 99";
            this.mtxbcepcliente.Name = "mtxbcepcliente";
            this.mtxbcepcliente.Size = new System.Drawing.Size(123, 26);
            this.mtxbcepcliente.TabIndex = 9;
            // 
            // mtxbtelefonecliente
            // 
            this.mtxbtelefonecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbtelefonecliente.Location = new System.Drawing.Point(475, 143);
            this.mtxbtelefonecliente.Mask = " 99 , 999 - 99";
            this.mtxbtelefonecliente.Name = "mtxbtelefonecliente";
            this.mtxbtelefonecliente.Size = new System.Drawing.Size(123, 26);
            this.mtxbtelefonecliente.TabIndex = 10;
            // 
            // txbenderecocliente
            // 
            this.txbenderecocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbenderecocliente.Location = new System.Drawing.Point(129, 95);
            this.txbenderecocliente.Name = "txbenderecocliente";
            this.txbenderecocliente.Size = new System.Drawing.Size(239, 26);
            this.txbenderecocliente.TabIndex = 8;
            // 
            // mtxbdatacliente
            // 
            this.mtxbdatacliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbdatacliente.Location = new System.Drawing.Point(224, 143);
            this.mtxbdatacliente.Mask = " 99/99/9999";
            this.mtxbdatacliente.Name = "mtxbdatacliente";
            this.mtxbdatacliente.Size = new System.Drawing.Size(114, 26);
            this.mtxbdatacliente.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(19, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 80);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(6, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(110, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Feminino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txbsenhafuncionario);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txbloginfuncionario);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.mtxbcepfuncionario);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.mtxbtelefonefuncionario);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.mtxbdatafuncionario);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txbenderecofuncionario);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txbnomefuncionario);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(17, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(734, 359);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nome:";
            // 
            // txbnomefuncionario
            // 
            this.txbnomefuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnomefuncionario.Location = new System.Drawing.Point(109, 38);
            this.txbnomefuncionario.Name = "txbnomefuncionario";
            this.txbnomefuncionario.Size = new System.Drawing.Size(239, 26);
            this.txbnomefuncionario.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Endereço:";
            // 
            // txbenderecofuncionario
            // 
            this.txbenderecofuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbenderecofuncionario.Location = new System.Drawing.Point(109, 98);
            this.txbenderecofuncionario.Name = "txbenderecofuncionario";
            this.txbenderecofuncionario.Size = new System.Drawing.Size(239, 26);
            this.txbenderecofuncionario.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Data de Nascimento:";
            // 
            // mtxbdatafuncionario
            // 
            this.mtxbdatafuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbdatafuncionario.Location = new System.Drawing.Point(206, 150);
            this.mtxbdatafuncionario.Mask = " 99/99/9999";
            this.mtxbdatafuncionario.Name = "mtxbdatafuncionario";
            this.mtxbdatafuncionario.Size = new System.Drawing.Size(114, 26);
            this.mtxbdatafuncionario.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(379, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "Telefone:";
            // 
            // mtxbtelefonefuncionario
            // 
            this.mtxbtelefonefuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbtelefonefuncionario.Location = new System.Drawing.Point(474, 40);
            this.mtxbtelefonefuncionario.Mask = " 99 , 999 - 99";
            this.mtxbtelefonefuncionario.Name = "mtxbtelefonefuncionario";
            this.mtxbtelefonefuncionario.Size = new System.Drawing.Size(123, 26);
            this.mtxbtelefonefuncionario.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(379, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 24);
            this.label11.TabIndex = 15;
            this.label11.Text = "CEP:";
            // 
            // mtxbcepfuncionario
            // 
            this.mtxbcepfuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbcepfuncionario.Location = new System.Drawing.Point(433, 98);
            this.mtxbcepfuncionario.Mask = " 99 , 999 - 99";
            this.mtxbcepfuncionario.Name = "mtxbcepfuncionario";
            this.mtxbcepfuncionario.Size = new System.Drawing.Size(123, 26);
            this.mtxbcepfuncionario.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(369, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 24);
            this.label12.TabIndex = 17;
            this.label12.Text = "Login:";
            // 
            // txbloginfuncionario
            // 
            this.txbloginfuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbloginfuncionario.Location = new System.Drawing.Point(433, 152);
            this.txbloginfuncionario.Name = "txbloginfuncionario";
            this.txbloginfuncionario.Size = new System.Drawing.Size(239, 26);
            this.txbloginfuncionario.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 24);
            this.label13.TabIndex = 19;
            this.label13.Text = "Senha:";
            // 
            // txbsenhafuncionario
            // 
            this.txbsenhafuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbsenhafuncionario.Location = new System.Drawing.Point(88, 196);
            this.txbsenhafuncionario.Name = "txbsenhafuncionario";
            this.txbsenhafuncionario.Size = new System.Drawing.Size(239, 26);
            this.txbsenhafuncionario.TabIndex = 20;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Location = new System.Drawing.Point(10, 236);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 68);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sexo";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(125, 32);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(88, 20);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Feminino";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(6, 32);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(95, 20);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Masculino";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 24);
            this.label14.TabIndex = 2;
            this.label14.Text = "Nome:";
            // 
            // TxbNomeProduto
            // 
            this.TxbNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbNomeProduto.Location = new System.Drawing.Point(84, 25);
            this.TxbNomeProduto.Name = "TxbNomeProduto";
            this.TxbNomeProduto.Size = new System.Drawing.Size(239, 26);
            this.TxbNomeProduto.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 24);
            this.label15.TabIndex = 9;
            this.label15.Text = "ID Do Produto:";
            // 
            // TxbIdProduto
            // 
            this.TxbIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbIdProduto.Location = new System.Drawing.Point(149, 77);
            this.TxbIdProduto.Name = "TxbIdProduto";
            this.TxbIdProduto.Size = new System.Drawing.Size(239, 26);
            this.TxbIdProduto.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 176);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(174, 24);
            this.label16.TabIndex = 16;
            this.label16.Text = "Valor do Produto:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(242, 24);
            this.label17.TabIndex = 18;
            this.label17.Text = "Quantidade em Estoque:";
            // 
            // TxbValorDoProduto
            // 
            this.TxbValorDoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbValorDoProduto.Location = new System.Drawing.Point(187, 176);
            this.TxbValorDoProduto.Name = "TxbValorDoProduto";
            this.TxbValorDoProduto.Size = new System.Drawing.Size(239, 26);
            this.TxbValorDoProduto.TabIndex = 19;
            // 
            // TxbQuantidadeEstoque
            // 
            this.TxbQuantidadeEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbQuantidadeEstoque.Location = new System.Drawing.Point(245, 125);
            this.TxbQuantidadeEstoque.Name = "TxbQuantidadeEstoque";
            this.TxbQuantidadeEstoque.Size = new System.Drawing.Size(239, 26);
            this.TxbQuantidadeEstoque.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MaskedTextBox mtxbcepcliente;
        private System.Windows.Forms.TextBox txbemailcliente;
        private System.Windows.Forms.TextBox txbnomecliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.MaskedTextBox mtxbdatacliente;
        private System.Windows.Forms.MaskedTextBox mtxbtelefonecliente;
        private System.Windows.Forms.TextBox txbenderecocliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox mtxbcepfuncionario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mtxbtelefonefuncionario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtxbdatafuncionario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbenderecofuncionario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbnomefuncionario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox txbsenhafuncionario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbloginfuncionario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxbIdProduto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxbNomeProduto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxbQuantidadeEstoque;
        private System.Windows.Forms.TextBox TxbValorDoProduto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}

