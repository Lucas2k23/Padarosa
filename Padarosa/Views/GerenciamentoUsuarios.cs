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
            var r = MessageBox.Show("Tem certeza que deseja apagar?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                if (usuario.Apagar() == true)
                {
                    MessageBox.Show("Usuario apagado!"," sucesso!",
                        MessageBoxButtons.OK,MessageBoxIcon.Information );
                    
                    //Atualizar o dgv:
                    dgvUsuario.DataSource = usuario.ListarTudo();
                    //Limpar os campos de edição:
                    txbNome2.Clear();
                    txbEmail2.Clear();
                    txbSenha2.Clear();
                    lblPergunta.Text = "Selecione um usuario para apagar.";
                    //Desabilitar os grbs:
                    gpbApagar.Enabled = false;
                    gpbEditar.Enabled = false;

                }
                
            }
            else
            {
                MessageBox.Show("Falha ao apagar usuario!", "Falha!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }



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

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            //Instanciar um usuario:
            Classes.Usuario usuario = new Classes.Usuario();

            //Obter os valores dos txbs:
            usuario.Id = idSelecionado;
            usuario.NomeCompleto = txbNome2.Text;
            usuario.Email = txbEmail2.Text;
            usuario.Senha = txbSenha2.Text;

            //Editar:
            if (usuario.Editar() == true)
            {
                MessageBox.Show("Usuario Editado","sucesso!",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                //Atualizar o dgv:
                dgvUsuario.DataSource = usuario.ListarTudo();

                txbNome2.Clear();
                txbEmail2.Clear();
                txbSenha2.Clear();
                //Desabilitar os grbs:
                gpbApagar.Enabled = false;
                gpbEditar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar usuario!","Falha",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
