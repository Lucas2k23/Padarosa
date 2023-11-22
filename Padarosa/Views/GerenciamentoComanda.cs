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
    public partial class GerenciamentoComanda : Form
    {
        Classes.Usuario usuario;
        Classes.Produto produto = new Classes.Produto();
        public GerenciamentoComanda(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            //Mudar o titulo da janela:
            this.Text = "GerenciamentoComandas - " +
                "Logado como: " + usuario.NomeCompleto.ToUpper();

            dgvComandas.DataSource = produto.ListarTudo();

            
        }

        private void GerenciamentoComanda_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja lançar?","Aviso!",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                ordem.IdFicha = int.Parse(txbComanda.Text);
                ordem.IdProduto = int.Parse(txbCodProd.Text);
                ordem.Quantidade = int.Parse(txbQuantidade.Text);
                ordem.IdResp = usuario.Id;

                //Efetuar o lançamento:
                if(ordem.NovoLancamento() == true)
                {
                    MessageBox.Show("Lançamento concluido", "Sucesso!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gpbInformacoes.Enabled = true;
                    gpbLancamento.Enabled = false;
                    txbComanda.Clear();
                    txbCodProd.Clear();
                    txbProdutos.Clear();
                    txbQuantidade.Clear();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro!", "Falha!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gpbInformacoes.Enabled = true;
                    gpbLancamento.Enabled = false;
                    txbComanda.Clear();
                    txbCodProd.Clear();
                    txbProdutos.Clear();
                    txbQuantidade.Clear();
                }
            }
        }

        private void dgvComandas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaselecionada = dgvComandas.CurrentCell.RowIndex;
            var linha = dgvComandas.Rows[linhaselecionada];

            txbCodProd.Text = linha.Cells[0].Value.ToString();
            txbProdutos.Text = linha.Cells[1].Value.ToString();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            gpbInformacoes.Enabled = false;
            gpbLancamento.Enabled = true;
            
        }

        private void bpbInformacoes_Enter(object sender, EventArgs e)
        {

        }
    }
}
