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
        public DateTime Data { get; set; }
        [Required]
        public DateTime Hora { get; set; }
        [Required]
        public double Total_Compra { get; set; }
        [Required]
        public string Situacao_Compra { get; set; }
        [Required]
        public Fornecedor Fornecedor { get; set; }

        public int Id_Fornecedor { get; set; }
        public List<ItemCompra> ItemCompra { get; set; }

    }
}
