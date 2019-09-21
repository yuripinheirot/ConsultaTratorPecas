using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

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
                MessageBox.Show(erro.Message);

            }
            finally
            {
                conexao.Close();
            }
            return false;

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

        public static string NomeProduto(string idProduto)
        {
            try
            {
                conexao = new SqlConnection(server);
                conexao.Open();
                string query = "select descricao from produtos where codigo = @codigo;";
                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@codigo", idProduto);
                return cmd.ExecuteScalar().ToString();
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

        public static string NomeFornecedor(string idForncedor)
        {
            try
            {
                conexao = new SqlConnection(server);
                conexao.Open();
                string query = "select descricao from fornecedor where codigo = @codigo;";
                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@codigo", idForncedor);
                return cmd.ExecuteScalar().ToString();
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

        public static string EstoqueEco(string idProduto)
        {
            try
            {
                FbConnection conexao = new FbConnection(Properties.Settings.Default.ConexaoFB);
                conexao.Open();
                string query = "select (a.ESTDISPONIVEL + a.ESTRESERVADO + a.ESTCONDICIONAL) as EstEco from testestoque a where cast(a.produto as int) = @codigo;";
                FbCommand cmd = new FbCommand(query, conexao);
                cmd.Parameters.AddWithValue("@codigo", idProduto);
                string cod = cmd.ExecuteScalar().ToString();
                conexao.Close();
                return cod;
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

        public static void AtualizaDgvPedido(DataGridView dgv, string idCliente, string dti, string dtf)
        {
            try
            {
                conexao = new SqlConnection(server);
                conexao.Open();
                string query =
                    "select                                                                       " +
                    "vnd.codigo,                                                                  " +
                    "vnd.data as DataCadastro,                                                    " +
                    "vdd.Descricao as vendedor,                                                   " +
                    "vnd.TotalVenda,                                                              " +
                    "CONCAT(cli.Codigo,'-',cli.Descricao) as Cliente,                             " +
                    "vnd.Usuario                                                                  " +
                    "from vendas vnd                                                              " +
                    "inner join planos pla on (vnd.CondicoesPagamento = pla.Codigo)               " +
                    "inner join clientes cli on (vnd.Cliente = cli.Codigo)                        " +
                    "inner join Vendedor vdd on (vnd.Vendedor = vdd.Codigo)                       " +
                    "where cast(vnd.data as date) between @dti and @dtf                           " + idCliente +
                    "order by vnd.data,cli.Descricao desc                                         ";
                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@dti", dti);
                cmd.Parameters.AddWithValue("@dtf", dtf);
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

        public static void AtualizaDgvPdtCompra(DataGridView dgv,string  grupo, string fornecedor,  string dti, string dtf)
        {
            try
            {
                conexao = new SqlConnection(server);
                conexao.Open();
                string query = "EXECUTE ECO_RELATORIO @dti, @dtf, @grupo, @fornecedor, 'bruno'";


                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@grupo", grupo);
                cmd.Parameters.AddWithValue("@fornecedor", fornecedor);
                cmd.Parameters.AddWithValue("@dti", dti);
                cmd.Parameters.AddWithValue("@dtf", dtf);
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

        public static void AtualizaDgvPdtVenda(DataGridView dgv, string tipo, string id, string dti, string dtf)
        {
            try
            {
                conexao = new SqlConnection(server);
                conexao.Open();
                string query =
                    "select distinct                                                                 " +
                    "vda.Codigo as CodVenda,                                                         " +
                    "vda.Data as DataCadastro,                                                       " +
                    "concat(pdt.Codigo,'-',pdt.Descricao) as Produto,                                " +
                    "pdt.RefFornecedor,                                                              " +
                    "ivd.Qtd as QtdVendida,                                                          " +
                    "ivd.PrecoVenda,                                                                 " +
                    "(ivd.PrecoVenda * ivd.Qtd ) as TotalVendido,                                    " +
                    "pdt.PrecoVenda as PrecoProduto,                                                 " +
                    "concat(cli.Codigo, '-',cli.Descricao) as Cliente                                " +
                    "from Vendas vda                                                                 " +
                    "inner join ItemsVenda  ivd on (vda.Codigo = ivd.Codigo)                         " +
                    "inner join produtos pdt on (ivd.Produto = pdt.Codigo)                           " +
                    "inner join Clientes cli on (vda.Cliente = cli.Codigo)                           " +
                    "inner join NFItemsEntrada nie on (ivd.Produto = nie.Produto)                    " +
                    "where " + tipo + " = @id and cast(vda.data as date) between @dti and @dtf       " +
                    "order by vda.codigo desc                                                        ";
                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@dti", dti);
                cmd.Parameters.AddWithValue("@dtf", dtf);
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
