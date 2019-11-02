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

        public static void AtualizaDgvPdtCompraNFE(DataGridView dgv, string grupo, string fornecedor, string dti, string dtf)
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

        public static void AtualizaDgvPdtCompra(DataGridView dgv, string grupo, string fornecedor, string dti, string dtf)
        {
            try
            {
                conexao = new SqlConnection(server);
                conexao.Open();
                string query =
                    "select                                                                                                        " +
                    "cpa.NF,                                                                                                       " +
                    "icp.Produto,                                                                                                  " +
                    "pdt.Descricao,                                                                                                " +
                    "cast(icp.PrecoCompra as numeric(15,2)) as PrecoCompra,                                                        " +
                    "cast(icp.PrecoVenda as numeric(15,2)) as PrecoVenda,                                                          " +
                    "cast(icp.Qtd as numeric(15,2)) as QtdEntrada,                                                                 " +
                    "(SELECT SUM(I.QTD) FROM VENDAS V                                                                              " +
                    "	INNER JOIN ITEMSVENDA I ON V.CODIGO=I.CODIGO and i.Produto = pdt.Codigo                                    " +
                    "	INNER JOIN PRODUTOS P ON P.CODIGO=I.PRODUTO and p.Codigo = pdt.Codigo                                      " +
                    "WHERE V.DATA>=@DTI  AND V.DATA<=@DTF AND (V.CANCELADA=0 OR V.Cancelada IS NULL)  AND I.QTD>0) as QtdVendida,  " +
                    "'' as estEco,                                                                                                 " +
                    "pdt.Numero,                                                                                                   " +
                    "pdt.Numero1,                                                                                                  " +
                    "pdt.Numero2,                                                                                                  " +
                    "pdt.Numero3,                                                                                                  " +
                    "pdt.Numero4,                                                                                                  " +
                    "cast(cpa.Data as date) as Data,                                                                               " +
                    "grp.Codigo as CodGrupo,                                                                                       " +
                    "grp.Descricao as Grupo,                                                                                       " +
                    "fcd.Codigo as CodFornecedor,                                                                                  " +
                    "fcd.Descricao as Fornecedor                                                                                   " +
                    "																											   " +
                    "from compras cpa                                                                                              " +
                    "left outer join ItemsCompra icp on (cpa.Codigo = icp.Codigo)                                                  " +
                    "left outer join produtos pdt on (icp.Produto = pdt.Codigo)                                                    " +
                    "left outer join Fornecedor fcd on (cpa.Fornecedor = fcd.Codigo)                                               " +
                    "left outer join GrupoProdutos grp on (pdt.Grupo = grp.Codigo)                                                 " +
                    "where                                                                                                         " +
                    "																											   " +
                    "icp.codigo = (select max(codigo) from ItemsCompra where produto = icp.produto)                            " +
                    "and cpa.Data between @dti and @dtf                                                                                " +
                    grupo + fornecedor+
                    "and cpa.Fechada = 1                                                                                           " +
                    "and produto is not null                                                                                       " +
                    "																											   " +
                    "order by pdt.Descricao asc                                                                                    ";


                SqlCommand cmd = new SqlCommand(query, conexao);
                //cmd.Parameters.AddWithValue("@grupo", grupo);
                //cmd.Parameters.AddWithValue("@fornecedor", fornecedor);
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
