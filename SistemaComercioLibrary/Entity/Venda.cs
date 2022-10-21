using SistemaComercioLibrary.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class Venda
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "A data não pode ultrapassar 10 caracteres!")]
        public DateTime Data { get; set; }
        [Required]
        [MaxLength(5, ErrorMessage = "A hora não pode ultrapassar 5 caracteres!")]
        public DateTime Hora { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "O total da venda não pode ultrapassar 30 caracteres!")]
        public double Total_Venda { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "A situação da venda não pode ultrapassar 30 caracteres!")]
        public string Situacao_Venda { get; set; }
        [Required]
        public Cliente Cliente { get; set; }

        public int Id_Cliente { get; set; }
        public List<FormaPagamentoVenda> FormaPagamentoVenda { get; set; }
        public List<ItemVenda> ItemVenda { get; set; }

    }
}
