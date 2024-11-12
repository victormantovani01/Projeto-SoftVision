namespace Studio_de_beleza_Erica
{
    partial class AlterarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpalterarcliente = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mktnumero = new System.Windows.Forms.MaskedTextBox();
            this.txbCodigoCliente = new System.Windows.Forms.TextBox();
            this.txbnumero = new System.Windows.Forms.Label();
            this.btnfechar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.txbemailcliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxbtelefonecliente = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbendereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbnomecliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbdata = new System.Windows.Forms.MaskedTextBox();
            this.cmbservico = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpalterarcliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpalterarcliente);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tpalterarcliente
            // 
            this.tpalterarcliente.Controls.Add(this.groupBox1);
            this.tpalterarcliente.Location = new System.Drawing.Point(4, 22);
            this.tpalterarcliente.Name = "tpalterarcliente";
            this.tpalterarcliente.Padding = new System.Windows.Forms.Padding(3);
            this.tpalterarcliente.Size = new System.Drawing.Size(768, 400);
            this.tpalterarcliente.TabIndex = 0;
            this.tpalterarcliente.Text = "Alterar Cliente";
            this.tpalterarcliente.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbservico);
            this.groupBox1.Controls.Add(this.mtbdata);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mktnumero);
            this.groupBox1.Controls.Add(this.txbCodigoCliente);
            this.groupBox1.Controls.Add(this.txbnumero);
            this.groupBox1.Controls.Add(this.btnfechar);
            this.groupBox1.Controls.Add(this.btnsalvar);
            this.groupBox1.Controls.Add(this.txbemailcliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mtxbtelefonecliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbendereco);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbnomecliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 355);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados ";
            // 
            // mktnumero
            // 
            this.mktnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktnumero.Location = new System.Drawing.Point(477, 105);
            this.mktnumero.Mask = " 99999";
            this.mktnumero.Name = "mktnumero";
            this.mktnumero.Size = new System.Drawing.Size(73, 26);
            this.mktnumero.TabIndex = 24;
            // 
            // txbCodigoCliente
            // 
            this.txbCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigoCliente.Location = new System.Drawing.Point(628, 9);
            this.txbCodigoCliente.Name = "txbCodigoCliente";
            this.txbCodigoCliente.Size = new System.Drawing.Size(88, 26);
            this.txbCodigoCliente.TabIndex = 23;
            // 
            // txbnumero
            // 
            this.txbnumero.AutoSize = true;
            this.txbnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnumero.Location = new System.Drawing.Point(380, 103);
            this.txbnumero.Name = "txbnumero";
            this.txbnumero.Size = new System.Drawing.Size(91, 24);
            this.txbnumero.TabIndex = 21;
            this.txbnumero.Text = "Numero:";
            // 
            // btnfechar
            // 
            this.btnfechar.BackColor = System.Drawing.Color.Gray;
            this.btnfechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfechar.Location = new System.Drawing.Point(521, 257);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(88, 38);
            this.btnfechar.TabIndex = 18;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = false;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click_1);
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.Gray;
            this.btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsalvar.Location = new System.Drawing.Point(384, 257);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(87, 38);
            this.btnsalvar.TabIndex = 16;
            this.btnsalvar.Text = "Alterar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // txbemailcliente
            // 
            this.txbemailcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbemailcliente.Location = new System.Drawing.Point(477, 50);
            this.txbemailcliente.Name = "txbemailcliente";
            this.txbemailcliente.Size = new System.Drawing.Size(239, 26);
            this.txbemailcliente.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "E-Mail:";
            // 
            // mtxbtelefonecliente
            // 
            this.mtxbtelefonecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbtelefonecliente.Location = new System.Drawing.Point(134, 162);
            this.mtxbtelefonecliente.Mask = " 99 , 99999 - 9999";
            this.mtxbtelefonecliente.Name = "mtxbtelefonecliente";
            this.mtxbtelefonecliente.Size = new System.Drawing.Size(160, 26);
            this.mtxbtelefonecliente.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefone:";
            // 
            // txbendereco
            // 
            this.txbendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbendereco.Location = new System.Drawing.Point(134, 103);
            this.txbendereco.Name = "txbendereco";
            this.txbendereco.Size = new System.Drawing.Size(239, 26);
            this.txbendereco.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Endereço:";
            // 
            // txbnomecliente
            // 
            this.txbnomecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnomecliente.Location = new System.Drawing.Point(134, 48);
            this.txbnomecliente.Name = "txbnomecliente";
            this.txbnomecliente.Size = new System.Drawing.Size(239, 26);
            this.txbnomecliente.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Data do serviço: ";
            // 
            // mtbdata
            // 
            this.mtbdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbdata.Location = new System.Drawing.Point(477, 162);
            this.mtbdata.Mask = " 99/99/9999 ";
            this.mtbdata.Name = "mtbdata";
            this.mtbdata.Size = new System.Drawing.Size(89, 22);
            this.mtbdata.TabIndex = 32;
            // 
            // cmbservico
            // 
            this.cmbservico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbservico.FormattingEnabled = true;
            this.cmbservico.Items.AddRange(new object[] {
            "Corte de Cabelo",
            "Pigmentação",
            "Permanente e Alisamento",
            "Tratamentos Hidratantes",
            "Escova e Penteados",
            "Lavagem e Secagem",
            "Extensões de Cabelo"});
            this.cmbservico.Location = new System.Drawing.Point(134, 220);
            this.cmbservico.Name = "cmbservico";
            this.cmbservico.Size = new System.Drawing.Size(180, 24);
            this.cmbservico.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 34;
            this.label6.Text = "Serviço:";
            // 
            // AlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AlterarCliente";
            this.Text = "AlterarCliente";
            this.tabControl1.ResumeLayout(false);
            this.tpalterarcliente.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpalterarcliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbnomecliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbendereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxbtelefonecliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbemailcliente;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Label txbnumero;
        private System.Windows.Forms.TextBox txbCodigoCliente;
        private System.Windows.Forms.MaskedTextBox mktnumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbdata;
        private System.Windows.Forms.ComboBox cmbservico;
        private System.Windows.Forms.Label label6;
    }
}