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

namespace ConsultaTratorPecas.PedidoProduto
{
    public partial class frmPedidoProduto : Form
    {
        //metodos
        void AtualizaDgv()
        {
            try
            {
                dataPedido.AtualizaDgv(dgvProdutos, tbxPedido.Text);
                tbxTotalLiquid.Text = dgvProdutos.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[6].Value)).ToString("N2");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops! Algo inesperado aconteceu, contate o seu suporte." + "\n" + "\n" + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //instancias
        frmMain main = null;

        public frmPedidoProduto(frmMain main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPedidoProduto_Load(object sender, EventArgs e)
        {
            AtualizaDgv();
            btnSair.Select();
        }

        private void TbxPedido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataPedido data = new dataPedido();
                modelPedidoProduto model = data.BuscaInformacoes(tbxPedido.Text);
                tbxCliente.Text = model.cliente;
                tbxCondPag.Text = model.CondPagamento;
                tbxDataCad.Text = model.DataCadastro;
                tbxDataReg.Text = model.DataRegistro;
                tbxTotalBruto.Text = model.TotalBruto;
                tbxDescontos.Text = model.Descontos;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops! Algo inesperado aconteceu, contate o seu suporte." + "\n" + "\n" + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
