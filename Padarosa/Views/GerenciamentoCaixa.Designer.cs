namespace Padarosa.Views
{
    partial class GerenciamentoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciamentoCaixa));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvFicha = new System.Windows.Forms.DataGridView();
            this.chbInformacao = new System.Windows.Forms.CheckBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFicha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(66, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(132, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nº Comandas:";
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(204, 43);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(123, 26);
            this.txbComanda.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(333, 43);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 26);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvFicha
            // 
            this.dgvFicha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFicha.Location = new System.Drawing.Point(3, 93);
            this.dgvFicha.Name = "dgvFicha";
            this.dgvFicha.Size = new System.Drawing.Size(489, 150);
            this.dgvFicha.TabIndex = 3;
            // 
            // chbInformacao
            // 
            this.chbInformacao.AutoSize = true;
            this.chbInformacao.Location = new System.Drawing.Point(279, 347);
            this.chbInformacao.Name = "chbInformacao";
            this.chbInformacao.Size = new System.Drawing.Size(129, 17);
            this.chbInformacao.TabIndex = 4;
            this.chbInformacao.Text = "Pagamento Recebido";
            this.chbInformacao.UseVisualStyleBackColor = true;
            this.chbInformacao.CheckedChanged += new System.EventHandler(this.chbInformacao_CheckedChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(266, 312);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(24, 16);
            this.lblValor.TabIndex = 5;
            this.lblValor.Text = "R$";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(296, 312);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(0, 16);
            this.lblPreco.TabIndex = 6;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Enabled = false;
            this.btnEncerrar.Location = new System.Drawing.Point(276, 370);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(129, 29);
            this.btnEncerrar.TabIndex = 7;
            this.btnEncerrar.Text = "Encerrar Comanda";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // GerenciamentoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 404);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.chbInformacao);
            this.Controls.Add(this.dgvFicha);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txbComanda);
            this.Controls.Add(this.lblTitulo);
            this.Name = "GerenciamentoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciamentoCaixa";
            this.Load += new System.EventHandler(this.GerenciamentoCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFicha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvFicha;
        private System.Windows.Forms.CheckBox chbInformacao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}