using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.ComponentModel;
using System.IO;

namespace ProStoq.ViewModel
{
    public class ClienteViewModel : Window
    {
        //public void IncluiCliente()
        //{
        //    try
        //    {
        //        bool a = cbxAtivo.Checked;
        //        if (a) { _ativo = 1; } else { _ativo = 0; }
        //        string idCliente = FunGer.selectDB("SELECT MAX(id) as id FROM CLIENTES").Rows[0]["id"].ToString();
        //        if (idCliente == "") { idCliente = "0"; }
        //        int idconCli = Convert.ToInt32(idCliente) + 1;
        //        // FunGer.inserirDB("CLIENTES", idconv, tbxNome.Text, tbxCPFCNPJ.Text, tbxDataNacimento.Text, tbxTelefone.Text, ativo);  DateTime.Now.ToShortDateString()
        //        FunGer.ExecutaSQL("INSERT INTO CLIENTES ("
        //                                               + " id,"
        //                                               + " nome,"
        //                                               + " cpfcnpj,"
        //                                               + " datanacimento,"
        //                                               + " telefone,"
        //                                               + " datahora,"
        //                                               + " ativo) "
        //                                               + " VALUES "
        //                                               + " ('"
        //                                               + idconCli + "', '"
        //                                               + tbxNomeCliente.Text + "','"
        //                                               + tbxCPFCNPJCliente.Text + "','"
        //                                               + tbxNacimentoCliente.Text + "','"
        //                                               + tbxTelefoneCliente.Text + "','"
        //                                               + DateTime.Now + "','"
        //                                               + _ativo + "')");

        //        MessageBox.Show("Cliente Cadastrado com Sucesso!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        Close();
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Não foi Possível realizar o Cadastro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //    }
        //}

    }
}
