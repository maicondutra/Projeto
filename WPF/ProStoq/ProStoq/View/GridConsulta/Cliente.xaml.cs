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
using ProStoq.ViewModel;
using ProStoq.View.NovoCadastro;
using System.Data;
using System.Collections;

namespace ProStoq.View
{
    /// <summary>
    /// Interaction logic for Cliente.xaml
    /// </summary>
    public partial class Cliente : UserControl
    {
        public Cliente()
        {
            InitializeComponent();
            Atualizar();
        }

        public void ColunasDoBanco()
        {
            
        }

        public void Atualizar()
        {
            dgvCadastro.DataContext = FunGer.selectDB("SELECT * FROM Clientes WHERE ativo = 1");
        }

        private void btnNovo_Click(object sender, RoutedEventArgs e)
        {
            var A = new ClienteView();
            A.IniciaVariavelNovo();
            A.IniciaCadastro();
            A.Show();
        }

        private void btnExluir_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = dgvCadastro.SelectedItem as DataRowView;

            if (row != null)
            {
                FunGer.ExecutaSQL("UPDATE CLIENTES SET ativo = 0 WHERE id = '" + Convert.ToString(row["id"]) + "'");
                Atualizar();
            }
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            //int _index = dgvCadastro.Items.IndexOf(dgvCadastro.CurrentItem);
            //DataRowView row = (DataRowView)dgvCadastro.SelectedItems[_index];
            DataRowView row = dgvCadastro.SelectedItem as DataRowView;

            if (row != null)
            {
                var A = new ClienteView();
                A.IniciaVariavelEdit(Convert.ToInt32(row["ativo"]),
                                     Convert.ToString(row["nome"]),
                                     Convert.ToString(row["datanacimento"]),
                                     Convert.ToString(row["cpfcnpj"]),
                                     Convert.ToString(row["telefone"]),                                  
                                     Convert.ToString(row["observacoes"]),
                                     Convert.ToString(row["id"]));
                A.IniciaCadastro();
                A.Show();
            }
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            Atualizar();
        }
    }
}
