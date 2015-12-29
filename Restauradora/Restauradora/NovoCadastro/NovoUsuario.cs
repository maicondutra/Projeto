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
    public partial class NovoUsuario : NovoCadastroPadrao
    {
        private CadastroPadrao f;
        public NovoUsuario(CadastroPadrao _f)
        {
            InitializeComponent();
            VariaveisIniciais();
            this.f = _f;
        }

        private void VariaveisIniciais()
        {
            lblPadrao.Text = "Cadastro de Usuário";
        }

        private void NovoUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.AtualizaGrid("USUARIO");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            IncluiUsuario();
        }
    }
}
