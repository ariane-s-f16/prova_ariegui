namespace prova_ariegui
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
            this.texVENDA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textPRODUTO = new System.Windows.Forms.TextBox();
            this.PRODUTOF = new System.Windows.Forms.Label();
            this.textQTD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textUNIT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_REMOVER = new System.Windows.Forms.Button();
            this.BTN_INSERIR = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vunitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textALTERAR = new System.Windows.Forms.TextBox();
            this.textTOTAL = new System.Windows.Forms.TextBox();
            this.BTN_CANCELAR = new System.Windows.Forms.Button();
            this.BTN_FECHAR = new System.Windows.Forms.Button();
            this.BTN_GERAR = new System.Windows.Forms.Button();
            this.BTN_ALTERAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // texVENDA
            // 
            this.texVENDA.Enabled = false;
            this.texVENDA.Location = new System.Drawing.Point(551, 70);
            this.texVENDA.Name = "texVENDA";
            this.texVENDA.Size = new System.Drawing.Size(100, 20);
            this.texVENDA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "VENDA";
            // 
            // textPRODUTO
            // 
            this.textPRODUTO.Location = new System.Drawing.Point(551, 124);
            this.textPRODUTO.Name = "textPRODUTO";
            this.textPRODUTO.Size = new System.Drawing.Size(100, 20);
            this.textPRODUTO.TabIndex = 2;
            // 
            // PRODUTOF
            // 
            this.PRODUTOF.AutoSize = true;
            this.PRODUTOF.Location = new System.Drawing.Point(141, 130);
            this.PRODUTOF.Name = "PRODUTOF";
            this.PRODUTOF.Size = new System.Drawing.Size(61, 13);
            this.PRODUTOF.TabIndex = 3;
            this.PRODUTOF.Text = "PRODUTO";
            // 
            // textQTD
            // 
            this.textQTD.Location = new System.Drawing.Point(551, 183);
            this.textQTD.Name = "textQTD";
            this.textQTD.Size = new System.Drawing.Size(100, 20);
            this.textQTD.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "QUANTIDADE";
            // 
            // textUNIT
            // 
            this.textUNIT.Location = new System.Drawing.Point(551, 244);
            this.textUNIT.Name = "textUNIT";
            this.textUNIT.Size = new System.Drawing.Size(100, 20);
            this.textUNIT.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "V.UNITÁRIO";
            // 
            // BTN_REMOVER
            // 
            this.BTN_REMOVER.Location = new System.Drawing.Point(498, 306);
            this.BTN_REMOVER.Name = "BTN_REMOVER";
            this.BTN_REMOVER.Size = new System.Drawing.Size(75, 23);
            this.BTN_REMOVER.TabIndex = 8;
            this.BTN_REMOVER.Text = "REMOVER";
            this.BTN_REMOVER.UseVisualStyleBackColor = true;
            this.BTN_REMOVER.Click += new System.EventHandler(this.BTN_REMOVER_Click);
            // 
            // BTN_INSERIR
            // 
            this.BTN_INSERIR.Location = new System.Drawing.Point(200, 306);
            this.BTN_INSERIR.Name = "BTN_INSERIR";
            this.BTN_INSERIR.Size = new System.Drawing.Size(75, 23);
            this.BTN_INSERIR.TabIndex = 9;
            this.BTN_INSERIR.Text = "INSERIR";
            this.BTN_INSERIR.UseVisualStyleBackColor = true;
            this.BTN_INSERIR.Click += new System.EventHandler(this.BTN_INSERIR_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produto,
            this.quantidade,
            this.Vunitario});
            this.dgv.Location = new System.Drawing.Point(200, 382);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(373, 150);
            this.dgv.TabIndex = 10;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // produto
            // 
            this.produto.HeaderText = "PRODUTO";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "QUANTIDADE";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // Vunitario
            // 
            this.Vunitario.HeaderText = "V.UNITÁRIO";
            this.Vunitario.Name = "Vunitario";
            this.Vunitario.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 595);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ALTERAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 637);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "TOTAL";
            // 
            // textALTERAR
            // 
            this.textALTERAR.Location = new System.Drawing.Point(235, 592);
            this.textALTERAR.Name = "textALTERAR";
            this.textALTERAR.Size = new System.Drawing.Size(100, 20);
            this.textALTERAR.TabIndex = 13;
            // 
            // textTOTAL
            // 
            this.textTOTAL.Location = new System.Drawing.Point(235, 634);
            this.textTOTAL.Name = "textTOTAL";
            this.textTOTAL.Size = new System.Drawing.Size(100, 20);
            this.textTOTAL.TabIndex = 14;
            // 
            // BTN_CANCELAR
            // 
            this.BTN_CANCELAR.Location = new System.Drawing.Point(351, 679);
            this.BTN_CANCELAR.Name = "BTN_CANCELAR";
            this.BTN_CANCELAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_CANCELAR.TabIndex = 15;
            this.BTN_CANCELAR.Text = "CANCELAR V.";
            this.BTN_CANCELAR.UseVisualStyleBackColor = true;
            this.BTN_CANCELAR.Click += new System.EventHandler(this.BTN_CANCELAR_Click);
            // 
            // BTN_FECHAR
            // 
            this.BTN_FECHAR.Location = new System.Drawing.Point(498, 679);
            this.BTN_FECHAR.Name = "BTN_FECHAR";
            this.BTN_FECHAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_FECHAR.TabIndex = 16;
            this.BTN_FECHAR.Text = "FECHAR";
            this.BTN_FECHAR.UseVisualStyleBackColor = true;
            this.BTN_FECHAR.Click += new System.EventHandler(this.BTN_FECHAR_Click);
            // 
            // BTN_GERAR
            // 
            this.BTN_GERAR.Location = new System.Drawing.Point(200, 679);
            this.BTN_GERAR.Name = "BTN_GERAR";
            this.BTN_GERAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_GERAR.TabIndex = 17;
            this.BTN_GERAR.Text = "GERAR V.";
            this.BTN_GERAR.UseVisualStyleBackColor = true;
            this.BTN_GERAR.Click += new System.EventHandler(this.BTN_GERAR_Click);
            // 
            // BTN_ALTERAR
            // 
            this.BTN_ALTERAR.Location = new System.Drawing.Point(498, 595);
            this.BTN_ALTERAR.Name = "BTN_ALTERAR";
            this.BTN_ALTERAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_ALTERAR.TabIndex = 18;
            this.BTN_ALTERAR.Text = "ALTERAR";
            this.BTN_ALTERAR.UseVisualStyleBackColor = true;
            this.BTN_ALTERAR.Click += new System.EventHandler(this.BTN_ALTERAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 723);
            this.Controls.Add(this.BTN_ALTERAR);
            this.Controls.Add(this.BTN_GERAR);
            this.Controls.Add(this.BTN_FECHAR);
            this.Controls.Add(this.BTN_CANCELAR);
            this.Controls.Add(this.textTOTAL);
            this.Controls.Add(this.textALTERAR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.BTN_INSERIR);
            this.Controls.Add(this.BTN_REMOVER);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textUNIT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textQTD);
            this.Controls.Add(this.PRODUTOF);
            this.Controls.Add(this.textPRODUTO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texVENDA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texVENDA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPRODUTO;
        private System.Windows.Forms.Label PRODUTOF;
        private System.Windows.Forms.TextBox textQTD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textUNIT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_REMOVER;
        private System.Windows.Forms.Button BTN_INSERIR;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vunitario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textALTERAR;
        private System.Windows.Forms.TextBox textTOTAL;
        private System.Windows.Forms.Button BTN_CANCELAR;
        private System.Windows.Forms.Button BTN_FECHAR;
        private System.Windows.Forms.Button BTN_GERAR;
        private System.Windows.Forms.Button BTN_ALTERAR;
    }
}

