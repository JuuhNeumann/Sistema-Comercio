using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class ContaReceber
    {

        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Data_Lancamento { get; set; }
        public DateTime Data_Vencimento { get; set; }
        public double Valor { get; set; }
        public double Recebido { get; set; }
        public DateTime Data_Recebimento { get; set; }
        public double Valor_Recebimento { get; set; }


        public ContaReceber(int id, string descricao, DateTime data_Lancamento, DateTime data_Vencimento, double valor, double recebido, DateTime data_Recebimento, double valor_Recebimento)
        {
            Id = id;
            Descricao = descricao;
            Data_Lancamento = data_Lancamento;
            Data_Vencimento = data_Vencimento;
            Valor = valor;
            Recebido = recebido;
            Data_Recebimento = data_Recebimento;
            Valor_Recebimento = valor_Recebimento;
        }
    }
}
