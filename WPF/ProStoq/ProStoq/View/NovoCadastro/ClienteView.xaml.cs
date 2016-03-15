using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ProStoq.ViewModel;

namespace ProStoq.View.NovoCadastro
{
    /// <summary>
    /// Interaction logic for ClienteView.xaml
    /// </summary>
    public partial class ClienteView : ClienteViewModel
    {
        private int iCarac = FunGer.cCaracObs;
        private bool inclui;
        public ClienteView()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (inclui)
            {
                AlteraCampos();
                IncluiCliente(_isAtivo ? 1 : 0, _nome, _nacimento, _cpfcnpj, _telefone, _observacoes, _codigo);
            }
            else
            {
                AlteraCampos();
                AtualizaCliente(_isAtivo ? 1 : 0, _nome, _nacimento, _cpfcnpj, _telefone, _observacoes, _codigo);
            }
        }

        public void IniciaCadastro()
        {
            cbxAtivo.IsChecked      = _isAtivo;
            tbxNome.Text            = _nome;
            tbxNacimento.Text       = _nacimento;
            tbxCPFCNPJ.Text         = _cpfcnpj;
            tbxTelefone.Text        = _telefone;
            tbxObservacao.Text      = _observacoes;
            tbxCodigo.Text          = "Código: " + _codigo; 
        }

        public void IniciaVariavelNovo()
        {
            inclui = true;
            _isAtivo        = cbxAtivo.IsChecked == true ? true : false;
            _nome           = string.Empty;
            _nacimento      = string.Empty;
            _cpfcnpj        = string.Empty;
            _telefone       = string.Empty;
            _observacoes    = string.Empty;
            _codigo         = FunGer.SelecionaMaximoID("Clientes");
        }
        public void AlteraCampos()
        {
            _isAtivo        = cbxAtivo.IsChecked == true ? true : false;
            _nome           = tbxNome.Text;
            _nacimento      = tbxNacimento.Text;
            _cpfcnpj        = tbxCPFCNPJ.Text;
            _telefone       = tbxTelefone.Text;
            _observacoes    = tbxObservacao.Text;
        }

        public void IniciaVariavelEdit(int _ativo, string _nomec, string _nacimentoc, string _cpfcnpjc, string _telefonec, string _observacoesc, string _codigoc)
        {
            _isAtivo        = _ativo == 1 ? true : false;
            _nome           = _nomec;
            _nacimento      = _nacimentoc;
            _cpfcnpj        = _cpfcnpjc;
            _telefone       = _telefonec;
            _observacoes    = _observacoesc == null || _observacoesc == "" ? string.Empty : _observacoesc;
            _codigo         = _codigoc;
        }

        private bool _isAtivo;
        public bool Ativo
        {
            get
            {
                return this._isAtivo;
            }
            set
            {
                this._isAtivo = value;
            }
        }

        private string _nome;
        public string Nome
        {
            get
            {
                return this._nome;
            }
            set
            {
                this._nome = value;
            }
        }

        private string _nacimento;
        public string Nacimento
        {
            get
            {
                return this._nacimento;
            }
            set
            {
                this._nacimento = value;
            }
        }

        private string _cpfcnpj;
        public string CpfCnpj
        {
            get
            {
                return this._cpfcnpj;
            }
            set
            {
                this._cpfcnpj = value;
            }
        }

        private string _telefone;
        public string Telefone
        {
            get
            {
                return this._telefone;
            }
            set
            {
                this._telefone = value;
            }
        }

        private string _observacoes;
        public string Observacoes
        {
            get
            {
                return this._observacoes;
            }
            set
            {
                this._observacoes = value;
            }
        }

        private string _codigo;
        public string Codigo
        {
            get
            {
                return this._codigo;
            }
            set
            {
                this._codigo = value;
            }
        }

        private void tbxObservacao_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Back))
            {
                lblCaracteres.Content = "Carac.Rest.: " + iCarac++;
            }
            else
            {
                lblCaracteres.Content = "Carac.Rest.: " + iCarac--;
            }
        }
    }
}
