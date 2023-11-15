namespace Padarosa.Views
{
    partial class GerenciamentoUsuarios
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
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.gpbCadastro = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbSenha2 = new System.Windows.Forms.TextBox();
            this.txbEmail2 = new System.Windows.Forms.TextBox();
            this.txbNome2 = new System.Windows.Forms.TextBox();
            this.lblSenha2 = new System.Windows.Forms.Label();
            this.lblEmail2 = new System.Windows.Forms.Label();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.gpbApagar = new System.Windows.Forms.GroupBox();
            this.txbInformacaoUsuario = new System.Windows.Forms.TextBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblPergunta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.gpbCadastro.SuspendLayout();
            this.gpbEditar.SuspendLayout();
            this.gpbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(19, 12);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.Size = new System.Drawing.Size(508, 187);
            this.dgvUsuario.TabIndex = 3;
            this.dgvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellClick);
            this.dgvUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellContentClick);
            // 
            // gpbCadastro
            // 
            this.gpbCadastro.Controls.Add(this.btnCadastrar);
            this.gpbCadastro.Controls.Add(this.txbSenha);
            this.gpbCadastro.Controls.Add(this.txbEmail);
            this.gpbCadastro.Controls.Add(this.txbNome);
            this.gpbCadastro.Controls.Add(this.lblSenha);
            this.gpbCadastro.Controls.Add(this.lblEmail);
            this.gpbCadastro.Controls.Add(this.lblNome);
            this.gpbCadastro.Location = new System.Drawing.Point(19, 205);
            this.gpbCadastro.Name = "gpbCadastro";
            this.gpbCadastro.Size = new System.Drawing.Size(251, 189);
            this.gpbCadastro.TabIndex = 4;
            this.gpbCadastro.TabStop = false;
            this.gpbCadastro.Text = "Cadastro";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Lime;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrar.Location = new System.Drawing.Point(7, 142);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(229, 41);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(136, 107);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(100, 20);
            this.txbSenha.TabIndex = 5;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(136, 67);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(100, 20);
            this.txbEmail.TabIndex = 4;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(136, 26);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(69, 114);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(75, 74);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(25, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(82, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Completo";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // gpbEditar
            // 
            this.gpbEditar.Controls.Add(this.btnEditar);
            this.gpbEditar.Controls.Add(this.txbSenha2);
            this.gpbEditar.Controls.Add(this.txbEmail2);
            this.gpbEditar.Controls.Add(this.txbNome2);
            this.gpbEditar.Controls.Add(this.lblSenha2);
            this.gpbEditar.Controls.Add(this.lblEmail2);
            this.gpbEditar.Controls.Add(this.lblNome2);
            this.gpbEditar.Enabled = false;
            this.gpbEditar.Location = new System.Drawing.Point(276, 205);
            this.gpbEditar.Name = "gpbEditar";
            this.gpbEditar.Size = new System.Drawing.Size(251, 189);
            this.gpbEditar.TabIndex = 5;
            this.gpbEditar.TabStop = false;
            this.gpbEditar.Text = "Edição";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditar.Location = new System.Drawing.Point(7, 142);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(229, 41);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbSenha2
            // 
            this.txbSenha2.Location = new System.Drawing.Point(136, 107);
            this.txbSenha2.Name = "txbSenha2";
            this.txbSenha2.Size = new System.Drawing.Size(100, 20);
            this.txbSenha2.TabIndex = 5;
            // 
            // txbEmail2
            // 
            this.txbEmail2.Location = new System.Drawing.Point(136, 67);
            this.txbEmail2.Name = "txbEmail2";
            this.txbEmail2.Size = new System.Drawing.Size(100, 20);
            this.txbEmail2.TabIndex = 4;
            // 
            // txbNome2
            // 
            this.txbNome2.Location = new System.Drawing.Point(136, 26);
            this.txbNome2.Name = "txbNome2";
            this.txbNome2.Size = new System.Drawing.Size(100, 20);
            this.txbNome2.TabIndex = 3;
            // 
            // lblSenha2
            // 
            this.lblSenha2.AutoSize = true;
            this.lblSenha2.Location = new System.Drawing.Point(51, 114);
            this.lblSenha2.Name = "lblSenha2";
            this.lblSenha2.Size = new System.Drawing.Size(67, 13);
            this.lblSenha2.TabIndex = 2;
            this.lblSenha2.Text = "Nova Senha";
            this.lblSenha2.Click += new System.EventHandler(this.lblSenha2_Click);
            // 
            // lblEmail2
            // 
            this.lblEmail2.AutoSize = true;
            this.lblEmail2.Location = new System.Drawing.Point(86, 74);
            this.lblEmail2.Name = "lblEmail2";
            this.lblEmail2.Size = new System.Drawing.Size(32, 13);
            this.lblEmail2.TabIndex = 1;
            this.lblEmail2.Text = "Email";
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Location = new System.Drawing.Point(36, 33);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(82, 13);
            this.lblNome2.TabIndex = 0;
            this.lblNome2.Text = "Nome Completo";
            // 
            // gpbApagar
            // 
            this.gpbApagar.Controls.Add(this.txbInformacaoUsuario);
            this.gpbApagar.Controls.Add(this.btnApagar);
            this.gpbApagar.Controls.Add(this.lblPergunta);
            this.gpbApagar.Enabled = false;
            this.gpbApagar.Location = new System.Drawing.Point(155, 418);
            this.gpbApagar.Name = "gpbApagar";
            this.gpbApagar.Size = new System.Drawing.Size(357, 57);
            this.gpbApagar.TabIndex = 6;
            this.gpbApagar.TabStop = false;
            this.gpbApagar.Text = "Apagar";
            // 
            // txbInformacaoUsuario
            // 
            this.txbInformacaoUsuario.Location = new System.Drawing.Point(203, 25);
            this.txbInformacaoUsuario.Name = "txbInformacaoUsuario";
            this.txbInformacaoUsuario.Size = new System.Drawing.Size(63, 20);
            this.txbInformacaoUsuario.TabIndex = 9;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(276, 12);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 39);
            this.btnApagar.TabIndex = 8;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Location = new System.Drawing.Point(6, 27);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(191, 13);
            this.lblPergunta.TabIndex = 7;
            this.lblPergunta.Text = "Selecione o usuario que deseja apagar";
            // 
            // GerenciamentoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 487);
            this.Controls.Add(this.gpbApagar);
            this.Controls.Add(this.gpbEditar);
            this.Controls.Add(this.gpbCadastro);
            this.Controls.Add(this.dgvUsuario);
            this.Name = "GerenciamentoUsuarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciamentoUsuarios";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.dgvUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.gpbCadastro.ResumeLayout(false);
            this.gpbCadastro.PerformLayout();
            this.gpbEditar.ResumeLayout(false);
            this.gpbEditar.PerformLayout();
            this.gpbApagar.ResumeLayout(false);
            this.gpbApagar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.GroupBox gpbCadastro;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gpbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbSenha2;
        private System.Windows.Forms.TextBox txbEmail2;
        private System.Windows.Forms.TextBox txbNome2;
        private System.Windows.Forms.Label lblSenha2;
        private System.Windows.Forms.Label lblEmail2;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.GroupBox gpbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.TextBox txbInformacaoUsuario;
    }
}