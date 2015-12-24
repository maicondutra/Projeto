﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restauradora.Cadastros;

namespace Restauradora.ViewCadastros
{
    public partial class Fornecedor : ViewPadrao
    {
        public Fornecedor()
        {
            InitializeComponent();
            VariaveisIniciais();
        }

        public void VariaveisIniciais()
        {
            ViewPadrao._tipoCadastro = "novofornecedor";
            ViewCadastroPadrao._tipoCadastro = "novofornecedor";
        }
    }
}
