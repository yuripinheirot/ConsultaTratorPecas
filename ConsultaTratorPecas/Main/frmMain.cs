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
        //metodos
        public void AtualizaDgvPedido()
        {
            string cliente()
            {
                if (!string.IsNullOrEmpty(tbxIdCliente.Text))
                {
                    return "AND cli.codigo = " + tbxIdCliente.Text;
                }
                else
                {
                    return null;
                }
            }

            data.AtualizaDgvPedido(dgvPedidos, cliente(), tbxDataIni.Text, tbxDataFin.Text);
            lblPedidosEnc.Text = "Pedidos encontrados: " + dgvPedidos.RowCount;
        }

        public void AtualizaDgvPdtCompra()
        {
            if (string.IsNullOrWhiteSpace(tbxIdProduto.Text))
            {
                return;
            }

            data.AtualizaDgvPdtCompra(dgvPdtCompra, tbxIdProduto.Text, Convert.ToDateTime(tbxDataIniEst.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(tbxDataFinEst.Text).ToString("yyyy-MM-dd"));
        }

        //inicializadores
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

        private void TbxIdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Cliente.frmMainCliente main = new Cliente.frmMainCliente(this);
                main.ShowDialog();
            }
        }

        private void TbxIdCliente_TextChanged(object sender, EventArgs e)
        {
            tbxNomeCliente.Text = data.NomeCliente(tbxIdCliente.Text);
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizaDgvPedido();
        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.RowCount > 0)
            {
                PedidoProduto.frmPedidoProduto pedido = new PedidoProduto.frmPedidoProduto(this);
                pedido.tbxPedido.Text = dgvPedidos.CurrentRow.Cells[0].Value.ToString();
                pedido.ShowDialog();
            }
        }

        private void TbxProdutoEst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Estoque.frmMainProduto produto = new Estoque.frmMainProduto(this);
                produto.ShowDialog();
            }
        }

        private void BtnPesquisarEst_Click(object sender, EventArgs e)
        {
            AtualizaDgvPdtCompra();
        }
    }
}
