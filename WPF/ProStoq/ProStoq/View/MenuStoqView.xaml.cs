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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProStoq.View.GridConsulta;

namespace ProStoq.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MenuStoqView : Window
    {
        public MenuStoqView()
        {
            InitializeComponent();
            this.DataContext = this;
            IniciaTabs();
        }

        //#region --- CloseCommand ---

        //private Utils.RelayCommand _cmdCloseCommand;
        /////
        ///// Returns a command that closes a TabItem.
        /////
        //public ICommand CloseCommand
        //{
        //    get
        //    {
        //        if (_cmdCloseCommand == null)
        //        {
        //            _cmdCloseCommand = new Utils.RelayCommand(
        //                param => this.CloseTab_Execute(param),
        //                param => this.CloseTab_CanExecute(param)
        //                );
        //        }
        //        return _cmdCloseCommand;
        //    }
        //}

        /////
        ///// Called when the command is to be executed.
        /////
        ///// <param name="parm">
        ///// The TabItem in which the Close-button was clicked.
        /////
        //private void CloseTab_Execute(object parm)
        //{
        //    TabItem ti = parm as TabItem;
        //    if (ti != null)
        //        ti.Items.Remove(parm);
        //}

        /////
        ///// Called when the availability of the Close command needs to be determined.
        /////
        ///// <param name="parm">
        ///// The TabItem for which to determine the availability of the Close-command.
        /////
        //private bool CloseTab_CanExecute(object parm)
        //{
        //    //For the sample, the closing of TabItems will only be
        //    //unavailable for disabled TabItems and the very first TabItem.
        //    TabItem ti = parm as TabItem;
        //    if (ti != null && ti != tc.Items[0])
        //        //We have a valid reference to a TabItem, so return
        //        //true if the TabItem is enabled.
        //        return ti.IsEnabled;

        //    //If no reference to a TabItem could be obtained, the command
        //    //cannot be executed
        //    return false;
        //}

        //#endregion

        #region Testes

        //ClosableTab theTabItem = new ClosableTab();
        //theTabItem.Title = "Nova tab";
        //theTabItem.Content = "";
        //tbcPadrao.Items.Add(theTabItem);
        //theTabItem.Focus();

        ////StackPanel st = new StackPanel();
        ////st.Orientation = Orientation.Horizontal;
        ////TextBlock txtb = new TextBlock();
        ////txtb.Text = "New Tab";
        ////txtb.Margin = new Thickness(1, 1, 1, 1);
        ////txtb.VerticalAlignment = VerticalAlignment.Center;
        ////st.Children.Add(txtb);
        ////Button btn = new Button();
        ////btn.Content = "X";
        ////st.Children.Add(btn);

        ////TabItem tbitem = new TabItem();
        ////// Set the header to the stack panel with the 
        ////// TextBlock and Button
        ////tbitem.Header = st;

        //var grid = new Grid();
        //ColumnDefinition col1 = new ColumnDefinition();
        //col1.Width = GridLength.Auto;
        //ColumnDefinition col2 = new ColumnDefinition();
        //col2.Width = new GridLength(1, GridUnitType.Star);

        //grid.ColumnDefinitions.Add(col1);
        //grid.ColumnDefinitions.Add(col2);

        //var cli = new Cliente();
        //cli.Width = theTabItem.Width;

        // Aqui é onde você define o conteúdo da página da guia.
        // Aqui eu adicionei um controle de Cliente
        // como um exemplo.
        //theTabItem.Content = cli;

        //tbcPadrao.Items.Add(theTabItem);
        //theTabItem.Focus();


        //foreach (TabItem item in tbcPadrao.Items)
        //{
        //    if (item.Header.Equals("Cliente"))
        //    {
        //        item.Visibility = Visibility.Visible;
        //        item.IsSelected = true;
        //    }

        //}

        #endregion

        public void IniciaTabs()
        {
            var _wid = SystemParameters.PrimaryScreenWidth;
            var _hei = SystemParameters.PrimaryScreenHeight;

            this.Width = _wid - 300;
            this.Height = _hei - 300;
            //foreach (TabItem item in tbcPadrao.Items)
            //{
            //        //tbcPadrao.SelectedItem = item;
            //        item.Visibility = Visibility.Collapsed;
            //}
        }

        private void Cliente_Click(object sender, RoutedEventArgs e)
        {
            ClosableTab theTabItem = new ClosableTab();
            theTabItem.Title = FunGer.cCliente;
            var cli = new Cliente();
            cli.Width = theTabItem.Width;
            theTabItem.Content = cli;
            tbcPadrao.Items.Add(theTabItem);
            theTabItem.Focus();
        }

        private void Veiculo_Click(object sender, RoutedEventArgs e)
        {
            ClosableTab theTabItem = new ClosableTab();
            theTabItem.Title = FunGer.cVeiculo;
            var cli = new Veiculo();
            cli.Width = theTabItem.Width;
            theTabItem.Content = cli;
            tbcPadrao.Items.Add(theTabItem);
            theTabItem.Focus();
        }

        private void Fornecedor_Click(object sender, RoutedEventArgs e)
        {
            ClosableTab theTabItem = new ClosableTab();
            theTabItem.Title = FunGer.cFornecedor;
            var cli = new Fornecedor();
            cli.Width = theTabItem.Width;
            theTabItem.Content = cli;
            tbcPadrao.Items.Add(theTabItem);
            theTabItem.Focus();
        }

        private void Produto_Click(object sender, RoutedEventArgs e)
        {
            ClosableTab theTabItem = new ClosableTab();
            theTabItem.Title = FunGer.cProduto;
            var cli = new Produto();
            cli.Width = theTabItem.Width;
            theTabItem.Content = cli;
            tbcPadrao.Items.Add(theTabItem);
            theTabItem.Focus();
        }

        private void Pedido_Click(object sender, RoutedEventArgs e)
        {
            ClosableTab theTabItem = new ClosableTab();
            theTabItem.Title = FunGer.cPedido;
            var cli = new Pedido();
            cli.Width = theTabItem.Width;
            theTabItem.Content = cli;
            tbcPadrao.Items.Add(theTabItem);
            theTabItem.Focus();
        }

        private void Nuvem_Click(object sender, RoutedEventArgs e)
        {
            ClosableTab theTabItem = new ClosableTab();
            theTabItem.Title = FunGer.cNuvem;
            var cli = new Nuvem();
            cli.Width = theTabItem.Width;
            theTabItem.Content = cli;
            tbcPadrao.Items.Add(theTabItem);
            theTabItem.Focus();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ClosableTab theTabItem = new ClosableTab();
            theTabItem.Title = FunGer.cUsuario;
            var cli = new UsuarioGridView();
            cli.Width = theTabItem.Width;
            theTabItem.Content = cli;
            tbcPadrao.Items.Add(theTabItem);
            theTabItem.Focus();
        }
    }
}
