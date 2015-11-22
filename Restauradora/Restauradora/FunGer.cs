using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauradora
{
    class FunGer
    {
        public string teste = "A";

        public string GetConnectionString()
        {
            // Para evitar armazenar a seqüência de conexão em seu código, 
            // Você pode recuperá-lo a partir de um arquivo de configuração, usando o
            // Propriedade System.Configuration.ConfigurationSettings.AppSettings
            // define string de conexao e cria a conexao, string de conexão nada mais é que uma instrução para se conectar ao banco,
            // onde Server é o nome do servidor, nosso caso LocalHost, Database é o nome do banco, uid é o nome do usuário
            // pwd é a sua senha
            return "Data Source=localhost;"
                    + "Initial Catalog=restauradb;"
                    + "Pwd=root;user id=root;"
                    + "Integrated Security=false;"
                    + "connection timeout=10";
        }
    }
}
