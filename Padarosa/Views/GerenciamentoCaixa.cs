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
    public partial class GerenciamentoCaixa : Form
    {
        Classes.Usuario usuario = new Classes.Usuario();
        Classes.Produto produto = new Classes.Produto();
        Classes.OrdemComanda Ordem = new Classes.OrdemComanda();
        public GerenciamentoCaixa(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            
        }

        private void GerenciamentoCaixa_Load(object sender, EventArgs e)
        {

        }

        private void chbInformacao_CheckedChanged(object sender, EventArgs e)
        {
            //Ativar/Desativar btn de acordo com o checked:
            btnEncerrar.Enabled = chbInformacao.Checked;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if(txbComanda.Text != "")
            {
                Ordem.IdFicha = int.Parse(txbComanda.Text);
                dgvFicha.DataSource = Ordem.BuscarFicha();
                
                var r = Ordem.BuscarFicha();
                dgvFicha.DataSource = r;
                //Atualizar o valor:
                lblPreco.Text = r.Compute("Sum(total_Item)", "True").ToString();

            }
            else
            {
                MessageBox.Show("Digite o numero da sua ficha", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja encerrar?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                Ordem.IdFicha = int.Parse(txbComanda.Text);
                if (Ordem.Encerrar())
                {
                    MessageBox.Show("Ficha encerrada", "Sucesso!",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpar:
                    txbComanda.Clear();
                    dgvFicha.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar a ficha", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
