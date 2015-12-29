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

namespace Restauradora
{
    public partial class NovoCliente : NovoCadastroPadrao
    {
        private CadastroPadrao f;
        public NovoCliente(CadastroPadrao _f)
        {
            InitializeComponent();
            VariaveisIniciais();
            this.f = _f;
        }

        private void VariaveisIniciais()
        {
            lblPadrao.Text = "Cadastro de Cliente";
        }

        private void NovoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.AtualizaGrid("CLIENTES");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            IncluiCliente();
        }
    }
}
