using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ConsultaTratorPecas.Main;

namespace ConsultaTratorPecas.Cliente
{
    class dataCliente
    {
        static SqlConnection conexao = null;
        static string server = Properties.Settings.Default.Conexao;

        public static void AtualizaDgv(DataGridView grid, string cbxPesquisar, string palavra)
        {

            try
            {
                conexao = new SqlConnection(server);
                conexao.Open();
                string query =
                    "select               " +
                    "codigo,              " +
                    "descricao as cliente," +
                    "fone,                " +
                    "Celular,             " +
                    "[Cpf ou Cgc] as CPFCNPJ " +
                    "from clientes       where " + cbxPesquisar + " like '%" + palavra + "%'";
                SqlCommand cmd = new SqlCommand(query, conexao);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                grid.DataSource = table;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
