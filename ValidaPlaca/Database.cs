using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaPlaca
{
    internal class Database
    {
        public void SalvarPlacaDeCarro(string placa)
        {
            string stringDeConexao = "server=localhost; port=3306 User ID=root; Password=root; database=ti_113_windowsforms";
            MySqlConnection conexao = new MySqlConnection(stringDeConexao);
            conexao.Open();

            if (conexao.State == System.Data.ConnectionState.Open)
                Console.WriteLine("Conectado ao Banco de Dados!");
            else
                Console.WriteLine("Não conectado");

            conexao.Close();
        }
    }
}
