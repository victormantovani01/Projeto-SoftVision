﻿namespace Studio_de_beleza_Erica
{
    partial class IncluirCliente
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbservico = new System.Windows.Forms.ComboBox();
            this.mtbdata = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnfechar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txbCodigoCliente = new System.Windows.Forms.TextBox();
            this.mtxbtelefonecliente = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbendereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbnumero = new System.Windows.Forms.Label();
            this.txbnumerodacasa = new System.Windows.Forms.TextBox();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbnomecliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.GroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Incluir Cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GroupBox
            // 
            this.GroupBox.BackColor = System.Drawing.Color.DarkGray;
            this.GroupBox.Controls.Add(this.label6);
            this.GroupBox.Controls.Add(this.cmbservico);
            this.GroupBox.Controls.Add(this.mtbdata);
            this.GroupBox.Controls.Add(this.label5);
            this.GroupBox.Controls.Add(this.btnfechar);
            this.GroupBox.Controls.Add(this.btnincluir);
            this.GroupBox.Controls.Add(this.txbCodigoCliente);
            this.GroupBox.Controls.Add(this.mtxbtelefonecliente);
            this.GroupBox.Controls.Add(this.label4);
            this.GroupBox.Controls.Add(this.txbendereco);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Controls.Add(this.txbnumero);
            this.GroupBox.Controls.Add(this.txbnumerodacasa);
            this.GroupBox.Controls.Add(this.txbemail);
            this.GroupBox.Controls.Add(this.label3);
            this.GroupBox.Controls.Add(this.txbnomecliente);
            this.GroupBox.Controls.Add(this.label1);
            this.GroupBox.Location = new System.Drawing.Point(19, 19);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(724, 357);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Dados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Serviço:";
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
            this.cmbservico.Location = new System.Drawing.Point(120, 215);
            this.cmbservico.Name = "cmbservico";
            this.cmbservico.Size = new System.Drawing.Size(180, 24);
            this.cmbservico.TabIndex = 32;
            // 
            // mtbdata
            // 
            this.mtbdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbdata.Location = new System.Drawing.Point(464, 160);
            this.mtbdata.Mask = " 99/99/9999 ";
            this.mtbdata.Name = "mtbdata";
            this.mtbdata.Size = new System.Drawing.Size(89, 22);
            this.mtbdata.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Data do serviço: ";
            // 
            // btnfechar
            // 
            this.btnfechar.BackColor = System.Drawing.Color.Gray;
            this.btnfechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfechar.Location = new System.Drawing.Point(465, 225);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(88, 38);
            this.btnfechar.TabIndex = 29;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = false;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.BackColor = System.Drawing.Color.Gray;
            this.btnincluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnincluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnincluir.Location = new System.Drawing.Point(352, 225);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(87, 38);
            this.btnincluir.TabIndex = 28;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = false;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // txbCodigoCliente
            // 
            this.txbCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigoCliente.Location = new System.Drawing.Point(616, 9);
            this.txbCodigoCliente.Name = "txbCodigoCliente";
            this.txbCodigoCliente.Size = new System.Drawing.Size(88, 26);
            this.txbCodigoCliente.TabIndex = 27;
            // 
            // mtxbtelefonecliente
            // 
            this.mtxbtelefonecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbtelefonecliente.Location = new System.Drawing.Point(120, 160);
            this.mtxbtelefonecliente.Mask = " (99) 99999 - 9999";
            this.mtxbtelefonecliente.Name = "mtxbtelefonecliente";
            this.mtxbtelefonecliente.Size = new System.Drawing.Size(160, 26);
            this.mtxbtelefonecliente.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Telefone:";
            // 
            // txbendereco
            // 
            this.txbendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbendereco.Location = new System.Drawing.Point(120, 103);
            this.txbendereco.Name = "txbendereco";
            this.txbendereco.Size = new System.Drawing.Size(239, 26);
            this.txbendereco.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Endereço:";
            // 
            // txbnumero
            // 
            this.txbnumero.AutoSize = true;
            this.txbnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnumero.Location = new System.Drawing.Point(365, 105);
            this.txbnumero.Name = "txbnumero";
            this.txbnumero.Size = new System.Drawing.Size(91, 24);
            this.txbnumero.TabIndex = 22;
            this.txbnumero.Text = "Numero:";
            // 
            // txbnumerodacasa
            // 
            this.txbnumerodacasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnumerodacasa.Location = new System.Drawing.Point(465, 103);
            this.txbnumerodacasa.Name = "txbnumerodacasa";
            this.txbnumerodacasa.Size = new System.Drawing.Size(239, 26);
            this.txbnumerodacasa.TabIndex = 15;
            // 
            // txbemail
            // 
            this.txbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbemail.Location = new System.Drawing.Point(465, 51);
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(239, 26);
            this.txbemail.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "E-Mail:";
            // 
            // txbnomecliente
            // 
            this.txbnomecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnomecliente.Location = new System.Drawing.Point(120, 51);
            this.txbnomecliente.Name = "txbnomecliente";
            this.txbnomecliente.Size = new System.Drawing.Size(239, 26);
            this.txbnomecliente.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // IncluirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "IncluirCliente";
            this.Text = "IncluirCliente";
            this.tabPage1.ResumeLayout(false);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.TextBox txbCodigoCliente;
        private System.Windows.Forms.MaskedTextBox mtxbtelefonecliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbendereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txbnumero;
        private System.Windows.Forms.TextBox txbnumerodacasa;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbnomecliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbdata;
        private System.Windows.Forms.ComboBox cmbservico;
        private System.Windows.Forms.Label label6;
    }
}