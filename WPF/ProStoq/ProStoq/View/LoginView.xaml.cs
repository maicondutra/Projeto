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

namespace ProStoq.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class LoginView : LoginViewModel
    {
        public LoginView()
        {
            InitializeComponent();
            base.CriaUsuarioAdmin();
            base.LerUsuarioSalvo();
            PegaLembrete2();
        }

        private void PegaLoginSenha()
        {
            base.tbxLogin = tbxLogin.Text;
            base.tbxSenha = tbxSenha.Password;       
        }

        private void PegaLembrete()
        {
            if (cbxLembrar.IsChecked == true)
            {
                base.cbxLembrar = true;
            }
            else
            {
                base.cbxLembrar = false;
            }
        }

        private void PegaLembrete2()
        {
            if (base.cbxLembrar)
            {
                cbxLembrar.IsChecked = true;
                tbxLogin.Text = base.tbxLogin;
                tbxSenha.Focus();
               //tbxSenha.Select();
            }
            else
            {
                cbxLembrar.IsChecked = false;
            }
        }

        private void lblFechar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnLoginSistema_Click(object sender, RoutedEventArgs e)
        {
            PegaLoginSenha();

            if (base.ValidarUsuarioSenha())
            {
                PegaLembrete();
                base.SalvaUsuario();

                var menu = new MenuStoqView();
                menu.Show();
                this.Close();
            }
            else
            {
                tbxLogin.Clear();
                tbxSenha.Clear();
                tbxLogin.Focus();
            }
        }
    }
}
