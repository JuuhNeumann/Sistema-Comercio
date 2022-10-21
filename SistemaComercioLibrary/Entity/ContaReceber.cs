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
        [MaxLength(30, ErrorMessage = "Recebido não pode ultrapassar 30 caracteres!")]
        public double Recebido { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "A data de recebimento não pode ultrapassar 10 caracteres!")]
        public DateTime Data_Recebimento { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "O valor recebido não pode ultrapassar 30 caracteres!")]
        public double Valor_Recebimento { get; set; }
        [Required]
        public Cliente Cliente { get; set; }

        public int Id_Cliente { get; set; }
    }
}
