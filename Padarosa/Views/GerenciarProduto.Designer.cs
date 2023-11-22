namespace Padarosa.Views
{
    partial class GerenciarProduto
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
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.gpbCadProd = new System.Windows.Forms.GroupBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnCadastrarProd = new System.Windows.Forms.Button();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.txbNomeProd = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.gpbEditProd = new System.Windows.Forms.GroupBox();
            this.cmbCatEdit = new System.Windows.Forms.ComboBox();
            this.btnEditarProd = new System.Windows.Forms.Button();
            this.txbPrecoEdit = new System.Windows.Forms.TextBox();
            this.txbEditNome = new System.Windows.Forms.TextBox();
            this.lblCategoria2 = new System.Windows.Forms.Label();
            this.lblPreco2 = new System.Windows.Forms.Label();
            this.lblNomeProduto2 = new System.Windows.Forms.Label();
            this.gpbApagarProd = new System.Windows.Forms.GroupBox();
            this.txbInformacaoProd = new System.Windows.Forms.TextBox();
            this.btnApagarProd = new System.Windows.Forms.Button();
            this.lblInformacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.gpbCadProd.SuspendLayout();
            this.gpbEditProd.SuspendLayout();
            this.gpbApagarProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProduto
            // 
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(30, 12);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.Size = new System.Drawing.Size(508, 187);
            this.dgvProduto.TabIndex = 4;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellClick);
            this.dgvProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellContentClick);
            // 
            // gpbCadProd
            // 
            this.gpbCadProd.Controls.Add(this.lblCategoria);
            this.gpbCadProd.Controls.Add(this.cmbCategoria);
            this.gpbCadProd.Controls.Add(this.btnCadastrarProd);
            this.gpbCadProd.Controls.Add(this.txbPreco);
            this.gpbCadProd.Controls.Add(this.txbNomeProd);
            this.gpbCadProd.Controls.Add(this.lblPreco);
            this.gpbCadProd.Controls.Add(this.lblNomeProduto);
            this.gpbCadProd.Location = new System.Drawing.Point(30, 205);
            this.gpbCadProd.Name = "gpbCadProd";
            this.gpbCadProd.Size = new System.Drawing.Size(251, 189);
            this.gpbCadProd.TabIndex = 5;
            this.gpbCadProd.TabStop = false;
            this.gpbCadProd.Text = "Cadastro";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(58, 96);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(118, 93);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 8;
            // 
            // btnCadastrarProd
            // 
            this.btnCadastrarProd.BackColor = System.Drawing.Color.Lime;
            this.btnCadastrarProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrarProd.Location = new System.Drawing.Point(7, 142);
            this.btnCadastrarProd.Name = "btnCadastrarProd";
            this.btnCadastrarProd.Size = new System.Drawing.Size(229, 41);
            this.btnCadastrarProd.TabIndex = 6;
            this.btnCadastrarProd.Text = "Cadastrar";
            this.btnCadastrarProd.UseVisualStyleBackColor = false;
            this.btnCadastrarProd.Click += new System.EventHandler(this.btnCadastrarProd_Click);
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(136, 60);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(100, 20);
            this.txbPreco.TabIndex = 4;
            // 
            // txbNomeProd
            // 
            this.txbNomeProd.Location = new System.Drawing.Point(136, 26);
            this.txbNomeProd.Name = "txbNomeProd";
            this.txbNomeProd.Size = new System.Drawing.Size(100, 20);
            this.txbNomeProd.TabIndex = 3;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(75, 67);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preco";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(75, 33);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(35, 13);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Nome";
            // 
            // gpbEditProd
            // 
            this.gpbEditProd.Controls.Add(this.cmbCatEdit);
            this.gpbEditProd.Controls.Add(this.btnEditarProd);
            this.gpbEditProd.Controls.Add(this.txbPrecoEdit);
            this.gpbEditProd.Controls.Add(this.txbEditNome);
            this.gpbEditProd.Controls.Add(this.lblCategoria2);
            this.gpbEditProd.Controls.Add(this.lblPreco2);
            this.gpbEditProd.Controls.Add(this.lblNomeProduto2);
            this.gpbEditProd.Enabled = false;
            this.gpbEditProd.Location = new System.Drawing.Point(287, 205);
            this.gpbEditProd.Name = "gpbEditProd";
            this.gpbEditProd.Size = new System.Drawing.Size(251, 189);
            this.gpbEditProd.TabIndex = 6;
            this.gpbEditProd.TabStop = false;
            this.gpbEditProd.Text = "Edição";
            // 
            // cmbCatEdit
            // 
            this.cmbCatEdit.FormattingEnabled = true;
            this.cmbCatEdit.Location = new System.Drawing.Point(127, 106);
            this.cmbCatEdit.Name = "cmbCatEdit";
            this.cmbCatEdit.Size = new System.Drawing.Size(109, 21);
            this.cmbCatEdit.TabIndex = 7;
            // 
            // btnEditarProd
            // 
            this.btnEditarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditarProd.Location = new System.Drawing.Point(7, 142);
            this.btnEditarProd.Name = "btnEditarProd";
            this.btnEditarProd.Size = new System.Drawing.Size(229, 41);
            this.btnEditarProd.TabIndex = 6;
            this.btnEditarProd.Text = "Editar";
            this.btnEditarProd.UseVisualStyleBackColor = false;
            this.btnEditarProd.Click += new System.EventHandler(this.btnEditarProd_Click);
            // 
            // txbPrecoEdit
            // 
            this.txbPrecoEdit.Location = new System.Drawing.Point(136, 67);
            this.txbPrecoEdit.Name = "txbPrecoEdit";
            this.txbPrecoEdit.Size = new System.Drawing.Size(100, 20);
            this.txbPrecoEdit.TabIndex = 4;
            // 
            // txbEditNome
            // 
            this.txbEditNome.Location = new System.Drawing.Point(136, 26);
            this.txbEditNome.Name = "txbEditNome";
            this.txbEditNome.Size = new System.Drawing.Size(100, 20);
            this.txbEditNome.TabIndex = 3;
            // 
            // lblCategoria2
            // 
            this.lblCategoria2.AutoSize = true;
            this.lblCategoria2.Location = new System.Drawing.Point(69, 114);
            this.lblCategoria2.Name = "lblCategoria2";
            this.lblCategoria2.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria2.TabIndex = 2;
            this.lblCategoria2.Text = "Categoria";
            // 
            // lblPreco2
            // 
            this.lblPreco2.AutoSize = true;
            this.lblPreco2.Location = new System.Drawing.Point(86, 74);
            this.lblPreco2.Name = "lblPreco2";
            this.lblPreco2.Size = new System.Drawing.Size(35, 13);
            this.lblPreco2.TabIndex = 1;
            this.lblPreco2.Text = "Preco";
            // 
            // lblNomeProduto2
            // 
            this.lblNomeProduto2.AutoSize = true;
            this.lblNomeProduto2.Location = new System.Drawing.Point(86, 29);
            this.lblNomeProduto2.Name = "lblNomeProduto2";
            this.lblNomeProduto2.Size = new System.Drawing.Size(35, 13);
            this.lblNomeProduto2.TabIndex = 0;
            this.lblNomeProduto2.Text = "Nome";
            // 
            // gpbApagarProd
            // 
            this.gpbApagarProd.Controls.Add(this.txbInformacaoProd);
            this.gpbApagarProd.Controls.Add(this.btnApagarProd);
            this.gpbApagarProd.Controls.Add(this.lblInformacao);
            this.gpbApagarProd.Enabled = false;
            this.gpbApagarProd.Location = new System.Drawing.Point(166, 400);
            this.gpbApagarProd.Name = "gpbApagarProd";
            this.gpbApagarProd.Size = new System.Drawing.Size(357, 57);
            this.gpbApagarProd.TabIndex = 7;
            this.gpbApagarProd.TabStop = false;
            this.gpbApagarProd.Text = "Apagar";
            // 
            // txbInformacaoProd
            // 
            this.txbInformacaoProd.Location = new System.Drawing.Point(203, 25);
            this.txbInformacaoProd.Name = "txbInformacaoProd";
            this.txbInformacaoProd.Size = new System.Drawing.Size(63, 20);
            this.txbInformacaoProd.TabIndex = 9;
            // 
            // btnApagarProd
            // 
            this.btnApagarProd.BackColor = System.Drawing.Color.Red;
            this.btnApagarProd.Location = new System.Drawing.Point(276, 12);
            this.btnApagarProd.Name = "btnApagarProd";
            this.btnApagarProd.Size = new System.Drawing.Size(75, 39);
            this.btnApagarProd.TabIndex = 8;
            this.btnApagarProd.Text = "Apagar";
            this.btnApagarProd.UseVisualStyleBackColor = false;
            this.btnApagarProd.Click += new System.EventHandler(this.btnApagarProd_Click);
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Location = new System.Drawing.Point(6, 27);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(191, 13);
            this.lblInformacao.TabIndex = 7;
            this.lblInformacao.Text = "Selecione o usuario que deseja apagar";
            // 
            // GerenciarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 467);
            this.Controls.Add(this.gpbApagarProd);
            this.Controls.Add(this.gpbEditProd);
            this.Controls.Add(this.gpbCadProd);
            this.Controls.Add(this.dgvProduto);
            this.Name = "GerenciarProduto";
            this.Text = "GerenciarProduto";
            this.Load += new System.EventHandler(this.GerenciarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.gpbCadProd.ResumeLayout(false);
            this.gpbCadProd.PerformLayout();
            this.gpbEditProd.ResumeLayout(false);
            this.gpbEditProd.PerformLayout();
            this.gpbApagarProd.ResumeLayout(false);
            this.gpbApagarProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.GroupBox gpbCadProd;
        private System.Windows.Forms.Button btnCadastrarProd;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.TextBox txbNomeProd;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.GroupBox gpbEditProd;
        private System.Windows.Forms.Button btnEditarProd;
        private System.Windows.Forms.TextBox txbPrecoEdit;
        private System.Windows.Forms.TextBox txbEditNome;
        private System.Windows.Forms.Label lblCategoria2;
        private System.Windows.Forms.Label lblPreco2;
        private System.Windows.Forms.Label lblNomeProduto2;
        private System.Windows.Forms.GroupBox gpbApagarProd;
        private System.Windows.Forms.TextBox txbInformacaoProd;
        private System.Windows.Forms.Button btnApagarProd;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbCatEdit;
    }
}