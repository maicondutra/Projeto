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

namespace Restauradora
{
    public partial class Cliente : CadastroPadrao
    {
        public Cliente()
        {
            InitializeComponent();
            VariaveisIniciais();
        }

        private void VariaveisIniciais()
        {
            dgvCadastro.DataSource = FunGer.selectDB("SELECT * FROM CLIENTES WHERE Ativo = 1");

            if (_habilitaBotao)
            {
                pAddCliente.Visible = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoCliente B = new NovoCliente(this);
            B.Show();
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            RemovePadrao("CLIENTES");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizaGrid("CLIENTES");
        }

        private void btnAddPadrao_Click(object sender, EventArgs e)
        {
            //int A = dgvCadastro.CurrentRow.Index;
            //string B = dgvCadastro.Rows[A].Cells[A].Value.ToString();
            //NovoPedido._AddClientePedido = B;
            //Close();
        }
    }
}