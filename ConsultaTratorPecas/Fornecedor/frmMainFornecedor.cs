using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaTratorPecas.Fornecedor
{
    public partial class frmMainFornecedor : Form
    {
        //INSTANCIAS
        Main.frmMain main = null;

        //METODOS
        void AtualizaDgv()
        {
            string pesquisarPor()
            {
                switch (cbxPesquissarPor.Text)
                {
                    case "Razão":
                        return "descricao";
                    case "Código":
                        return "codigo";
                    case "Fantasia":
                        return "fantasia";
                    case "CPF/CNPJ":
                        return "a.[Cgc ou Cpf]";
                    case "Telefone":
                        return "fone";
                    default:
                        return "null";

                }

            }

            dataFornecedor.AtualizaDgv(dgvFornecedor, pesquisarPor(), tbxPalavraChave.Text);
            lblEncontrados.Text = "Fornecedores encontrados: " + dgvFornecedor.RowCount;

        }

        public frmMainFornecedor(Main.frmMain main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void FrmMainFornecedor_Load(object sender, EventArgs e)
        {
            cbxPesquissarPor.Text = "Razão";
            AtualizaDgv();
        }

        private void TbxPalavraChave_TextChanged(object sender, EventArgs e)
        {
            AtualizaDgv();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            main.tbxCodigo.Text = dgvFornecedor.CurrentRow.Cells[0].Value.ToString();
            Close();
        }
    }
}
