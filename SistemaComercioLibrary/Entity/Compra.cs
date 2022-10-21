using SistemaComercioLibrary.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class Compra
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
        [MaxLength(30, ErrorMessage = "O total da compra não pode ultrapassar 30 caracteres!")]
        public double Total_Compra { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "A situação da compra não pode ultrapassar 30 caracteres!")]
        public string Situacao_Compra { get; set; }
        [Required]
        public Fornecedor Fornecedor { get; set; }

        public int Id_Fornecedor { get; set; }
        public List<ItemCompra> ItemCompra { get; set; }

    }
}
