using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa.Views
{
    public partial class GerenciamentoUsuarios : Form
    {
        int idSelecionado = 0;
        public GerenciamentoUsuarios()
        {
            InitializeComponent();
            Classes.Usuario usuario = new Classes.Usuario();
            dgvUsuario.DataSource = usuario.ListarTudo();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void lblSenha2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Id = idSelecionado;
            //Apagar:
        }

        private void dgvUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Instanciar o usuario:
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.NomeCompleto = txbNome.Text;
            usuario.Email = txbEmail.Text;
            usuario.Senha = txbSenha.Text;
            if(usuario.Cadastrar() == true)
            {
                MessageBox.Show("Usuario Cadastrado com sucesso!");
                txbNome.Clear();
                txbEmail.Clear();
                txbSenha.Clear();
                //Atualizar o dgv:
                dgvUsuario.DataSource = usuario.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar usuario!");
            }
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ativar os group box:
            gpbEditar.Enabled = true;
            gpbApagar.Enabled = true;

            //Obter a linha clicada:
            int linhaselecionada = dgvUsuario.CurrentCell.RowIndex;

            //Amazenar os dados selecionados em "linha" tipo um vetor:

            var linha = dgvUsuario.Rows[linhaselecionada];

            //prrencher os campos:
            txbNome.Text = linha.Cells[1].Value.ToString();
            txbEmail.Text = linha.Cells[2].Value.ToString();

            
            //Juntar o id e o nome para exibir no apagar:
            lblPergunta.Text = linha.Cells[0].Value.ToString();
            linha.Cells[1].Value.ToString();

            //Salvar o id do selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;

        }
    }
}
