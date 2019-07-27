using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultaTratorPecas.Main;

namespace ConsultaTratorPecas
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (data.VerificaConexao() == true)
            {
                Application.Run(new frmMain());
            }
            else
            {
                MessageBox.Show("Não foi possível conectar ao banco de dados, verifique sua cadeia de conexão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
