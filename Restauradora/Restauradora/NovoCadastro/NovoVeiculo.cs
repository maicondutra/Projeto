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
    public partial class NovoVeiculo : NovoCadastroPadrao
    {
        private CadastroPadrao f;
        public NovoVeiculo(CadastroPadrao _f)
        {
            InitializeComponent();
            VariaveisIniciais();
            this.f = _f;
        }

        private void VariaveisIniciais()
        {
            lblPadrao.Text = "Cadastro de Veículos";
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            IncluiVeiculo();
        }

        private void NovoVeiculo_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.AtualizaGrid("VEICULO");
        }
    }
}
