using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class ContaReceber
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
        public double Recebido { get; set; }
        [Required]
        public DateTime Data_Recebimento { get; set; }
        [Required]
        public double Valor_Recebimento { get; set; }
        [Required]
        public Cliente Id_Cliente { get; set; }


        public ContaReceber(int id, string descricao, DateTime data_Lancamento, DateTime data_Vencimento, double valor, double recebido, DateTime data_Recebimento, double valor_Recebimento, Cliente id_Cliente)
        {
            Id = id;
            Descricao = descricao;
            Data_Lancamento = data_Lancamento;
            Data_Vencimento = data_Vencimento;
            Valor = valor;
            Recebido = recebido;
            Data_Recebimento = data_Recebimento;
            Valor_Recebimento = valor_Recebimento;
            Id_Cliente = id_Cliente;
        }
    }
}
