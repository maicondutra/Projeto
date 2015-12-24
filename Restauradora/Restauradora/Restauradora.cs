﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration.Assemblies;
using Restauradora.ViewCadastros;
using Restauradora.ViewExcluidos;

namespace Restauradora
{
    public partial class Restauradora : Form
    {
        public Restauradora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewPadrao._tipoSQL = "SELECT * FROM CLIENTES WHERE Ativo = 1";
            Cliente A = new Cliente();
            A.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPadrao._tipoSQL = "SELECT * FROM USUARIO WHERE Ativo = 1";
            Usuario A = new Usuario();
            A.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            ViewPadrao._tipoSQL = "SELECT * FROM PRODUTO WHERE Ativo = 1";
            Produto A = new Produto();
            A.Show();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            ViewPadrao._tipoSQL = "SELECT * FROM FORNECEDOR WHERE Ativo = 1";
            Fornecedor A = new Fornecedor();
            A.Show();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            ViewPadrao._tipoSQL = "SELECT * FROM PEDIDO WHERE Ativo = 1";
            Pedido A = new Pedido();
            A.Show();
        }

        private void btnNuvem_Click(object sender, EventArgs e)
        {
            Nuvem A = new Nuvem();
            A.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExcluidosPadrao._tipoSQL = "SELECT * FROM CLIENTES WHERE Ativo = 0";
            ExcluidosPadrao A = new ExcluidosPadrao();
            A.Text = "Clientes Excluídos";
            A.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExcluidosPadrao._tipoSQL = "SELECT * FROM PRODUTO WHERE Ativo = 0";
            ExcluidosPadrao A = new ExcluidosPadrao();
            A.Text = "Produtos Excluídos";
            A.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluidosPadrao._tipoSQL = "SELECT * FROM FORNECEDOR WHERE Ativo = 0";
            ExcluidosPadrao A = new ExcluidosPadrao();
            A.Text = "Fornecedor Excluídos";
            A.Show();
        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExcluidosPadrao._tipoSQL = "SELECT * FROM USUARIO WHERE Ativo = 0";
            ExcluidosPadrao A = new ExcluidosPadrao();
            A.Text = "Usuários Excluídos";
            A.Show();
        }
    }
}
