using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Entity
{
    public class FormRelatorioContaPagar
    {
        public string Id { get; set; }
        //public string Produto { get; set; }
        public string DataLancamento { get; set; }
        public string DataVencimento { get; set; }
        public string Valor { get; set; }
        public string Pago { get; set; }
        public string DataPagamento { get; set; }
        public string ValorPagamento { get; set; }
        public string Fornecedor { get; set; }


        public List<string> Produtos { get; set; }

        public FormRelatorioContaPagar(ContaPagar obj)
        {
            Id = obj.Id.ToString();
            //Produto = obj.Fornecedor.Compra.Produto.Nome;
            DataLancamento = obj.Data_Lancamento.ToString();
            DataVencimento = DataVencimento.ToString();
            Valor = obj.Valor.ToString();
            Pago = obj.Pago.ToString();
            DataPagamento = obj.Data_Pagamento.ToString();
            ValorPagamento = obj.Valor_Pagamento.ToString();
            Fornecedor = obj.Fornecedor.Nome;


            //obj.Fornecedor.Produto.ForEach(p => Produtos.Add(p.Nome));
        }

        public FormRelatorioContaPagar()
        {
            Produtos = new List<string>();

        }
    }
}
