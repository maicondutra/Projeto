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
        public List<int> Listas;

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
            ZeraEmpresas();
            var theTabItem = new Window();
            theTabItem.Title = FunGer.cEmpresas;
            theTabItem.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            theTabItem.Height = 300;
            theTabItem.Width = 500;

            var cli = new Empresas();
            cli.Width = theTabItem.Width;
            cli.HorizontalAlignment = HorizontalAlignment.Stretch;
            cli.VerticalAlignment = VerticalAlignment.Stretch;
            cli.dgvCadastro.DataContext = FunGer.selectDB("SELECT * FROM COMPARACAO");
            theTabItem.Content = cli;
            theTabItem.Show();
            FunGer.ExecutaSQL("DROP TABLE COMPARACAO");
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
                if (empresa1 == 0)
                    empresa1 = Convert.ToInt32(row["id"]);
                else if (empresa2 == 0)
                    empresa2 = Convert.ToInt32(row["id"]);
                else if (empresa3 == 0)
                    empresa3 = Convert.ToInt32(row["id"]);
            }
        }

        private void ZeraEmpresas()
        {
            //FunGer.ExecutaSQL("DROP TABLE COMPARACAO");
            FunGer.ExecutaSQL("CREATE TEMPORARY TABLE COMPARACAO (itens VARCHAR(45),empresa1 VARCHAR(45),empresa2 VARCHAR(45),empresa3 VARCHAR(45))");
            FunGer.ExecutaSQL("INSERT INTO COMPARACAO SET itens = '',                                        empresa1 = ' " + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa1).Rows[0]["nome"].ToString() + " ', empresa2 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa2).Rows[0]["nome"].ToString() + "', empresa3 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa3).Rows[0]["nome"].ToString() + "'");
            FunGer.ExecutaSQL("INSERT INTO COMPARACAO SET itens = 'Local a ser realizado a colação de grau', empresa1 = ' " + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa1).Rows[0]["nome"].ToString() + " ', empresa2 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa2).Rows[0]["nome"].ToString() + "', empresa3 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa3).Rows[0]["nome"].ToString() + "'");
            FunGer.ExecutaSQL("INSERT INTO COMPARACAO SET itens = 'Custos com aluguel',                      empresa1 = ' " + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa1).Rows[0]["nome"].ToString() + " ', empresa2 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa2).Rows[0]["nome"].ToString() + "', empresa3 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa3).Rows[0]["nome"].ToString() + "'");
            FunGer.ExecutaSQL("INSERT INTO COMPARACAO SET itens = 'Custos com convites',                     empresa1 = ' " + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa1).Rows[0]["nome"].ToString() + " ', empresa2 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa2).Rows[0]["nome"].ToString() + "', empresa3 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa3).Rows[0]["nome"].ToString() + "'");
            FunGer.ExecutaSQL("INSERT INTO COMPARACAO SET itens = 'Custos com floricultura',                 empresa1 = ' " + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa1).Rows[0]["nome"].ToString() + " ', empresa2 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa2).Rows[0]["nome"].ToString() + "', empresa3 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa3).Rows[0]["nome"].ToString() + "'");
            FunGer.ExecutaSQL("INSERT INTO COMPARACAO SET itens = 'Custo com empresa organizadora',          empresa1 = ' " + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa1).Rows[0]["nome"].ToString() + " ', empresa2 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa2).Rows[0]["nome"].ToString() + "', empresa3 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa3).Rows[0]["nome"].ToString() + "'");
            FunGer.ExecutaSQL("INSERT INTO COMPARACAO SET itens = 'Professores homenageados',                empresa1 = ' " + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa1).Rows[0]["nome"].ToString() + " ', empresa2 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa2).Rows[0]["nome"].ToString() + "', empresa3 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa3).Rows[0]["nome"].ToString() + "'");
            FunGer.ExecutaSQL("INSERT INTO COMPARACAO SET itens = 'Local para a festa de formatura',         empresa1 = ' " + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa1).Rows[0]["nome"].ToString() + " ', empresa2 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa2).Rows[0]["nome"].ToString() + "', empresa3 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa3).Rows[0]["nome"].ToString() + "'");
            FunGer.ExecutaSQL("INSERT INTO COMPARACAO SET itens = 'Custo Aluguel Salão de Festas',           empresa1 = ' " + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa1).Rows[0]["nome"].ToString() + " ', empresa2 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa2).Rows[0]["nome"].ToString() + "', empresa3 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa3).Rows[0]["nome"].ToString() + "'");
            FunGer.ExecutaSQL("INSERT INTO COMPARACAO SET itens = 'Valores Finais',                          empresa1 = ' " + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa1).Rows[0]["nome"].ToString() + " ', empresa2 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa2).Rows[0]["nome"].ToString() + "', empresa3 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa3).Rows[0]["nome"].ToString() + "'");
            FunGer.ExecutaSQL("INSERT INTO COMPARACAO SET itens = 'Valor por Aluno (para 40 alunos)',        empresa1 = ' " + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa1).Rows[0]["nome"].ToString() + " ', empresa2 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa2).Rows[0]["nome"].ToString() + "', empresa3 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa3).Rows[0]["nome"].ToString() + "'");
            FunGer.ExecutaSQL("INSERT INTO COMPARACAO SET itens = 'Valor por Aluno (para 50 alunos)',        empresa1 = ' " + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa1).Rows[0]["nome"].ToString() + " ', empresa2 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa2).Rows[0]["nome"].ToString() + "', empresa3 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa3).Rows[0]["nome"].ToString() + "'");
            FunGer.ExecutaSQL("INSERT INTO COMPARACAO SET itens = 'Valor por Aluno (para 60 alunos)',        empresa1 = ' " + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa1).Rows[0]["nome"].ToString() + " ', empresa2 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa2).Rows[0]["nome"].ToString() + "', empresa3 = '" + FunGer.selectDB("SELECT nome FROM Formatura WHERE id = " + Empresa3).Rows[0]["nome"].ToString() + "'");
            //empresa1 = 0;
            //empresa2 = 0;
            //empresa3 = 0;
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

        private int empresa1;
        public int Empresa1
        {
            get
            {
                return this.empresa1;
            }
            set
            {
                this.empresa1 = value;
            }
        }

        private int empresa2;
        public int Empresa2
        {
            get
            {
                return this.empresa2;
            }
            set
            {
                this.empresa2 = value;
            }
        }

        private int empresa3;
        public int Empresa3
        {
            get
            {
                return this.empresa3;
            }
            set
            {
                this.empresa3 = value;
            }
        }
    }
}
