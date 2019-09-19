using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultaTratorPecas.Main;

namespace ConsultaTratorPecas.Estoque
{
    public partial class frmGrupo : Form
    {
        frmMain main = null;

        public void AtualizaDgv()
        {
            try
            {
                dataProduto.AtualizaDgvGrupo(dgvGrupo,tbxPalavraChave.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops! Algo inesperado aconteceu, contate o seu suporte." + "\n" + "\n" + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public frmGrupo(frmMain main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void FrmGrupocs_Load(object sender, EventArgs e)
        {
            AtualizaDgv();
        }

        private void TbxPalavraChave_TextChanged(object sender, EventArgs e)
        {
            AtualizaDgv();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            main.tbxGrupo.Text = dgvGrupo.CurrentRow.Cells[0].Value.ToString();
            Close();
        }
    }
}
