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
        public void IncluiCliente(int _ativo, string _nomec, string _nacimentoc, string _cpfcnpjc, string _telefonec, string _observacoesc, string _codigoc)
        {
            try
            {
                FunGer.ExecutaSQL("INSERT INTO CLIENTES ("
                                                       + " id,"
                                                       + " nome,"
                                                       + " cpfcnpj,"
                                                       + " datanacimento,"
                                                       + " telefone,"
                                                       + " observacoes,"
                                                       + " datahora,"
                                                       + " ativo) "
                                                       + " VALUES "
                                                       + " ('"
                                                       + _codigoc + "', '"
                                                       + _nomec + "','"
                                                       + _cpfcnpjc + "','"
                                                       + _nacimentoc + "','"
                                                       + _telefonec + "','"
                                                       + _observacoesc + "','"
                                                       + DateTime.Now + "','"
                                                       + _ativo + "')");

                MessageBox.Show("Cliente Cadastrado com Sucesso!", "Successful", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Não foi Possível realizar o Cadastro!", "Error", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
        }

        public void AtualizaCliente(int _ativo, string _nomec, string _nacimentoc, string _cpfcnpjc, string _telefonec, string _observacoesc, string _codigoc)
        {
            try
            {
                FunGer.ExecutaSQL("UPDATE CLIENTES SET    nome = '" + _nomec + "',"
                                                      + " cpfcnpj = '" + _cpfcnpjc + "',"
                                                      + " datanacimento = '" + _nacimentoc + "',"
                                                      + " telefone = '" + _telefonec + "',"
                                                      + " observacoes = '" + _observacoesc + "',"
                                                      + " datahora = '" + DateTime.Now + "',"
                                                      + " ativo = '" + _ativo + "' WHERE   id = '" + _codigoc + "'");

                MessageBox.Show("Cliente Atualizado com Sucesso!", "Successful", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Não foi Possível realizar a Atualização!", "Error", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }

        }

    }
}
