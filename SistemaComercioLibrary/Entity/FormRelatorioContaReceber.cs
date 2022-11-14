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
        public string Produto { get; set; }
        public string DataLancamento { get; set; }
        public string DataVencimento { get; set; }
        public string Valor { get; set; }
        public string Recebido { get; set; }
        public string DataRecebimento { get; set; }
        public string ValorRecebimento { get; set; }
        public string Cliente { get; set; }


        public List<string> Produtos { get; set; }
        public List<string> ItemVendas { get; set; }

        public FormRelatorioContaReceber(ContaReceber obj)
        {
            Id = obj.Id.ToString();
            //Produto = obj.Fornecedor.Produto.Nome; //n tem .Nome
            DataLancamento = obj.Data_Lancamento.ToString();
            DataVencimento = DataVencimento.ToString();
            Valor = obj.Valor.ToString();
            Recebido = obj.Recebido.ToString();
            DataRecebimento = obj.Data_Recebimento.ToString();
            ValorRecebimento = obj.Valor_Recebimento.ToString();
            Cliente = obj.Cliente.Nome;

        }

        public FormRelatorioContaReceber()
        {
            Produtos = new List<string>();
            ItemVendas = new List<string>();

        }
    }
}
