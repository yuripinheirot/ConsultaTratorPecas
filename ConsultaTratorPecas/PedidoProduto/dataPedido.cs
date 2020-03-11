using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultaTratorPecas.PedidoProduto
{
    class dataPedido
    {
        public static string server = Properties.Settings.Default.Conexao;
        public static SqlConnection conexao = null;

        public static void AtualizaDgv(DataGridView dgv, string idPedido)
        {
            try
            {
                conexao = new SqlConnection(server);
                conexao.Open();
                string query =
                    "select                                                                                   " +
                    "ivd.produto,                                                                             " +
                    "ivd.descricao,                                                                           " +
                    "ivd.numero,                                                                              " +
                    "ivd.qtd as quantidade,                                                                   " +
                    "cast(ivd.PrecoVenda as numeric(18,2)) as PrecoUnitario,                                  " +
                    "ivd.DescontoGeral$,                                                                      " +
                    "cast(((ivd.precovenda * ivd.qtd) - ivd.DescontoGeral$) as numeric(18,2)) as TotalLiquido " +
                    "from ItemsVenda ivd                                                                      " +
                    "inner join Vendas vda on (ivd.Codigo = vda.Codigo)                                       " +
                    "where vda.codigo = @codigo                                                               " +
                    "order by vda.codigo desc                                                                 ";

                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@codigo", idPedido);
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

        public modelPedidoProduto BuscaInformacoes(string idPedido)
        {
            try
            {
                conexao = new SqlConnection(server);
                conexao.Open();
                modelPedidoProduto model = new modelPedidoProduto();
                string query =
                    "select														            " +
                    "cli.Descricao as Cliente,									            " +
                    "pla.Descricao as CondPagamento,							            " +
                    "IIF(vda.Data is null,'',vda.Data) as DataCadastro,						" +
                    "IIF(vda.DataConfirmacaoPreVenda is null,'',vda.Data) as DataRegistro,	" +
                    "vda.Descontos,												            " +
                    "(vda.TotalVenda + vda.descontos) as TotalBruto					        " +
                    "															            " +
                    "from vendas vda 											            " +
                    "inner join clientes cli on (vda.Cliente = cli.Codigo)		            " +
                    "inner join Planos pla on (vda.CondicoesPagamento = pla.Codigo)         " +
                    "where														            " +
                    "															            " +
                    "vda.Codigo = @codigo                                                   ";
                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@codigo", idPedido);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    model.cliente = reader["Cliente"].ToString();
                    model.CondPagamento = reader["CondPagamento"].ToString();
                    model.DataCadastro = Convert.ToDateTime(reader["DataCadastro"]).ToString("dd/MM/yyyy");
                    model.DataRegistro = Convert.ToDateTime(reader["DataRegistro"]).ToString("dd/MM/yyyy");
                    model.Descontos = reader["Descontos"].ToString();
                    model.TotalBruto = reader["TotalBruto"].ToString();
                }

                return model;

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
