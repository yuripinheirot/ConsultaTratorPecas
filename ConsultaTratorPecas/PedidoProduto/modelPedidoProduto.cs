using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaTratorPecas.PedidoProduto
{
    class modelPedidoProduto
    {
        public string cliente { get; set; }
        public string CondPagamento { get; set; }
        public string DataCadastro { get; set; }
        public string DataRegistro { get; set; }
        public string Descontos { get; set; }
        public string TotalBruto { get; set; }
    }
}
