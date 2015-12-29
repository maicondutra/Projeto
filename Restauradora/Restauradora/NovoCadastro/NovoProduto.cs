using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restauradora.Cadastros;

namespace Restauradora.Cadastros
{
    public partial class NovoProduto : NovoCadastroPadrao
    {
        private CadastroPadrao f;
        public NovoProduto(CadastroPadrao _f)
        {
            InitializeComponent();
            VariaveisIniciais();
            this.f = _f;
        }

        private void VariaveisIniciais()
        {
            lblPadrao.Text = "Cadastro de Produto";
        }

        private void NovoProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.AtualizaGrid("PRODUTO");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            IncluiProduto();
        }
    }
}
