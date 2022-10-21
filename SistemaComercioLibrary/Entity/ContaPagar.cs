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
        [MaxLength(30, ErrorMessage = "A descrição não pode ultrapassar 30 caracteres!")]
        public string Descricao { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "A data de lançamento não pode ultrapassar 10 caracteres!")]
        public DateTime Data_Lancamento { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "A data de vencimento não pode ultrapassar 10 caracteres!")]
        public DateTime Data_Vencimento { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "O valor não pode ultrapassar 30 caracteres!")]
        public double Valor { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Pago não pode ultrapassar 30 caracteres!")]
        public double Pago { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "A data de pagamento não pode ultrapassar 10 caracteres!")]
        public DateTime Data_Pagamento { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "O valor de pagamento não pode ultrapassar 30 caracteres!")]
        public double Valor_Pagamento { get; set; }
        [Required]
        public Fornecedor Fornecedor { get; set; }


        public int Id_Fornecedor { get; set; }
    }
}
