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

namespace Padarosa
{
    public partial class MenuPrincipal : Form
    {
        //Objetos  globais:
        Classes.Usuario usuario = new Classes.Usuario();

        public MenuPrincipal(Classes.Usuario usuario)
        {
            InitializeComponent();
            //Atribuir  o usuario local no global:
            this.usuario = usuario;

            //Mudar a label de apresentação:
            lblInformacao.Text = "Ola! " + usuario.NomeCompleto;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            //Instanciar a janela:
            Views.GerenciamentoUsuarios janela = new Views.GerenciamentoUsuarios();
            janela.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            //Instanciar um usuario:
           
            Views.GerenciarProduto janela = new Views.GerenciarProduto(usuario);
            janela.Show();
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            Views.GerenciamentoComanda janela = new Views.GerenciamentoComanda(usuario);
            janela.Show();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            Views.GerenciamentoCaixa janela = new Views.GerenciamentoCaixa(usuario);
            janela.Show();
        }
    }
}
