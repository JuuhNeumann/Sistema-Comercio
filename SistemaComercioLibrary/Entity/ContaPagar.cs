using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class ContaPagar
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public DateTime Data_Lancamento { get; set; }
        [Required]
        public DateTime Data_Vencimento { get; set; }
        [Required]
        public double Valor { get; set; }
        [Required]
        public double Pago { get; set; }
        [Required]
        public DateTime Data_Pagamento { get; set; }
        [Required]
        public double Valor_Pagamento { get; set; }
        [Required]
        public Fornecedor Id_Fornecedor { get; set; }


        public ContaPagar(int id, string descricao, DateTime data_Lancamento, DateTime data_Vencimento, double valor, double pago, DateTime data_Pagamento, double valor_Pagamento, Fornecedor id_Fornecedor)
        {
            Id = id;
            Descricao = descricao;
            Data_Lancamento = data_Lancamento;
            Data_Vencimento = data_Vencimento;
            Valor = valor;
            Pago = pago;
            Data_Pagamento = data_Pagamento;
            Valor_Pagamento = valor_Pagamento;
            Id_Fornecedor = id_Fornecedor;
        }
    }
}
