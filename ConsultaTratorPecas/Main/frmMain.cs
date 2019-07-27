using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaTratorPecas.Main
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConexao_Click(object sender, EventArgs e)
        {
            try
            {
                if (data.VerificaConexao() == true)
                {

                    MessageBox.Show("", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops! Algo inesperado aconteceu, contate o seu suporte." + "\n" + "\n" + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
