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
        public string IdCompra { get; set; }
        public string Descricao { get; set; }
        public string DataLancamento { get; set; }
        public string DataVencimento { get; set; }
        public string Valor { get; set; }
        public string Pago { get; set; }
        public string DataPagamento { get; set; }
        public string ValorPagamento { get; set; }
        public string FormaPagamento { get; set; }
        public string Parcelamento { get; set; }
        public string Fornecedor { get; set; }


        public List<string> Compras { get; set; }

        public FormRelatorioContaPagar(ContaPagar obj)
        {
            Id = obj.Id.ToString();
            obj.Fornecedor.Compra.ForEach(c => Compras.Add(c.Id.ToString())); //n sei se ta certo
            Descricao = obj.Descricao;
            DataLancamento = obj.Data_Lancamento.ToString();
            DataVencimento = obj.Data_Vencimento.ToString();
            Valor = obj.Valor.ToString();
            Pago = obj.Pago.ToString();
            DataPagamento = obj.Data_Pagamento.ToString();
            ValorPagamento = obj.Valor_Pagamento.ToString();
            FormaPagamento = obj.FormaPagamento;
            Parcelamento = obj.Parcela.ToString();
            Fornecedor = obj.Fornecedor.Nome;
        }

        public FormRelatorioContaPagar(Compra obj)
        {
            IdCompra = obj.Id.ToString();
        }

        public FormRelatorioContaPagar()
        {
            Compras = new List<string>();
        }
    }
}
