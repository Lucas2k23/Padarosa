namespace Padarosa.Views
{
    partial class GerenciamentoComanda
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gpbInformacoes = new System.Windows.Forms.GroupBox();
            this.gpbLancamento = new System.Windows.Forms.GroupBox();
            this.lblComanda = new System.Windows.Forms.Label();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.txbCodProd = new System.Windows.Forms.TextBox();
            this.txbProdutos = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.dgvComandas = new System.Windows.Forms.DataGridView();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnLancar = new System.Windows.Forms.Button();
            this.gpbInformacoes.SuspendLayout();
            this.gpbLancamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(147, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(297, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gerenciamento de Comandas";
            // 
            // gpbInformacoes
            // 
            this.gpbInformacoes.Controls.Add(this.btnContinuar);
            this.gpbInformacoes.Controls.Add(this.txbCodProd);
            this.gpbInformacoes.Controls.Add(this.txbComanda);
            this.gpbInformacoes.Controls.Add(this.lblCodProd);
            this.gpbInformacoes.Controls.Add(this.lblComanda);
            this.gpbInformacoes.Location = new System.Drawing.Point(12, 100);
            this.gpbInformacoes.Name = "gpbInformacoes";
            this.gpbInformacoes.Size = new System.Drawing.Size(200, 186);
            this.gpbInformacoes.TabIndex = 1;
            this.gpbInformacoes.TabStop = false;
            this.gpbInformacoes.Text = "Informações";
            this.gpbInformacoes.Enter += new System.EventHandler(this.bpbInformacoes_Enter);
            // 
            // gpbLancamento
            // 
            this.gpbLancamento.Controls.Add(this.btnLancar);
            this.gpbLancamento.Controls.Add(this.txbQuantidade);
            this.gpbLancamento.Controls.Add(this.txbProdutos);
            this.gpbLancamento.Controls.Add(this.label4);
            this.gpbLancamento.Controls.Add(this.label3);
            this.gpbLancamento.Enabled = false;
            this.gpbLancamento.Location = new System.Drawing.Point(12, 308);
            this.gpbLancamento.Name = "gpbLancamento";
            this.gpbLancamento.Size = new System.Drawing.Size(200, 182);
            this.gpbLancamento.TabIndex = 2;
            this.gpbLancamento.TabStop = false;
            this.gpbLancamento.Text = "Lançamento";
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Location = new System.Drawing.Point(7, 29);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(52, 13);
            this.lblComanda.TabIndex = 0;
            this.lblComanda.Text = "Comanda";
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Location = new System.Drawing.Point(6, 92);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(66, 13);
            this.lblCodProd.TabIndex = 1;
            this.lblCodProd.Text = "Cod.Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Produtos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantidade";
            // 
            // txbComanda
            // 
            this.txbComanda.Location = new System.Drawing.Point(82, 29);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(100, 20);
            this.txbComanda.TabIndex = 2;
            // 
            // txbCodProd
            // 
            this.txbCodProd.Location = new System.Drawing.Point(82, 85);
            this.txbCodProd.Name = "txbCodProd";
            this.txbCodProd.ReadOnly = true;
            this.txbCodProd.Size = new System.Drawing.Size(100, 20);
            this.txbCodProd.TabIndex = 3;
            // 
            // txbProdutos
            // 
            this.txbProdutos.Location = new System.Drawing.Point(82, 31);
            this.txbProdutos.Name = "txbProdutos";
            this.txbProdutos.ReadOnly = true;
            this.txbProdutos.Size = new System.Drawing.Size(100, 20);
            this.txbProdutos.TabIndex = 2;
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(82, 91);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txbQuantidade.TabIndex = 3;
            // 
            // dgvComandas
            // 
            this.dgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandas.Location = new System.Drawing.Point(218, 100);
            this.dgvComandas.Name = "dgvComandas";
            this.dgvComandas.Size = new System.Drawing.Size(355, 435);
            this.dgvComandas.TabIndex = 3;
            this.dgvComandas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComandas_CellClick);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Lime;
            this.btnContinuar.Location = new System.Drawing.Point(56, 142);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.Color.Lime;
            this.btnLancar.Location = new System.Drawing.Point(56, 139);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(75, 23);
            this.btnLancar.TabIndex = 4;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.button2_Click);
            // 
            // GerenciamentoComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 545);
            this.Controls.Add(this.dgvComandas);
            this.Controls.Add(this.gpbLancamento);
            this.Controls.Add(this.gpbInformacoes);
            this.Controls.Add(this.lblTitulo);
            this.Name = "GerenciamentoComanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciamentoComanda";
            this.Load += new System.EventHandler(this.GerenciamentoComanda_Load);
            this.gpbInformacoes.ResumeLayout(false);
            this.gpbInformacoes.PerformLayout();
            this.gpbLancamento.ResumeLayout(false);
            this.gpbLancamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gpbInformacoes;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txbCodProd;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.GroupBox gpbLancamento;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbProdutos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvComandas;
    }
}