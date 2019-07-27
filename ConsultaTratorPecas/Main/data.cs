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
    }
}
