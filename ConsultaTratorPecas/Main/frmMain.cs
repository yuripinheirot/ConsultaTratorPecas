using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultaTratorPecas.PedidoProduto;

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

            data.AtualizaDgvPedido(dgvPedidos, cliente(), Convert.ToDateTime(tbxDataIni.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(tbxDataFin.Text).ToString("yyyy-MM-dd"));
            lblPedidosEnc.Text = "Pedidos encontrados: " + dgvPedidos.RowCount;
            lblValorTotal.Text = "Valor total: " + dgvPedidos.Rows.Cast<DataGridViewRow>().Sum(p => Convert.ToDecimal(p.Cells[4].Value)).ToString("N2");
            if (dgvPedidos.RowCount == 0)
            {
                MessageBox.Show("Nenhum registro encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void AtualizaDgvPdtCompra()
        {
            if (string.IsNullOrWhiteSpace(tbxCodigo.Text))
            {
                return;
            }

            string tipoCompra = cbxPesquisarPor.Text.Substring(0, 1) == "F" ? "nie.ClienteItens" : "nie.produto";
            string tipoVenda = cbxPesquisarPor.Text.Substring(0, 1) == "F" ? "nie.ClienteItens" : "ivd.produto";

            data.AtualizaDgvPdtCompra(dgvPdtCompra, tipoCompra, tbxCodigo.Text, Convert.ToDateTime(tbxDataIniEst.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(tbxDataFinEst.Text).ToString("yyyy-MM-dd"));
            data.AtualizaDgvPdtVenda(dgvPdtVenda,tipoVenda, tbxCodigo.Text, Convert.ToDateTime(tbxDataIniEst.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(tbxDataFinEst.Text).ToString("yyyy-MM-dd"));

            if (dgvPdtCompra.RowCount == 0 && dgvPdtVenda.RowCount == 0)
            {
                MessageBox.Show("Nenhum registro encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
            cbxPesquisarPor.Text = "Fornecedor";
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
                if (cbxPesquisarPor.Text == "Produto")
                {
                    Estoque.frmMainProduto produto = new Estoque.frmMainProduto(this);
                    produto.ShowDialog();
                }
                else
                {
                    Fornecedor.frmMainFornecedor fornecedor = new Fornecedor.frmMainFornecedor(this);
                    fornecedor.ShowDialog();
                }

            }
        }

        private void BtnPesquisarEst_Click(object sender, EventArgs e)
        {
            AtualizaDgvPdtCompra();
        }

        private void DgvPedidos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataPedido.AtualizaDgv(dgvPedProdutos, dgvPedidos.CurrentRow.Cells[0].Value.ToString());
                modelPedidoProduto model = new modelPedidoProduto();
                dataPedido data = new dataPedido();
                model = data.BuscaInformacoes(dgvPedidos.CurrentRow.Cells[0].Value.ToString());
                tbxCondPag.Text = model.CondPagamento;
                tbxDataCad.Text = model.DataCadastro;
                tbxDataReg.Text = model.DataRegistro;
                tbxTotalBruto.Text = model.TotalBruto;
                tbxDescontos.Text = model.Descontos;
                tbxTotalLiquid.Text = dgvPedProdutos.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[6].Value)).ToString("N2");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops! Algo inesperado aconteceu, contate o seu suporte." + "\n" + "\n" + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TbxIdProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tbxCodigo.Text))
                {
                    if (cbxPesquisarPor.Text == "Fornecedor")
                    {
                        tbxDescricao.Text = data.NomeFornecedor(tbxCodigo.Text);
                    }
                    else
                    {
                        tbxDescricao.Text = data.NomeProduto(tbxCodigo.Text);
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops! Algo inesperado aconteceu, contate o seu suporte." + "\n" + "\n" + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvPdtVenda_DoubleClick(object sender, EventArgs e)
        {
            frmPedidoProduto pdt = new frmPedidoProduto(this);
            pdt.tbxPedido.Text = dgvPdtVenda.CurrentRow.Cells[0].Value.ToString();
            pdt.ShowDialog();
        }
    }
}
