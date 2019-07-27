using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaTratorPecas.Cliente
{
    public partial class frmMainCliente : Form
    {
        //metodos
        void atualizaDgv()
        {
            string pesquisar()
            {
                switch (cbxPesquisar.Text)
                {
                    case "Nome":
                        return "descricao";
                    case "CPF/CNPJ":
                        return "[Cpf ou Cgc]";
                    default:
                        return null;
                }
            }

            dataCliente.AtualizaDgv(dgvCliente,pesquisar(),tbxPalavra.Text);

        }
        public frmMainCliente()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TbcPalavra_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (dgvCliente.Focused == false)
                {
                    if (e.KeyCode == Keys.Up)
                    {
                        int i = dgvCliente.CurrentRow.Index - 1;
                        dgvCliente.CurrentCell = dgvCliente.Rows[i].Cells[0];
                    }
                    else if (e.KeyCode == Keys.Down)
                    {
                        int i = dgvCliente.CurrentRow.Index + 1;
                        dgvCliente.CurrentCell = dgvCliente.Rows[i].Cells[0];
                    }
                }
            }
            catch
            {
            }
        }

        private void FrmMainCliente_Load(object sender, EventArgs e)
        {
            cbxPesquisar.Text = "Nome";
            atualizaDgv();
        }

        private void TbxPalavra_TextChanged(object sender, EventArgs e)
        {
            atualizaDgv();
        }
    }
}
