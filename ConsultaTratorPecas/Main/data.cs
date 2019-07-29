using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ConsultaTratorPecas.Main
{
    class data
    {
        
        public static string server = Properties.Settings.Default.Conexao;
        public static SqlConnection conexao = null;

        public static bool VerificaConexao()
        {
            try
            {
                conexao = new SqlConnection(server);
                conexao.Open();

                if (conexao.State == ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }



            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                //conexao.Close();
            }


        }

        public static string NomeCliente(string idCliente)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(idCliente)) { return "CLIENTE NÃO ENCONTRADO"; }

                conexao = new SqlConnection(server);
                conexao.Open();
                string query = "SELECT DESCRICAO FROM CLIENTES WHERE CODIGO = " + idCliente;
                SqlCommand cmd = new SqlCommand(query, conexao);

                if (string.IsNullOrEmpty(Convert.ToString(cmd.ExecuteScalar())))
                {
                    return "CLIENTE NÃO ENCONTRADO";
                }
                else
                {
                    return cmd.ExecuteScalar().ToString();
                }
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

        public static void AtualizaDgv(DataGridView dgv, string idCliente, string dti, string dtf)
        {
            try
            {
                conexao = new SqlConnection(server);
                conexao.Open();
                string query =
                    "select                                                        " +
                    "                                                              " +
                    "vnd.codigo,                                                   " +
                    "vnd.data as DataCadastro,                                     " +
                    "vdd.Descricao as vendedor,                                    " +
                    "vnd.TotalVenda,                                               " +
                    "CONCAT(cli.Codigo,'-',cli.Descricao) as Cliente,              " +
                    "vnd.Usuario                                                   " +
                    "                                                              " +
                    "from vendas vnd                                               " +
                    "inner join planos pla on (vnd.CondicoesPagamento = pla.Codigo)" +
                    "inner join clientes cli on (vnd.Cliente = cli.Codigo)         " +
                    "inner join Vendedor vdd on (vnd.Vendedor = vdd.Codigo)        " +
                    "                                                              " +
                    "where vnd.data between '" + dti + "' and '" + dtf + "' " + idCliente + "  "+
                "order by vnd.data,cli.Descricao desc                          ";
                SqlCommand cmd = new SqlCommand(query, conexao);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                dgv.DataSource = table;
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
