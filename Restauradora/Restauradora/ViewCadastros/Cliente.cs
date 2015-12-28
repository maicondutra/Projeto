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
    public partial class Cliente : ViewPadrao
    {
        public Cliente()
        {
            InitializeComponent();
            VariaveisIniciais();
        }
        
        public void VariaveisIniciais()
        {
            _tipoCadastro = "novocliente";
          //IniciaCadastros();
            ViewCadastroPadrao._tipoCadastro = "novocliente";

        }

    }
}
