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
    public class CadastroViewModel : Window
    {

        public void IncluiCliente(int _ativoc, 
                                  int _codigoc, 
                                  string _nomec,
                                  string _cpfcnpjc,
                                  string _emailc,
                                  string _telefonec,
                                  string _localgrauc,
                                  string _aluguelc,
                                  string _convitesc,
                                  string _floriculturac,
                                  string _profhomenageadosc,
                                  string _localfestac,
                                  string _observacoesc)
        {
            try
            {
                FunGer.ExecutaSQL("INSERT INTO FORMATURA ("
                                                       + " id,"
                                                       + " nome,"
                                                       + " cpfcnpj,"
                                                       + " email,"
                                                       + " telefone,"
                                                       + " localgrau,"
                                                       + " aluguel,"
                                                       + " convites,"
                                                       + " floricultura,"
                                                       + " profhomenageados,"
                                                       + " localfesta,"
                                                       + " observacoes,"
                                                       + " datahora,"
                                                       + " ativo) "
                                                       + " VALUES "
                                                       + " ('"
                                                       + _codigoc + "', '"
                                                       + _nomec + "','"
                                                       + _cpfcnpjc + "','"
                                                       + _emailc + "','"
                                                       + _telefonec + "','"
                                                       + _localgrauc + "','"
                                                       + _aluguelc + "','"
                                                       + _convitesc + "','"
                                                       + _floriculturac + "','"
                                                       + _profhomenageadosc + "','"
                                                       + _localfestac + "','"
                                                       + _observacoesc + "','"
                                                       + DateTime.Now + "','"
                                                       + _ativoc + "')");

                MessageBox.Show("Cadastrado com Sucesso!", "Successful", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Não foi Possível realizar o Cadastro!", "Error", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
        }

        public void AtualizaCliente(int _ativoc,
                                    int _codigoc,
                                    string _nomec,
                                    string _cpfcnpjc,
                                    string _emailc,
                                    string _telefonec,
                                    string _localgrauc,
                                    string _aluguelc,
                                    string _convitesc,
                                    string _floriculturac,
                                    string _profhomenageadosc,
                                    string _localfestac,
                                    string _observacoesc)
        {
            try
            {
                FunGer.ExecutaSQL("UPDATE FORMATURA SET    nome = '" + _nomec + "',"
                                                      + " cpfcnpj = '" + _cpfcnpjc + "',"
                                                      + " email = '" + _emailc + "',"
                                                      + " telefone = '" + _telefonec + "',"
                                                      + " localgrau = '" + _localgrauc + "',"
                                                      + " aluguel = '" + _aluguelc + "',"
                                                      + " convites = '" + _convitesc + "',"
                                                      + " floricultura = '" + _floriculturac + "',"
                                                      + " profhomenageados = '" + _profhomenageadosc + "',"
                                                      + " localfesta = '" + _localfestac + "',"
                                                      + " observacoes = '" + _observacoesc + "',"
                                                      + " datahora = '" + DateTime.Now + "',"
                                                      + " ativo = '" + _ativoc + "' WHERE   id = '" + _codigoc + "'");

                MessageBox.Show("Atualizado com Sucesso!", "Successful", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Não foi Possível realizar a Atualização!", "Error", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }

        }

    }
}
