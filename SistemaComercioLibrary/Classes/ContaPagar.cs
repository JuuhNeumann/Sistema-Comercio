using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class ContaPagar
    {

        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Data_Lancamento { get; set; }
        public DateTime Data_Vencimento { get; set; }
        public double Valor { get; set; }
        public double Pago { get; set; }
        public DateTime Data_Pagamento { get; set; }
        public double Valor_Pagamento { get; set; }


        public ContaPagar(int id, string descricao, DateTime data_Lancamento, DateTime data_Vencimento, double valor, double pago, DateTime data_Pagamento, double valor_Pagamento)
        {
            Id = id;
            Descricao = descricao;
            Data_Lancamento = data_Lancamento;
            Data_Vencimento = data_Vencimento;
            Valor = valor;
            Pago = pago;
            Data_Pagamento = data_Pagamento;
            Valor_Pagamento = valor_Pagamento;
        }
    }
}
