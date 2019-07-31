using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultaTratorPecas.Estoque
{
    class dataProduto
    {
        public static string server = Properties.Settings.Default.Conexao;
        public static SqlConnection conexao = null;

        public static void AtualizaDgv(DataGridView dgv, string PesquisarPor, string PalavraChave, string Inativo)
        {
            try
            {
                conexao = new SqlConnection(server);
                conexao.Open();
                string query =
                "select                                            " +
                "pdt.codigo,                                       " +
                "pdt.Descricao as Produto,                         " +
                "mrc.Descricao as Marca,                           " +
                "pdt.numero,                                       " +
                "pdt.unidade,                                      " +
                "pdt.PrecoVenda,                                   " +
                "pdt.RefFornecedor,                                " +
                "pdt.Inativo                                       " +
                "from produtos pdt                                 " +
                "inner join Marcas mrc on (pdt.Marca = mrc.Codigo) " +
                "where " + Inativo + " and " + PesquisarPor + "like '%" + PalavraChave + "%';";
                SqlCommand cmd = new SqlCommand(query, conexao);
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
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
