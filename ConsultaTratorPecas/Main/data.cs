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
                string query = "select cast(a.produto as int) as produto,(A.ESTDISPONIVEL + A.ESTRESERVADO + A.ESTCONDICIONAL) as ESTECO from TESTESTOQUE A where cast(A.PRODUTO as int) in (" + codigos + ") group by 1,2;";
                FbCommand cmd = new FbCommand(query, conexao);
                FbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pdtEstoque.Add(new KeyValuePair<string, string>(reader["produto"].ToString(), reader["esteco"].ToString()));
                }
                conexao.Close();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (KeyValuePair<string, string> key in pdtEstoque)
                    {
                        if (row.Cells[0].Value.ToString() == key.Key)
                        {
                            row.Cells["estEcoDataGridViewTextBoxColumn"].Value = key.Value;
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
                    "select                                                               " +
                    "vnd.codigo,                                                          " +
                    "vnd.data as DataCadastro,                                            " +
                    "vdd.Descricao as vendedor,                                           " +
                    "vnd.TotalVenda,                                                      " +
                    "nfe.NumeroNF,                                                        " +
                    "nfe.NFeNumero,                                                       " +
                    "CONCAT(cli.Codigo,'-',cli.Descricao) as Cliente,                     " +
                    "vnd.Usuario                                                          " +
                    "from vendas vnd                                                      " +
                    "left outer join planos pla on (vnd.CondicoesPagamento = pla.Codigo)  " +
                    "left outer join clientes cli on (vnd.Cliente = cli.Codigo)           " +
                    "left outer join Vendedor vdd on (vnd.Vendedor = vdd.Codigo)          " +
                    "left outer join NotasFiscaisPropria  nfe on (vnd.Codigo = nfe.Venda )" +
                    "where cast(vnd.data as date) between @dti and @dtf                   " + idCliente +
                    "order by vnd.data,cli.Descricao desc                                 ";
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

        public static void AtualizaDgvOrcamento(DataGridView dgv, string idCliente, string dti, string dtf)
        {
            try
            {
                conexao = new SqlConnection(server);
                conexao.Open();
                string query =
                     "select distinct                                                     "+
                     "                                                                    "+
                     "orc.Codigo,                                                         "+
                     "CONCAT(clt.Codigo,'-',clt.Descricao) as cliente,                    "+
                     "orc.Data,                                                           "+
                     "orc.TotalVenda,                                                     "+
                     "orc.Descontos,                                                      "+
                     "orc.comprador,                                                      "+
                     "case when orc.Fechada = 0 then 'NÃO' else 'SIM' end as fechada,     "+
                     "orc.Obs                                                             "+
                     "                                                                    "+
                     "from Orcamento orc                                                  "+
                     "inner join ItemsOrc ior on (orc.Codigo = ior.Codigo)                "+
                     "inner join Produtos pdt on (ior.Produto = pdt.Codigo)               "+
                     "inner join Clientes clt on (clt.Codigo = orc.Cliente)               "+
                    "where                                           " +
                   $"orc.Data between '{dti}' and '{dtf}'            " +
                    idCliente +                                      
                    "order by orc.Codigo desc                        ";
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

        public static void AtualizaDgvPdtOrcamento(DataGridView dgv, string id)
        {
            try
            {
                conexao = new SqlConnection(server);
                conexao.Open();
                string query =
                    "select                                                " +
                    "ior.Produto,                                          " +
                    "pdt.Descricao,                                        " +
                    "ior.PrecoVenda,                                       " +
                    "ior.Desconto$,                                        " +
                    "ior.Qtd,                                              " +
                    "ior.ObsItem,                                          " +
                    "ior.PrecoVenda *ior.Qtd as total                      " +
                    "from ItemsOrc ior                                     " +
                    "inner join Orcamento orc on (ior.Codigo = orc.Codigo) " +
                    "inner join produtos pdt on (ior.Produto = pdt.Codigo) " +
                    "where                                                 " +
                    "ior.codigo = @id;                                     ";
                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@id", id);
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
                    "select																		 " +
                    "																			 " +
                    "ivd.Produto as codProduto,                                                  " +
                    "pdt.Descricao as descProduto,                                               " +
                    "pdt.Numero,                                                                 " +
                    "pdt.Numero1,                                                                " +
                    "pdt.Numero2,                                                                " +
                    "pdt.Numero3,                                                                " +
                    "pdt.Numero4,                                                                " +
                    "pdt.RefFornecedor,                                                          " +
                    "'' as estoqueEco,                                                           " +
                    "pdt.Fornecedor,                                                             " +
                    "sum(ivd.Qtd) as qtdVendida,                                                 " +
                    "pdt.PrecoCompra,                                                            " +
                    "pdt.PrecoVenda,                                                             " +
                    "(select top 1                                                               " +
                    "cast(nfe.DataLanc as date) as DataLanc                                      " +
                    "from NFItemsEntrada nie                                                     " +
                    "left outer join NotasFiscaisEntrada nfe on (nie.NumeroNF = nfe.NumeroNF and " +
                    "                                            nie.Modelo = nfe.Modelo and     " +
                    "											nie.Serie = nfe.Serie)           " +
                    "where nfe.Cliente = pdt.Fornecedor                                          " +
                    "and nie.Produto = ivd.Produto	                                             " +
                    "order by nfe.DataLanc desc	) as DataUltimaCompra,                           " +
                    "(select top 1                                                               " +
                    "nie.Qtd                                                                     " +
                    "from NFItemsEntrada nie                                                     " +
                    "left outer join NotasFiscaisEntrada nfe on (nie.NumeroNF = nfe.NumeroNF and " +
                    "                                            nie.Modelo = nfe.Modelo and     " +
                    "											nie.Serie = nfe.Serie)           " +
                    "where nfe.Cliente = pdt.Fornecedor                                          " +
                    "and nie.Produto = ivd.Produto	                                             " +
                    "order by nfe.DataLanc desc	) as qtdUltimaEnt,                               " +
                    "(select top 1                                                               " +
                    "cast(a.Data as date)                                                        " +
                    "from Vendas a                                                               " +
                    "inner join ItemsVenda b on (a.Codigo = b.Codigo)                            " +
                    "where b.Produto = ivd.Produto	                                             " +
                    "order by a.Data desc) as DataUltimaVenda,                                   " +
                    "grp.Codigo as codGrupo,                                                     " + 
                    "grp.Descricao as descGrupo                                                  " +
                    "																			 " +
                    "																			 " +
                    "from Vendas vda                                                             " +
                    "left outer join ItemsVenda ivd on (vda.Codigo = ivd.Codigo)                 " +
                    "left outer join produtos pdt on (ivd.Produto = pdt.Codigo)                  " +
                    "left outer join NFItemsEntrada nie on (ivd.Codigo = nie.Produto)            " +
                    "left outer join NotasFiscaisEntrada nfe on (nie.NumeroNF = nfe.NumeroNF and " +
                    "                                            nie.Modelo = nfe.Modelo and     " +
                    "											nie.Serie = nfe.Serie)           " +
                    "left outer join Fornecedor fcd on (nfe.Cliente = fcd.Codigo)                " +
                    "left outer join GrupoProdutos grp on (pdt.Grupo = grp.codigo)               " +
                    "where                                                                       " +
                    "vda.Data between @dti and @dtf                                              " +
                     fornecedor + grupo +
                    "group by                                                                    " +
                    "ivd.Produto,                                                                " +
                    "pdt.Descricao,                                                              " +
                    "pdt.Numero,                                                                 " +
                    "pdt.Numero1,                                                                " +
                    "pdt.Numero2,                                                                " +
                    "pdt.Numero3,                                                                " +
                    "pdt.Numero4,                                                                " +
                    "pdt.RefFornecedor,                                                          " +
                    "pdt.Fornecedor,                                                             " +
                    "pdt.PrecoCompra,                                                            " +
                    "pdt.PrecoVenda,                                                             " +
                    "grp.Codigo,                                                                 "+
                    "grp.Descricao                                                               ";
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
