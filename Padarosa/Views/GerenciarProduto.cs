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
    public partial class GerenciarProduto : Form
    {
        //Instanciar um usuario:
        Classes.Usuario usuario = new Classes.Usuario();
        public GerenciarProduto(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void GerenciarProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
