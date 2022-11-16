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
        [MaxLength(255)]
        public string Descricao { get; set; }
        [Required]
        [MaxLength(10)]
        public DateTime Data_Lancamento { get; set; }
        [Required]
        [MaxLength(10)]
        public DateTime Data_Vencimento { get; set; }
        [Required]
        [MaxLength(255)]
        public double Valor { get; set; }
        [Required]
        [MaxLength(255)]
        public double Pago { get; set; }
        [Required]
        [MaxLength(10)]
        public DateTime Data_Pagamento { get; set; }
        [Required]
        [MaxLength(255)]
        public double Valor_Pagamento { get; set; }

        public int Parcela { get; set; }
        [Required]
        public virtual Fornecedor Fornecedor { get; set; }
        public int Id_Fornecedor { get; set; }
    }
}
