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
        //metodos
        public void AtualizaDgv()
        {
            string pesquisarPor()
            {
                switch (cbxPesquissarPor.Text)
                {
                    case "Código":
                        return "codigo";
                    case "Descrição":
                        return "";
                    case "Marca":
                        return "";
                    case "Referência do fornecedor":
                        return "";
                    default:
                        return null;
                        break;
                }
            }
        }

        public frmMainProduto()
        {
            InitializeComponent();
        }

        private void FrmMainProduto_Load(object sender, EventArgs e)
        {
            cbxPesquissarPor.Text = "Descrição";

        }
    }
}
