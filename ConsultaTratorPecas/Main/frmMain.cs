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
using ConsultaTratorPecas.Estoque;
using Microsoft.Office.Interop.Excel;


namespace ConsultaTratorPecas.Main
{
    public partial class frmMain : Form
    {
        //metodos
        async Task ExportarExcel(ProgressBar progress, DataGridView dgv)
        {

            try
            {
                SaveFileDialog salvar = new SaveFileDialog();
                Microsoft.Office.Interop.Excel.Application app;
                Microsoft.Office.Interop.Excel.Workbook WorkBook;
                Microsoft.Office.Interop.Excel.Worksheet WorkSheet;
                object misValue = System.Reflection.Missing.Value;

                app = new Microsoft.Office.Interop.Excel.Application();
                WorkBook = app.Workbooks.Add(misValue);
                WorkSheet = (Worksheet)WorkBook.Worksheets.get_Item(1);

                int i = 0;
                int j = 0;

                progress.Visible = true;
                progress.Maximum = dgv.RowCount;

                for (i = 0; i <= dgvPdtCompra.RowCount - 1; i++)
                {
                    progress.Increment(1);

                    for (j = 0; j <= dgvPdtCompra.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgvPdtCompra[j, i];
                        WorkSheet.Cells[i + 1, j + 1] = cell.Value;
                    }
                }


                salvar.Title = "Salvar para Excel";
                salvar.Filter = "Arquivo do Excel *.xls | *.xls";
                if (salvar.ShowDialog() == DialogResult.OK)
                {
                    WorkBook.SaveAs(salvar.FileName, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,

                    XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    WorkBook.Close(true, misValue, misValue);
                    app.Quit(); // encerra o excel
                    MessageBox.Show("Exportado com sucesso!");
                }

                progress.Value = 0;
                progress.Visible = false;
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
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
            string fornecedor()
            {
                if (string.IsNullOrWhiteSpace(tbxFornecedor.Text))
                {
                    return null;
                }
                else
                {
                    return " and pdt.fornecedor = " + tbxFornecedor.Text;
                }
            }
            string grupo()
            {
                if (string.IsNullOrWhiteSpace(tbxGrupo.Text))
                {
                    return null;
                }
                else
                {
                    return " and pdt.grupo in ( " + tbxGrupo.Text.Substring(0, tbxGrupo.TextLength - 1) + ")";
                }
            }

            try
            {
                data.AtualizaDgvPdtCompra(dgvPdtCompra,
                                          grupo(),
                                          fornecedor(),
                                          Convert.ToDateTime(tbxDataIniEst.Text).ToString("yyyy-MM-dd"),
                                          Convert.ToDateTime(tbxDataFinEst.Text).ToString("yyyy-MM-dd"));
                try
                {
                    if (dgvPdtCompra.RowCount > 0)
                    {
                        //dgvPdtCompra.Rows.Cast<DataGridViewRow>().ToList().ForEach(p => p.Cells["estEcoDataGridViewTextBoxColumn"].Value = data.EstoqueEco(p.Cells[0].Value.ToString()));
                        data.EstoqueEco2(dgvPdtCompra);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Erro ao buscar estoque do Eco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }



                if (dgvPdtCompra.RowCount < 1)
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                lblCompras.Text = "Compras encontradas: " + dgvPdtCompra.RowCount;

            }
            catch (Exception e)
            {

                throw e;
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

                Fornecedor.frmMainFornecedor fornecedor = new Fornecedor.frmMainFornecedor(this);
                fornecedor.ShowDialog();


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
                if (!string.IsNullOrWhiteSpace(tbxFornecedor.Text))
                {
                    tbxDescricao.Text = data.NomeFornecedor(tbxFornecedor.Text);
                }
                else
                {
                    tbxDescricao.Text = null;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops! Algo inesperado aconteceu, contate o seu suporte." + "\n" + "\n" + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TbxGrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                frmGrupo grupo = new frmGrupo(this);
                grupo.ShowDialog();
            }
        }

        private async void BtnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                await ExportarExcel(progressBar, dgvPdtCompra);
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
