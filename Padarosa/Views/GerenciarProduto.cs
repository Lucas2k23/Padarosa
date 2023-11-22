using Padarosa.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Padarosa.Views
{
    
    public partial class GerenciarProduto : Form
    {
        int idSelecionado = 0;
        //Instanciar um usuario:
        Classes.Usuario usuario = new Classes.Usuario();
        Classes.Categoria categoria = new Classes.Categoria();
        Classes.Produto produto = new Classes.Produto();
        public GerenciarProduto(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            


            dgvProduto.DataSource = produto.ListarTudo();

            var r = categoria.ListarTudo();

            //Percorrer o R, montar a string e adcionar no cmb:
            foreach ( DataRow linha in r.Rows )
            {
                cmbCategoria.Items.Add(linha.ItemArray[0].ToString() + " - "+ linha.ItemArray[1].ToString());
                cmbCatEdit.Items.Add(linha.ItemArray[0].ToString() + " - " + linha.ItemArray[1].ToString());
            }
            
        }

        private void GerenciarProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarProd_Click(object sender, EventArgs e)
        {
            //Instanciar o usuario:
            
            produto.Nome = txbNomeProd.Text;
            produto.Preco = double.Parse(txbPreco.Text);
            produto.IdCategoria = int.Parse(cmbCategoria.Text.Split('-')[0]);
            produto.IdRespCadastro = usuario.Id;
            if (produto.CadastrarProduto() == true)
            {
                MessageBox.Show("Produto cadastrado com sucesso!");
                txbNomeProd.Clear();
                txbPreco.Clear();
                cmbCategoria.Items.Clear();
                //Atualizar o dgv:
                dgvProduto.DataSource = produto.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar Produto!");
            }
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ativar os group box:
            gpbEditProd.Enabled = true;
            gpbApagarProd.Enabled = true;

            //Obter a linha clicada:
            int linhaselecionada = dgvProduto.CurrentCell.RowIndex;

            //Amazenar os dados selecionados em "linha" tipo um vetor:

            var linha = dgvProduto.Rows[linhaselecionada];

            //prrencher os campos:
            txbEditNome.Text = linha.Cells[1].Value.ToString();

            txbPrecoEdit.Text = linha.Cells[2].Value.ToString();
            
            //Juntar o id e o nome para exibir no apagar:
            lblInformacao.Text = linha.Cells[0].Value.ToString();
            linha.Cells[1].Value.ToString();

            //Salvar o id do selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;
        }

        private void btnEditarProd_Click(object sender, EventArgs e)
        {
            produto.Nome = txbEditNome.Text;
            produto.Preco = double.Parse(txbPrecoEdit.Text);
            produto.IdCategoria = int.Parse(cmbCatEdit.Text.Split('-')[0]);
            produto.IdRespCadastro = usuario.Id;
            produto.Id = idSelecionado;
            if (produto.EditarProduto() == true)
            {
                MessageBox.Show("Produto editado com sucesso!");
                txbEditNome.Clear();
                txbPrecoEdit.Clear();
                cmbCatEdit.Items.Clear();
                //Atualizar o dgv:
                dgvProduto.DataSource = produto.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar Produto!");
            }
        }

        private void btnApagarProd_Click(object sender, EventArgs e)
        {
            
            produto.Id = idSelecionado;
            //Apagar:
            var r = MessageBox.Show("Tem certeza que deseja apagar?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (produto.Apagar() == true)
                {
                    MessageBox.Show("Usuario apagado!", " sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Atualizar o dgv:
                    dgvProduto.DataSource = produto.ListarTudo();
                    //Limpar os campos de edição:
                    txbEditNome.Clear();
                    txbPrecoEdit.Clear();
                    cmbCatEdit.Items.Clear();
                    lblInformacao.Text = "Selecione um usuario para apagar.";
                    //Desabilitar os grbs:
                    gpbApagarProd.Enabled = false;
                    gpbEditProd.Enabled = false;

                }

            }
            else
            {
                MessageBox.Show("Falha ao apagar usuario!", "Falha!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
