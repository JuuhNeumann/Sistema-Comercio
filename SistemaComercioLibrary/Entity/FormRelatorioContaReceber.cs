using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Entity
{
    public class FormRelatorioContaReceber
    {

        public string Id { get; set; }
        public string IdVenda { get; set; }
        public string Descricao { get; set; }
        public string DataLancamento { get; set; }
        public string DataVencimento { get; set; }
        public string Valor { get; set; }
        public string Recebido { get; set; }
        public string DataRecebimento { get; set; }
        public string ValorRecebimento { get; set; }
        public string FormaPagamento { get; set; }
        public string Parcelamento { get; set; }
        public string Cliente { get; set; }


        public List<string> Vendas { get; set; }

        public FormRelatorioContaReceber(ContaReceber obj)
        {
            Id = obj.Id.ToString();
            obj.Cliente.Venda.ForEach(c => Vendas.Add(c.Id.ToString())); //n sei se ta certo
            Descricao = obj.Descricao;
            DataLancamento = obj.Data_Lancamento.ToString();
            DataVencimento = obj.Data_Vencimento.ToString();
            Valor = obj.Valor.ToString();
            Recebido = obj.Recebido.ToString();
            DataRecebimento = obj.Data_Recebimento.ToString();
            ValorRecebimento = obj.Valor_Recebimento.ToString();
            FormaPagamento = obj.FormaPagamento.ToString();
            Parcelamento = obj.Parcela.ToString();
            Cliente = obj.Cliente.Nome;

        }

        public FormRelatorioContaReceber()
        {
            Vendas = new List<string>();
        }
    }
}
