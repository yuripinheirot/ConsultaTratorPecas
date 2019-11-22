using System;
using System.Collections;
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

        public static void EstoqueEco2(DataGridView dgv)
        {
            try
            {
                string codigos = "";
                dgv.Rows.Cast<DataGridViewRow>().ToList().ForEach(p => codigos += p.Cells[0].Value.ToString() + ",");
                codigos = codigos.Substring(0, codigos.Length - 1);
                List<KeyValuePair<string, string>> pdtEstoque = new List<KeyValuePair<string, string>>();
                codigos.Replace(" ", "");

                FbConnection conexao = new FbConnection(Properties.Settings.Default.ConexaoFB);
                conexao.Open();
                string query = "select cast(a.produto as int) as produto,(A.ESTDISPONIVEL + A.ESTRESERVADO + A.ESTCONDICIONAL) as ESTECO from TESTESTOQUE A where cast(A.PRODUTO as int) in ("+codigos+") group by 1,2;";
                FbCommand cmd = new FbCommand(query, conexao);
                FbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pdtEstoque.Add(new KeyValuePair<string, string>(reader["produto"].ToString(), reader["esteco"].ToString()));
                }
                conexao.Close();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (KeyValuePair<string,string> key in pdtEstoque)
                    {
                        if (row.Cells[0].Value.ToString() == key.Key)
                        {
                            row.Cells[8].Value = key.Value;
                        }
                    }
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

        public static void AtualizaDgvPdtCompra(DataGridView dgv, string grupo, string fornecedor, string dti, string dtf)
        {
            try
            {
                conexao = new SqlConnection(server);
                conexao.Open();
                string query =
                    "select                                                                                                                          " +
                    "pdt.Codigo as codProduto,                                                                                                       " +
                    "pdt.Descricao as descProduto,                                                                                                   " +
                    "pdt.PrecoCompra,                                                                                                                " +
                    "pdt.PrecoVenda,                                                                                                                 " +
                    "(select top 1 x.Qtd from NFItemsEntrada x where x.Produto = pdt.codigo order by x.cod desc) as qtdUltimaEnt,                    " +
                    "sum(ivd.Qtd) as qtdVendida,                                                                                                     " +
                    "(SELECT top 1                                                                                                                   " +
                    " cast(a.data as date)                                                                                                           " +
                    " from vendas a                                                                                                                  " +
                    " inner join ItemsVenda b on (a.codigo = b.codigo)                                                                               " +
                    " where b.produto = pdt.codigo                                                                                                   " +
                    " order by a.data desc) as DataUltimaVenda,                                                                                      " +
                    "'' as estEco,                                                                                                                   " +
                    "pdt.Numero,                                                                                                                     " +
                    "pdt.Numero1,                                                                                                                    " +
                    "pdt.Numero2,                                                                                                                    " +
                    "pdt.Numero3,                                                                                                                    " +
                    "pdt.Numero4,                                                                                                                    " +
                    "pdt.RefFornecedor,                                                                                                              " +
                    "(select top 1                                                                                                                   " +
                    " cast(y.DataLanc as date)                                                                                                       " +
                    " from NFItemsEntrada x                                                                                                          " +
                    " inner join NotasFiscaisEntrada y on (x.NumeroNF = y.NumeroNF                                                                   " +
                    "                                      and x.Modelo = y.Modelo                                                                   " +
                    "                                      and x.Serie = y.Serie)                                                                    " +
                    "where                                                                                                                           " +
                    "x.Produto = pdt.codigo                                                                                                          " +
                    "order by y.DataLanc desc) as DataUltimaCompra,                                                                                  " +
                    "(select top 1                                                                                                                   " +
                    "g.cliente                                                                                                                       " +
                    "from NotasFiscaisEntrada g                                                                                                      " +
                    "inner join NFItemsEntrada h on (g.NumeroNF = h.NumeroNF                                                                         " +
                    "                                      and g.Modelo = h.Modelo                                                                   " +
                    "                                      and g.Serie = h.Serie)                                                                    " +
                    "order by g.DataLanc desc) as Fornecedor,                                                                                        " +
                    "fcd.Descricao as Fornecedor,                                                                                                    " +
                    "grp.Codigo as CodGrupo,                                                                                                         " +
                    "grp.Descricao as DescGrupo                                                                                                      " +
                    "from produtos pdt                                                                                                               " +
                    "left outer join NFItemsEntrada nie on (pdt.Codigo = nie.Produto)                                                                " +
                    "left outer join NotasFiscaisEntrada nfe on (nie.NumeroNF = nfe.NumeroNF and nie.Modelo = nfe.Modelo and nie.Serie = nfe.Serie)  " +
                    "left outer join ItemsVenda ivd on (pdt.codigo = ivd.produto)                                                                    " +
                    "left outer join Vendas vda on (ivd.Codigo = vda.codigo)                                                                         " +
                    "left outer join Fornecedor fcd on (pdt.Fornecedor = fcd.Codigo)                                                                 " +
                    "left outer join GrupoProdutos grp on (pdt.Grupo = grp.codigo)                                                                   " +
                    "where                                                                                                                           " +
                    "nfe.DataLanc between @dti and @dtf                                                                                              " +
                    fornecedor + grupo +
                    "and (vda.CANCELADA=0 OR vda.Cancelada IS NULL)                                                                                  " +
                    "group by                                                                                                                        " +
                    "pdt.Codigo,                                                                                                                     " +
                    "pdt.Descricao,                                                                                                                  " +
                    "pdt.PrecoCompra,                                                                                                                " +
                    "pdt.PrecoVenda,                                                                                                                 " +
                    "pdt.DataUltimaVenda,                                                                                                            " +
                    "pdt.Numero,                                                                                                                     " +
                    "pdt.Numero1,                                                                                                                    " +
                    "pdt.Numero2,                                                                                                                    " +
                    "pdt.Numero3,                                                                                                                    " +
                    "pdt.Numero4,                                                                                                                    " +
                    "pdt.RefFornecedor,                                                                                                              " +
                    "pdt.DataUltimaCompra,                                                                                                           " +
                    "pdt.Fornecedor,                                                                                                                 " +
                    "fcd.Descricao,                                                                                                                  " +
                    "grp.Codigo,                                                                                                                     " +
                    "grp.Descricao                                                                                                                   " +
                    "order by                                                                                                                        " +
                    "pdt.codigo asc                                                                                                                  ";

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
