using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaTratorPecas.Estoque
{
    public partial class frmMainProduto : Form
    {
        //instancias
        Main.frmMain main = null;

        //metodos
        public void AtualizaDgv()
        {
            string pesquisarPor()
            {
                switch (cbxPesquissarPor.Text)
                {
                    case "Código":
                        return "pdt.codigo";
                    case "Descrição":
                        return "pdt.descricao";
                    case "Marca":
                        return "mrc.descricao";
                    case "Referência do fornecedor":
                        return "pdt.RefFornecedor";
                    default:
                        return null;
                }
            }

            string inativo()
            {
                if (chkInativos.Checked)
                {
                    return " pdt.inativo in ('0','1') ";
                }
                else
                {
                    return " pdt.inativo = 0 ";
                }
            }

            dataProduto.AtualizaDgv(dgvProdutos, pesquisarPor(), tbxPalavraChave.Text, inativo());
            lblEncontrados.Text = "Produtos encontrados: " + dgvProdutos.RowCount;
        }

        public frmMainProduto(Main.frmMain main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void FrmMainProduto_Load(object sender, EventArgs e)
        {
            cbxPesquissarPor.Text = "Descrição";
            AtualizaDgv();
        }

        private void ChkInativos_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaDgv();
        }

        private void TbxPalavraChave_TextChanged(object sender, EventArgs e)
        {
            AtualizaDgv();
        }

        private void CbxPesquissarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaDgv();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (main != null)
                {
                    main.tbxFornecedor.Text = dgvProdutos.CurrentRow.Cells[0].Value.ToString();
                    main.tbxDescricao.Text = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
                    Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops! Algo inesperado aconteceu, contate o seu suporte." + "\n" + "\n" + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
