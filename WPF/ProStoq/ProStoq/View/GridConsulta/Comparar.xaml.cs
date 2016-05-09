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

namespace ProStoq.View.GridConsulta
{
    /// <summary>
    /// Interaction logic for Comparar.xaml
    /// </summary>
    public partial class Comparar : UserControl
    {
        public Comparar()
        {
            InitializeComponent();
            Atualizar();
        }

        public void Atualizar()
        {
            dgvCadastro.DataContext = FunGer.selectDB("SELECT * FROM Formatura WHERE ativo = 1");
        }

        private void btnComparar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExluir_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = dgvCadastro.SelectedItem as DataRowView;

            if (row != null)
            {
                FunGer.ExecutaSQL("UPDATE Formatura SET ativo = 0 WHERE id = '" + Convert.ToString(row["id"]) + "'");
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
                var A = new CadastroView();
                A.IniciaVariavelEdit(Convert.ToInt32(row["ativo"]),
                                     Convert.ToInt32(row["id"]),
                                     Convert.ToString(row["nome"]),
                                     Convert.ToString(row["cpfcnpj"]),
                                     Convert.ToString(row["email"]),
                                     Convert.ToString(row["telefone"]),
                                     Convert.ToString(row["localgrau"]),
                                     Convert.ToString(row["aluguel"]),
                                     Convert.ToString(row["convites"]),
                                     Convert.ToString(row["floricultura"]),
                                     Convert.ToString(row["profhomenageados"]),
                                     Convert.ToString(row["localfesta"]),
                                     Convert.ToString(row["observacoes"]));
                A.IniciaCadastro();
                A.Show();
            }
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            Atualizar();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = dgvCadastro.SelectedItem as DataRowView;
            if(row != null)
            {
                var teste = Convert.ToInt32(row["id"]);
            }
        }

        private bool _isSelected;
        public bool IsSelected
        {
            get
            {
                return this._isSelected;
            }
            set
            {
                this._isSelected = value;
            }
        }
    }
}
