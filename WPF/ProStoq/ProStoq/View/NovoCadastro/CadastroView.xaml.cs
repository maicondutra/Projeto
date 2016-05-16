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
    /// Interaction logic for Cadastro.xaml
    /// </summary>
    public partial class CadastroView : CadastroViewModel
    {
        private int iCarac = FunGer.cCaracObs;
        private bool inclui;

        public CadastroView()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (inclui)
            {
                AlteraCampos();
                IncluiCliente(_isAtivo ? 1 : 0, _codigo, _nome, _cpfcnpj, _email, _telefone, _localGrau, _aluguel, _convite, _floricultura, _profHomenageados, _localFesta, _observacoes, _valorfinal, _valorAluno40, _valorAluno50, _valorAluno60, _organizadora, _aluguelSalaoFesta);
            }
            else
            {
                AlteraCampos();
                AtualizaCliente(_isAtivo ? 1 : 0, _codigo, _nome, _cpfcnpj, _email, _telefone, _localGrau, _aluguel, _convite, _floricultura, _profHomenageados, _localFesta, _observacoes, _valorfinal, _valorAluno40, _valorAluno50, _valorAluno60, _organizadora, _aluguelSalaoFesta);
            }
        }

        public void IniciaCadastro()
        {
            cbxAtivo.IsChecked = _isAtivo;
            tbxNome.Text = _nome;
            tbxEmail.Text = _email;
            tbxLocalGrau.Text = _localGrau;
            tbxAluguel.Text = _aluguel;
            tbxConvites.Text = _convite;
            tbxFloricultura.Text = _floricultura;
            tbxProfHomenageado.Text = _profHomenageados;
            tbxLocalFesta.Text = _localFesta;
            tbxCPFCNPJ.Text = _cpfcnpj;
            tbxTelefone.Text = _telefone;
            tbxObservacao.Text = _observacoes;
            tbxCodigo.Text = "Código: " + _codigo;

            tbxValorFinal.Text = _valorfinal;
            tbxValorAluno40.Text = _valorAluno40;
            tbxValorAluno50.Text = _valorAluno50;
            tbxValorAluno60.Text = _valorAluno60;
            tbxOrganizadora.Text = _organizadora;
            tbxAluguelSalaoFesta.Text = _aluguelSalaoFesta;
        }

        public void IniciaVariavelNovo()
        {
            inclui = true;
            _isAtivo = cbxAtivo.IsChecked == true ? true : false;
            _nome = string.Empty;
            _email = string.Empty;
            _cpfcnpj = string.Empty;
            _telefone = string.Empty;
            _localGrau = string.Empty;
            _aluguel = string.Empty;
            _convite = string.Empty;
            _floricultura = string.Empty;
            _profHomenageados = string.Empty;
            _localFesta = string.Empty;
            _observacoes = string.Empty;
            _codigo = Int32.Parse(FunGer.SelecionaMaximoID("Formatura"));

            _valorfinal = string.Empty;
            _valorAluno40 = string.Empty;
            _valorAluno50 = string.Empty;
            _valorAluno60 = string.Empty;
            _organizadora = string.Empty;
            _aluguelSalaoFesta = string.Empty;
        }
        public void AlteraCampos()
        {
            _isAtivo = cbxAtivo.IsChecked == true ? true : false;
            _nome = tbxNome.Text;
            _email = tbxEmail.Text;
            _cpfcnpj = tbxCPFCNPJ.Text;
            _telefone = tbxTelefone.Text;
            _localGrau = tbxLocalGrau.Text;
            _aluguel = tbxAluguel.Text;
            _convite = tbxConvites.Text;
            _floricultura = tbxFloricultura.Text;
            _profHomenageados = tbxProfHomenageado.Text;
            _localFesta = tbxLocalFesta.Text;
            _observacoes = tbxObservacao.Text;

            _valorfinal = tbxValorFinal.Text;
            _valorAluno40 = tbxValorAluno40.Text;
            _valorAluno50 = tbxValorAluno50.Text;
            _valorAluno60 = tbxValorAluno60.Text;
            _organizadora = tbxOrganizadora.Text;
            _aluguelSalaoFesta = tbxAluguelSalaoFesta.Text;
        }

        public void IniciaVariavelEdit(int _ativoc,
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
                                       string _observacoesc,
                                       string _valorfinalc,
                                       string _valorAluno40c,
                                       string _valorAluno50c,
                                       string _valorAluno60c,
                                       string _organizadorac,
                                       string _aluguelSalaoFestac)
        {
            _isAtivo = _ativoc == 1 ? true : false;
            _nome = _nomec;
            _email = _emailc;
            _cpfcnpj = _cpfcnpjc;
            _telefone = _telefonec;
            _localGrau = _localgrauc;
            _aluguel = _aluguelc;
            _convite = _convitesc;
            _floricultura = _floriculturac;
            _profHomenageados = _profhomenageadosc;
            _localFesta = _localfestac;
            _observacoes = _observacoesc == null || _observacoesc == "" ? string.Empty : _observacoesc;
            _codigo = _codigoc;

            _valorfinal = _valorfinalc;
            _valorAluno40 = _valorAluno40c;
            _valorAluno50 = _valorAluno50c;
            _valorAluno60 = _valorAluno60c;
            _organizadora = _organizadorac;
            _aluguelSalaoFesta = _aluguelSalaoFestac;
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

            if (tbxObservacao.Text == "")
            {
                iCarac = FunGer.cCaracObs;
            }
        }

        private int _codigo;
        public int Codigo
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

        private string _email;
        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }

        private string _localGrau;
        public string LocalGrau
        {
            get
            {
                return this._localGrau;
            }
            set
            {
                this._localGrau = value;
            }
        }

        private string _aluguel;
        public string Aluguel
        {
            get
            {
                return this._aluguel;
            }
            set
            {
                this._aluguel = value;
            }
        }

        private string _convite;
        public string Convite
        {
            get
            {
                return this._convite;
            }
            set
            {
                this._convite = value;
            }
        }

        private string _floricultura;
        public string Floricultura
        {
            get
            {
                return this._floricultura;
            }
            set
            {
                this._floricultura = value;
            }
        }

        private string _profHomenageados;
        public string ProfHomenageados
        {
            get
            {
                return this._profHomenageados;
            }
            set
            {
                this._profHomenageados = value;
            }
        }

        private string _localFesta;
        public string LocalFesta
        {
            get
            {
                return this._localFesta;
            }
            set
            {
                this._localFesta = value;
            }
        }

        private string _valorfinal;
        public string ValorFinal
        {
            get
            {
                return this._valorfinal;
            }
            set
            {
                this._valorfinal = value;
            }
        }

        private string _valorAluno40;
        public string ValorAluno40
        {
            get
            {
                return this._valorAluno40;
            }
            set
            {
                this._valorAluno40 = value;
            }
        }

        private string _valorAluno50;
        public string ValorAluno50
        {
            get
            {
                return this._valorAluno50;
            }
            set
            {
                this._valorAluno50 = value;
            }
        }

        private string _valorAluno60;
        public string ValorAluno60
        {
            get
            {
                return this._valorAluno60;
            }
            set
            {
                this._valorAluno60 = value;
            }
        }

        private string _organizadora;
        public string Organizadora
        {
            get
            {
                return this._organizadora;
            }
            set
            {
                this._organizadora = value;
            }
        }

        private string _aluguelSalaoFesta;
        public string AluguelSalaoFesta
        {
            get
            {
                return this._aluguelSalaoFesta;
            }
            set
            {
                this._aluguelSalaoFesta = value;
            }
        }
    }
}
