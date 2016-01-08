using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restauradora.CadastroPadraoVisual;

namespace Restauradora.NovoCadastro
{
    public partial class NovoFornecedor : NovoCadastroPadrao
    {
        private CadastroPadrao f;
        public NovoFornecedor(CadastroPadrao _f)
        {
            InitializeComponent();
            VariaveisIniciais();
            this.f = _f;
        }

        private void VariaveisIniciais()
        {
            lblPadrao.Text = "Cadastro de Fornecedor";
        }

        private void NovoFornecedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.AtualizaGrid("FORNECEDOR");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            IncluiFornecedor();
        }
    }
}
